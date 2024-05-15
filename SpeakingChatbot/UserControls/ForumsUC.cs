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
    public partial class ForumsUC : UserControl {
        string username;
        Crud crud;

        public event EventHandler<string> BackBtnClick;
        public event EventHandler<string> UploadClick;

        public ForumsUC(string userName) {
            username = userName;
            InitializeComponent();
            this.username = username;
        }

        private void uploadBtn_Click(object sender, EventArgs e) {
            UploadClick?.Invoke(this, username);
        }

        private void backBtn_Click(object sender, EventArgs e) {
            BackBtnClick?.Invoke(this, username);
        }

        private void forumsTbl_Paint(object sender, PaintEventArgs e) {
            crud.getPosts();

            // forumsPanel.Controls.Add(formComments);
        }



        // open the file
        // Process.Start("explorer.exe", filePath);
    }
}
