using Org.BouncyCastle.Asn1.Tsp;
using Org.BouncyCastle.Utilities;
using SpeakingChatbot.db;
using SpeakingChatbot.UserControls.SubUC;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace SpeakingChatbot.UserControls {
    public partial class ForumsUC : UserControl {
        string username;
        Crud crud;
        FormItemUC formItem;
        SDGUC sdg;
        CategoryUC category;
        Panel panel;


        public event EventHandler<string> BackBtnClick;
        public event EventHandler<string> UploadClick;
        public event EventHandler<int> ViewFormClick;

        List<int> sdgs = new List<int>();
        string cat;

        private void Control_Clicks(object sender, EventArgs e) {
            Control control = (Control)sender;   // Sender gives you which control is clicked.
            MessageBox.Show(control.Name.ToString());
        }

        public ForumsUC(string userName) {
            InitializeComponent();

            crud = new Crud();
            sdg = new SDGUC();
            category = new CategoryUC();

            username = userName;
            crud.createFormItemEvent += displayPost;
            crud.getPosts();

            sdgCatPanel.Controls.Clear();
            sdg.Dock = DockStyle.Fill;
            sdgCatPanel.Controls.Add(sdg);

            sdg.checkedBtn += addSdg;
            category.checkedRadioBtn += addCat;
        }


        private void addCat(object sender, string Cat) {
            cat = Cat;
        }

        private void addSdg(object sender, int sdg) {
            if (sdgs.Contains(sdg)) {
                sdgs.Remove(sdg);
            } else {
                sdgs.Add(sdg);
            }
        }

        private void formClicked(object sender, int postId) {
            // Debug.WriteLine(postId);
            // Debug.WriteLine("magiccc");
            ViewFormClick?.Invoke(this, postId);
        }


        private void backBtn_Click(object sender, EventArgs e) {
            BackBtnClick?.Invoke(this, username);
        }
        private void uploadBtn_Click(object sender, EventArgs e) {
            UploadClick?.Invoke(this, username);
        }

        private void displayPost(object? sender, string[] postInfo) {
            // Debug.WriteLine("xxxxxxxxxx");

            formItem = new FormItemUC(postInfo) {
                Name = "post" + postInfo[0],
                Dock = DockStyle.Top,
            };
            formPanel.Controls.Add(formItem);
            formItem.formClicked += formClicked;
        }

        private void sdgBtn_Click(object sender, EventArgs e) {
            sdgCatPanel.Controls.Clear();
            sdg.Dock = DockStyle.Fill;
            sdgCatPanel.Controls.Add(sdg);
        }

        private void categoryBtn_Click(object sender, EventArgs e) {
            sdgCatPanel.Controls.Clear();
            category.Dock = DockStyle.Fill;
            sdgCatPanel.Controls.Add(category);
        }

        private void applyBtn_Click(object sender, EventArgs e) {
            foreach (int n in sdgs) {
                Debug.WriteLine(n);
            }

            // cat and sdgs yug add sa query

        }
    }
}
