﻿using SpeakingChatbot.db;
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
        public SignUpUC() {
            InitializeComponent();
        }

        private void enterBtn_Click(object sender, EventArgs e) {
   

            var username = usernameTextBox.Text;
            var password = passwordTextBox.Text;
            var cPassword = cPasswordTextBox.Text;
            username.Trim();

            // get user by uername function sa db
            // if found send error, username is already taken

            if (!string.IsNullOrWhiteSpace(username) &&
              !string.IsNullOrWhiteSpace(password) &&
              !string.IsNullOrWhiteSpace(cPassword)) {

                Crud crud = new Crud();

                if (true) {
                    errorMsg.BackColor = Color.Red;
                    errorMsg.Text = "Username is already taken.";
                    errorMsg.Visible = true;
                }
                if (password != cPassword) {
                    errorMsg.BackColor = Color.Red;
                    errorMsg.Text = "Passwords do not match.";
                    errorMsg.Visible = true;
                }

                crud.createUser(username, password);

                // kahulihan pag success na pag sign in
                // add db
                errorMsg.BackColor = Color.Lime;
                errorMsg.Text = "Signed up successfully";
                errorMsg.Visible = true;

                // count 5 before proceed sa login page

                SignUpEnterClick?.Invoke();

            } else {
                errorMsg.BackColor = Color.Red;
                errorMsg.Text = "Fill up all the forms.";
                errorMsg.Visible = true;
            }
        }

    }
}
