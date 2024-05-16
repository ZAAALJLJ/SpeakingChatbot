using MySqlX.XDevAPI;
using MySqlX.XDevAPI.Common;
using SpeakingChatbot.db;
using SpeakingChatbot.Models;
using SpeakingChatbot.socket;
using SpeakingChatbot.socket.IO;
using SpeakingChatbot.UserControls.SubUC;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace SpeakingChatbot.UserControls {
    public partial class ChatUC : UserControl {

        public event EventHandler<string> BackBtnClick;

        socketControl client;

        Crud crud = new Crud();
        AudioDetector audioDetector = new AudioDetector();

        UsersUC users = new UsersUC();


        string username;

        string receivingUser = "@everyone";

        public ChatUC(string userName, Object Client) {

            client = (socketControl?)Client;

            InitializeComponent();

            username = userName;
            checkUsers();

            client.connectedEvent += userConnected;
            client.msgChatUsersReceivedEvent += msgReceived;
            client.userDisconnectEvent += userDisconnected;
        }

        public void checkUsers() {

            // will check pa
            Debug.WriteLine("here hehe");

            string[] onlineUsers = crud.getUsers(username, 1);

            for (int i = 0; i < onlineUsers.Length; i++) {
                usersPanel.Visible = true;
                usersPanel.Dock = DockStyle.Top;
                UsersUC onlineUser = new UsersUC(onlineUsers[i], true);
                onlineUser.Dock = DockStyle.Top;
                usersPanel.Controls.Add(onlineUser);
            }

            string[] offlineUsers = crud.getUsers(username, 0);

            for (int i = 0; i < offlineUsers.Length; i++) {
                usersPanel.Visible = true;
                usersPanel.Dock = DockStyle.Fill;
                UsersUC offlineUser = new UsersUC(offlineUsers[i], false);
                offlineUser.Dock = DockStyle.Top;
                usersPanel.Controls.Add(offlineUser);
            }
        }

        public void userConnected(object? sender, string userConnected) {
            // inform everyone lang na may new user
            Debug.WriteLine($"user connect: {userConnected}");
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
                var chatItem = new ChatItemUC(textModel) {
                    Name = "chatMsg" + chatPanel.Controls.Count,
                    Dock = DockStyle.Top
                };

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
                UserDetected.HandleVoice(this, message, mp3FilePath, firstWord, wordDapatCopy);

                audioDetector.SoundDetected -= audioHandler;
            };

            audioDetector.SoundDetected += audioHandler;
            audioDetector.DetectAudio(mp3FilePath);

            File.Delete(wavFilePath);
            File.Delete(mp3FilePath);
            audioDetector.Dispose();
        }

        private void userDisconnected(object? sender, string userDisconnected) {
            // checkUsers();
            Debug.WriteLine($"user connect: {userConnected}");
        }

        private void backBtn_Click(object sender, EventArgs e) {
            BackBtnClick?.Invoke(this, username);
        }

        private void addMsg(IChatModel textModel) {
            // add sender name and time // add panel

            var chatItem = new ChatItemUC(textModel) {
                Name = "chatMsg" + chatPanel.Controls.Count,
                Dock = DockStyle.Top,
                Margin = new Padding(10),
            };

            // di nagscroll
            chatPanel.Controls.Add(chatItem);

            chatItem.BringToFront();

            chatItem.ResizeBubbles((int)(chatPanel.Width * 0.4));

            chatPanel.ScrollControlIntoView(chatItem);
        }

        private void sendBtn_Click(object sender, EventArgs e) {
            string toUser = userNameLbl.Text;
            string msg = msgBox.Text;
            msg.Trim();

            IChatModel chatModel = null;
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
                // img
                if (chatModel != null) {
                    addMsg(chatModel);
                    //cancelAttachment(null, null);
                }

                // chat 
                if (textModel != null) {
                    addMsg(textModel);
                    msgBox.Text = string.Empty;

                    // send CLIENT TO SOCKET SERVER
                    client.SendMsgToServer(msg, username, receivingUser);
                }

            } catch (Exception err) {
                textModel = new TextChatModel() {
                    Inbound = false,
                    Read = true,
                    Time = DateTime.Now,
                    Sender = "currentUser", // galing db to
                    Body = "Failed to send message. See error:\r\n" + err.Message
                };

                Debug.WriteLine(err.Message);
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

        private void botBtn_Click(object sender, EventArgs e) {
            usersPanel.Visible = false;
            pictureBox1.Visible = true;
            pictureBox1.Dock = DockStyle.Fill;
            avatarPanel.Controls.Add(pictureBox1);

            botBtn.Image = Properties.Resources.dahliaclicked;
            usersBtn.Image = Properties.Resources.users;
        }

        private void usersBtn_Click(object sender, EventArgs e) {
            usersPanel.Visible = true;
            usersPanel.Dock = DockStyle.Fill;
            users.Width = usersPanel.Width;
            users.Height = (usersPanel.Height / 10);
            users.Dock = DockStyle.Top;
            usersPanel.Controls.Add(users);

            usersBtn.Image = Properties.Resources.usersclicked;
            botBtn.Image = Properties.Resources.dahlia__1_;
        }

        private void avatarPanel_SizeChanged(object sender, EventArgs e) {
            users.Height = (avatarPanel.Height / 10);
        }

        private void ChatUC_Load(object sender, EventArgs e) {
            usersPanel.Visible = false;
            pictureBox1.Visible = true;
            pictureBox1.Dock = DockStyle.Fill;
            avatarPanel.Controls.Add(pictureBox1);
        }

        private void ChatUC_Resize(object sender, EventArgs e) {
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
