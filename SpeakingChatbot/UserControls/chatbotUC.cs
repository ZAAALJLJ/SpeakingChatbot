using SpeakingChatbot.db;
using SpeakingChatbot.socket;
using SpeakingChatbot.UserControls.SubUC;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Speech.AudioFormat;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpeakingChatbot.UserControls {
    public partial class ChatbotUC : UserControl {
        public event EventHandler<string> BackBtnClick;

        socketControl client;
        AudioDetector audioDetector = new AudioDetector();



        string username;
        public ChatbotUC(string userName, Object Client) {
            client = (socketControl)Client;

            InitializeComponent();
            username = userName;
            client.msgChatBotReceivedEvent += msgReceived;
            // chatTbl.BackColor = Color.FromArgb(200, Color.Black);
        }

        public void msgReceived(object? sender, string[] infoArr) {
            Debug.WriteLine("aaaaaaaaaaaaa");
            var senderUser = infoArr[0];
            var receivingUser = infoArr[1];
            var msg = infoArr[2];

            Debug.WriteLine(senderUser);
            Debug.WriteLine(receivingUser);
            Debug.WriteLine(msg);


            TextChatModel textModel = null;
            if (!string.IsNullOrWhiteSpace(msg)) {
                textModel = new TextChatModel() {
                    Inbound = true,
                    Read = true,
                    Time = DateTime.Now,
                    Sender = senderUser,
                    // for now change it later to just msg
                    Body = senderUser + ": " + msg
                };
            }

            // chat 
            if (textModel != null) {
                // addMsg(textModel);
                var chatItem = new ChatItemUC(textModel);
                chatItem.Name = "chatItem" + chatItem.Controls.Count;
                chatItem.Dock = DockStyle.Top;

                chatPanel.Invoke((MethodInvoker)(() => {
                    chatPanel.Controls.Add(chatItem);
                    chatPanel.ScrollControlIntoView(chatItem);
                }));

                chatItem.Invoke((MethodInvoker)(() => chatItem.BringToFront()));

                chatItem.Invoke((MethodInvoker)(() => chatItem.ResizeBubbles((int)(chatPanel.Width * 0.4))));
            }

            string[] words = msg.Trim().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string wordDapat = words[0];
            string firstWord = words.Length > 0 ? words[0] : "";

            string wavFilePath = @"..\\..\\..\\assets\" + firstWord + ".wav";
            SynthesizeTextToSpeech(msg, wavFilePath);

            string mp3FilePath = @"..\\..\\..\\assets\" + firstWord + ".mp3";
            Converter.ConvertWavToMp3(wavFilePath, mp3FilePath);

            string wordDapatCopy = wordDapat;

            EventHandler<string> audioHandler = null;
            audioHandler = (audioSender, message) => {
                VoiceDetected.HandleVoice(this, message, mp3FilePath, firstWord, wordDapatCopy);

                audioDetector.SoundDetected -= audioHandler;
            };

            audioDetector.SoundDetected += audioHandler;
            audioDetector.DetectAudio(mp3FilePath);

            File.Delete(wavFilePath);
            File.Delete(mp3FilePath);
            audioDetector.Dispose();

        }

        private void backBtn_Click(object sender, EventArgs e) {
            BackBtnClick?.Invoke(this, username);
        }

        private void addMsg(IChatModel textModel) {
            // add sender name and time // add panel

            var chatItem = new ChatItemUC(textModel);
            chatItem.Name = "chatItem" + chatItem.Controls.Count;
            chatItem.Dock = DockStyle.Top;
            chatPanel.Controls.Add(chatItem);
            chatItem.BringToFront();


            chatItem.ResizeBubbles((int)(chatPanel.Width * 0.4));

            chatPanel.ScrollControlIntoView(chatItem);
        }

        private void sendBtn_Click(object sender, EventArgs e) {
            string msg = msgBox.Text;
            msg.Trim();

            TextChatModel textModel = null;

            if (!string.IsNullOrWhiteSpace(msg)) {
                textModel = new TextChatModel() {
                    Inbound = false,
                    Read = true,
                    Time = DateTime.Now,
                    Sender = "currentUser", // galing db to
                    Body = msg
                };
            }

            try {
                // chat 
                if (textModel != null) {
                    addMsg(textModel);
                    msgBox.Text = string.Empty;
                    client.SendMsgToServer(msg, username, username);
                }

            } catch (Exception err) {
                textModel = new TextChatModel() {
                    Inbound = false,
                    Read = true,
                    Time = DateTime.Now,
                    Sender = "currentUser", // galing db to
                    Body = "Failed to send message. See error:\r\n" + err.Message
                };
                addMsg(textModel);
            }
        }

        private void AdjustFontSize() {
            float newSize = this.Width * 0.008f;
            if (newSize < 1) {
                newSize = 1;
            }
            msgBox.Font = new Font(msgBox.Font.FontFamily, newSize);

        }

        private void ChatbotUC_Resize(object sender, EventArgs e) {
            AdjustFontSize();
        }

        static void SynthesizeTextToSpeech(string text, string filePath) {
            using (SpeechSynthesizer synth = new SpeechSynthesizer()) {
                synth.SelectVoiceByHints(VoiceGender.Female);
                synth.SetOutputToWaveFile(filePath, new SpeechAudioFormatInfo(32000, AudioBitsPerSample.Sixteen, AudioChannel.Mono));
                PromptBuilder builder = new PromptBuilder();
                builder.AppendText(text);
                synth.Speak(builder);
            }
        }
    }
}
