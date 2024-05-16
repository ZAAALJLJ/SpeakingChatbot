using MySql.Data.MySqlClient;
using SpeakingChatbot.db;
using SpeakingChatbot.socket;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpeakingChatbot.UserControls {
    public partial class LoginUC : UserControl {
        public event EventHandler<string> LoginEnterClick;
        public event EventHandler<object> LoginSetClient;

        Crud crud;
        public LoginUC() {
            InitializeComponent();
            crud = new Crud();
        }

        private void enterBtn_Click(object sender, EventArgs e) {
            var username = usernameTextBox.Text;
            var password = passwordTextBox.Text;
            username.Trim();

            if (!string.IsNullOrWhiteSpace(username) &&
              !string.IsNullOrWhiteSpace(password)) {
                // get user by uername function sa db
                // if found, check yung password

                bool isFound = crud.checkCredentials(username, password);

                if (!isFound) {
                    errorMsg.Text = "Incorrect username of password.";
                    errorMsg.Visible = true;
                } else {
                    // connect socket
                    socketControl client = new socketControl();
                    client.ConnectToServer(username);


                    LoginSetClient?.Invoke(this, client);
                    LoginEnterClick?.Invoke(this, username);
                }

            } else {
                errorMsg.Text = "Fill up all forms.";
                errorMsg.Visible = true;
            }
        }

        private void AdjustFontSize() {
            float newSize = this.Width * 0.018f;
            if (newSize < 1) {
                newSize = 1;
            }
            usernameTextBox.Font = new Font(usernameTextBox.Font.FontFamily, newSize);
            passwordTextBox.Font = new Font(passwordTextBox.Font.FontFamily, newSize);
        }

        private void LoginUC_Click(object sender, EventArgs e) {
            AdjustFontSize();
        }
    }
}
