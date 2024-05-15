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
    public partial class FormCommentsUC : UserControl {

        int cnt;
        public FormCommentsUC(int i) {
            InitializeComponent();
            cnt = i;
        }

        private void FormCommentsUC_Paint(object sender, PaintEventArgs e) {
            username.Text = cnt.ToString();
        }

    }
}
