using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpeakingChatbot.UserControls.SubUC {
    public partial class FormItemUC : UserControl {

        int postId;
        string userName;
        string postTitle;
        string postCategory;
        int votes;
        string postCreated;
        public FormItemUC(int PostId, string UserName, string PostTitle, string PostCategory, int Votes, string PostCreated) {
            InitializeComponent();

            postId = PostId;
            userName = UserName;
            postTitle = PostTitle;
            postCategory = PostCategory;
            votes = Votes;
            postCreated = PostCreated;
        }

        private void FormItemUC_Load(object sender, EventArgs e) {
            usernameLbl.Text = userName;
            // sdgLbl.Text = 
            categoryLbl.Text = postCategory;
            titleLbl.Text = postTitle;
            dateLbl.Text = postCreated;
            votesLbl.Text = votes.ToString();
        }
    }
}
