using SpeakingChatbot.db;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace SpeakingChatbot.UserControls.SubUC {
    public partial class FormItemUC : UserControl {


        public event EventHandler<int> formClicked;


        Crud crud = new Crud();
        string postId;
        string userName;
        string postTitle;
        string postCategory;
        string votes;
        string postCreated;
        string sdg;

        public FormItemUC(string[] postInfo) {
            InitializeComponent();

            postId = postInfo[0];
            string userId = postInfo[1];
            postTitle = postInfo[2];
            postCategory = postInfo[3];
            votes = postInfo[4];
            postCreated = postInfo[5];

            userName = crud.getUserById(Convert.ToInt32(userId));
        }

        private void FormItemUC_Load(object sender, EventArgs e) {
            Name = postId.ToString();
            usernameLbl.Text = userName;
            titleLbl.Text = postTitle;

            string[] date = postCreated.Split(' ');
            dateLbl.Text = date[0];

            votesLbl.Text = votes.ToString();

            switch (postCategory) {
                case "guide":
                    categoryPic.Image = Properties.Resources.guidetag;
                    break;
                case "event":
                    categoryPic.Image = Properties.Resources.eventtag;
                    break;
                case "question":
                    categoryPic.Image = Properties.Resources.questiontag;
                    break;
                case "news":
                    categoryPic.Image = Properties.Resources.newstag;
                    break;
                case "research paper":
                    categoryPic.Image = Properties.Resources.researcharticletag;
                    break;
                case "others":
                    categoryPic.Image = Properties.Resources.researcharticletag;
                    break;
                default:
                    break;
            }
            AdjustFontSize();
        }

        private void AdjustFontSize() {
            float newSize = this.Width * 0.035f;
            if (newSize < 1) {
                newSize = 1;
            }

            float newSize1 = this.Width * 0.02f;
            if (newSize1 < 1) {
                newSize1 = 1;
            }
            usernameLbl.Font = new Font(usernameLbl.Font.FontFamily, newSize);
            dateLbl.Font = new Font(dateLbl.Font.FontFamily, newSize1);
            titleLbl.Font = new Font(titleLbl.Font.FontFamily, newSize);
            votesLbl.Font = new Font(votesLbl.Font.FontFamily, newSize);
        }

        private void votesLbl_Resize(object sender, EventArgs e) {
            AdjustFontSize();
        }

        private void titleLbl_Click(object sender, EventArgs e) {
        }

        private void contentPanel_Click(object sender, EventArgs e) {
            formClicked?.Invoke(this, Convert.ToInt32(postId));
            Debug.WriteLine("asdasd" + postId);
        }

        private void titleLbl_Resize(object sender, EventArgs e) {
            int maxWidth = (int)(this.Width * 5);
            titleLbl.MaximumSize = new Size(maxWidth, 0);
        }
    }
}
