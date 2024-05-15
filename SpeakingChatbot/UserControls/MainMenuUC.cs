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
    public partial class MainMenuUC : UserControl {
        string username;

        public event EventHandler<string> ChatbotClick;
        public event EventHandler<string> ChatClick;
        public event EventHandler<string> ForumClick;
        public MainMenuUC(string userName) {
            username = userName;
            InitializeComponent();
        }

        private void chatbotIcon_Click(object sender, EventArgs e) {
            ChatbotClick?.Invoke(this, username);
        }

        private void chatbotBtn_Click(object sender, EventArgs e) {
            ChatbotClick?.Invoke(this, username);
        }

        private void chatIcon_Click(object sender, EventArgs e) {
            ChatClick?.Invoke(this, username);
        }

        private void chatBtn_Click(object sender, EventArgs e) {
            ChatClick?.Invoke(this, username);
        }

        private void forumIcon_Click(object sender, EventArgs e) {
            ForumClick?.Invoke(this, username);
        }

        private void forumBtn_Click(object sender, EventArgs e) {
            ForumClick?.Invoke(this, username);
        }
    }
}
