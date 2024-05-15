using SpeakingChatbot.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Drawing.Text;
using System.Diagnostics;
using SpeakingChatbot.socket;

namespace SpeakingChatbot {

    public partial class Chavatar : System.Windows.Forms.Form {

        // baguhin to -- copy loginUC
        WelcomeUC welcomeUC;
        LoginSignUpUC loginSignUpUC;
        LoginUC loginUC;
        SignUpUC signUpUC;
        MainMenuUC mainMenuUC;
        ChatbotUC chatbotUC;
        ChatUC chatUC;
        ForumsUC forumUC;
        ForumsFormUC forumsFormUC;
        FormUC formUC;

        socketControl client;

        string currentUser;



        public Chavatar() {
            InitializeComponent();
            WelcomeUC();
            // FormUC();
        }


        void setClient(object? sender, Object Client) {
            client = (socketControl)Client;
        }

        protected void WelcomeUC() {
            welcomeUC = new WelcomeUC();
            welcomeUC.WelcomeClick += LoginSignUpUC;

            MainPanel.Controls.Clear();
            welcomeUC.Dock = DockStyle.Fill;
            MainPanel.Controls.Add(welcomeUC);
        }

        protected void LoginSignUpUC() {
            loginSignUpUC = new LoginSignUpUC();
            loginSignUpUC.WelcomeClick += WelcomeUC;
            loginSignUpUC.LoginClick += LoginUC;
            loginSignUpUC.SignUpClick += SignUpUC;

            MainPanel.Controls.Clear();
            loginSignUpUC.Dock = DockStyle.Fill;
            MainPanel.Controls.Add(loginSignUpUC);
        }

        protected void LoginUC() {
            loginUC = new LoginUC();
            loginUC.LoginEnterClick += MainMenuUC;
            loginUC.LoginSetClient += setClient;
            MainPanel.Controls.Clear();
            loginUC.Dock = DockStyle.Fill;
            MainPanel.Controls.Add(loginUC);
        }

        protected void SignUpUC() {
            signUpUC = new SignUpUC();
            signUpUC.SignUpEnterClick += LoginUC;

            MainPanel.Controls.Clear();
            signUpUC.Dock = DockStyle.Fill;
            MainPanel.Controls.Add(signUpUC);
        }

        protected void MainMenuUC(object? sender, string username) {
            mainMenuUC = new MainMenuUC(username);
            mainMenuUC.ChatbotClick += ChatbotUC;
            mainMenuUC.ChatClick += ChatUC;
            mainMenuUC.ForumClick += ForumUC;

            MainPanel.Controls.Clear();
            mainMenuUC.Dock = DockStyle.Fill;
            MainPanel.Controls.Add(mainMenuUC);
        }

        protected void ChatbotUC(object? sender, string username) {
            chatbotUC = new ChatbotUC(username, client);
            chatbotUC.BackBtnClick += MainMenuUC;

            MainPanel.Controls.Clear();
            chatbotUC.Dock = DockStyle.Fill;
            MainPanel.Controls.Add(chatbotUC);
        }

        protected void ChatUC(object? sender, string username) {
            chatUC = new ChatUC(username, client);
            chatUC.BackBtnClick += MainMenuUC;

            MainPanel.Controls.Clear();
            chatUC.Dock = DockStyle.Fill;
            MainPanel.Controls.Add(chatUC);
        }

        protected void ForumUC(object? sender, string username) {
            forumUC = new ForumsUC(username);
            forumUC.UploadClick += ForumsFormUC;
            forumUC.BackBtnClick += MainMenuUC;

            MainPanel.Controls.Clear();
            forumUC.Dock = DockStyle.Fill;
            MainPanel.Controls.Add(forumUC);
        }

        protected void ForumsFormUC(object? sender, string username) {
            forumsFormUC = new ForumsFormUC(username, client);
            forumsFormUC.BackBtnClick += ForumUC;

            MainPanel.Controls.Clear();
            forumsFormUC.Dock = DockStyle.Fill;
            MainPanel.Controls.Add(forumsFormUC);
        }

        protected void FormUC() {
            formUC = new FormUC();

            MainPanel.Controls.Clear();
            formUC.Dock = DockStyle.Fill;
            MainPanel.Controls.Add(formUC);
        }
    }
}
