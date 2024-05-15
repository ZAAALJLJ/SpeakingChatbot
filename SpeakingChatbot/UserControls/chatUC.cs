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
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace SpeakingChatbot.UserControls {
    public partial class ChatUC : UserControl {

        public event EventHandler<string> BackBtnClick;

        socketControl client;

        Crud crud = new Crud();

        UsersUC users = new UsersUC();


        string username;

        string receivingUser = "@everyone";

        public ChatUC(string userName, Object Client) {

            client = (socketControl?)Client;

            InitializeComponent();

            username = userName;
/*            crud = new Crud();*/
            checkUsers();

            // avatarPanel.BackColor = Color.FromArgb(200, Color.Black);
            // chatPanel.BackColor = Color.FromArgb(200, Color.Black);

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
                usersPanel.Dock = DockStyle.Fill;
                UsersUC onlineUser = new UsersUC(onlineUsers[i], true);
                onlineUser.Width = usersPanel.Width;
                onlineUser.Height = (usersPanel.Height / 10);
                onlineUser.Dock = DockStyle.Top;
                usersPanel.Controls.Add(onlineUser);
            }

            string[] offlineUsers = crud.getUsers(username, 0);

            for (int i = 0; i < offlineUsers.Length; i++) {
                usersPanel.Visible = true;
                usersPanel.Dock = DockStyle.Fill;
                UsersUC offlineUser = new UsersUC(offlineUsers[i], false);
                offlineUser.Width = usersPanel.Width;
                offlineUser.Height = (usersPanel.Height / 10);
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
            };

            // di nagscroll
            chatPanel.Controls.Add(chatItem);

            chatItem.BringToFront();

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

        private void botBtn_Click(object sender, EventArgs e) {
            usersPanel.Visible = false;
            DahliaUC dahlia = new DahliaUC();
            dahlia.Dock = DockStyle.Fill;
            avatarPanel.Controls.Add(dahlia);
        }

        private void usersBtn_Click(object sender, EventArgs e) {
            usersPanel.Visible = true;
            usersPanel.Dock = DockStyle.Fill;
            users.Width = usersPanel.Width;
            users.Height = (usersPanel.Height / 10);
            users.Dock = DockStyle.Top;
            usersPanel.Controls.Add(users);

        }

        private void avatarPanel_SizeChanged(object sender, EventArgs e) {
            users.Height = (avatarPanel.Height / 10);
        }

        private void ChatUC_Load(object sender, EventArgs e) {
            usersPanel.Visible = false;
            DahliaUC dahlia = new DahliaUC();
            dahlia.Dock = DockStyle.Fill;
            avatarPanel.Controls.Add(dahlia);
        }
    }
}
