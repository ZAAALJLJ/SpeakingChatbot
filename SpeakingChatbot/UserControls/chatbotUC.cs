using SpeakingChatbot.socket;
using SpeakingChatbot.UserControls.SubUC;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpeakingChatbot.UserControls {
    public partial class ChatbotUC : UserControl {
        public event EventHandler<string> BackBtnClick;

        socketControl client;

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
                var chatMsg = new ChatItemUC(textModel) {
                    Name = "chatMsg" + chatPanel.Controls.Count,
                    Dock = DockStyle.Top
                };

                chatPanel.Invoke((MethodInvoker)(() => {
                    chatPanel.Controls.Add(chatMsg);
                    chatPanel.ScrollControlIntoView(chatMsg);
                }));

                chatMsg.Invoke((MethodInvoker)(() => chatMsg.BringToFront()));
            }

        }

        private void backBtn_Click(object sender, EventArgs e) {
            BackBtnClick?.Invoke(this, username);
        }

        private void addMsg(IChatModel textModel) {
            // add sender name and time // add panel

            var chatItem = new ChatItemUC(textModel) {
                Name = "chatMsg" + chatPanel.Controls.Count,
                Dock = DockStyle.Top,
            };

            //chatItem.Dock = DockStyle.Fill;

            chatPanel.Controls.Add(chatItem);
            chatItem.BringToFront();

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


    }
}
