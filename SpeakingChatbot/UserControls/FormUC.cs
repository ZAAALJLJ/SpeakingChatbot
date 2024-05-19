using SpeakingChatbot.UserControls.SubUC;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Speech.Recognition;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Diagnostics;
using SpeakingChatbot.db;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace SpeakingChatbot.UserControls {
    public partial class FormUC : UserControl {

        public event EventHandler<string> BackBtnClick;

        Crud crud = new Crud();

        string[] postInfo = new string[8];
        string filePath;


        int i = 1;
        public FormUC(string username, int postId) {
            InitializeComponent();

            Debug.WriteLine(username);
            Debug.WriteLine(postId);
            postInfo = crud.getPostById(postId);

            titleLbl.Text = postInfo[2];
            content.Text = postInfo[4];
            filePath = postInfo[5];
            if (filePath == null) {
                submitBtn.Visible = false;
            }
        }



        private void submitBtn_Click(object sender, EventArgs e) {
            Process.Start("explorer.exe", filePath);
        }


        private void AdjustFontSize() {
            float newSize = this.Width * 0.05f;
            if (newSize < 1) {
                newSize = 1;
            }
            float newSize1 = this.Width * 0.02f;
            if (newSize1 < 1) {
                newSize1 = 1;
            }
            titleLbl.Font = new Font(titleLbl.Font.FontFamily, newSize);
            content.Font = new Font(content.Font.FontFamily, newSize1);
        }
        private void FormUC_Load(object sender, EventArgs e) {
            AdjustFontSize();
        }

        private void backBtn_Click(object sender, EventArgs e) {
            BackBtnClick?.Invoke(this, string.Empty);
        }

        private void FormUC_Resize(object sender, EventArgs e) {
            int titleWidth = (int)(this.Width * 0.75);
            Debug.WriteLine($"{this.Width} {titleWidth}");
            titleLbl.MaximumSize = new Size(titleWidth, 0);
        }

    }
}
