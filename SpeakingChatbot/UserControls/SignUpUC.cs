using SpeakingChatbot.db;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpeakingChatbot.UserControls {
    public partial class SignUpUC : UserControl {
        public event Action SignUpEnterClick;
        public event Action BackBtnClick;
        public SignUpUC() {
            InitializeComponent();
        }

        private void AdjustFontSize() {
            float newSize = this.Width * 0.018f;
            if (newSize < 1) {
                newSize = 1;
            }
            usernameTextBox.Font = new Font(usernameTextBox.Font.FontFamily, newSize);
            passwordTextBox.Font = new Font(passwordTextBox.Font.FontFamily, newSize);
            cPasswordTextBox.Font = new Font(cPasswordTextBox.Font.FontFamily, newSize);
        }


        private void enterBtn_Click(object sender, EventArgs e) {


            var username = usernameTextBox.Text;
            var password = passwordTextBox.Text;
            var cPassword = cPasswordTextBox.Text;
            username.Trim();

            if (!string.IsNullOrWhiteSpace(username) &&
              !string.IsNullOrWhiteSpace(password) &&
              !string.IsNullOrWhiteSpace(cPassword)) {

                Crud crud = new Crud();

                if (true) {
                }
                if (password != cPassword) {
                    errorMsg.BackColor = Color.Red;
                    errorMsg.Text = "Passwords do not match.";
                    errorMsg.Visible = true;
                }

                crud.createUser(username, password);

                usernameTextBox.Text = "";
                passwordTextBox.Text = "";
                cPasswordTextBox.Text = "";

                errorMsg.BackColor = Color.Lime;
                errorMsg.Text = "Account Created.";
                errorMsg.Visible = true;

            } else {
                errorMsg.BackColor = Color.Red;
                errorMsg.Text = "Fill up all the forms.";
                errorMsg.Visible = true;
            }
        }

        private void SignUpUC_Resize(object sender, EventArgs e) {
            AdjustFontSize();
        }

        private void backBtn_Click(object sender, EventArgs e) {
            BackBtnClick?.Invoke();
        }
    }
}
