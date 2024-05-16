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
    public partial class CategoryUC : UserControl {

        public event EventHandler<string> checkedRadioBtn;
        public CategoryUC() {
            InitializeComponent();
        }

        private void cat1Btn_CheckedChanged(object sender, EventArgs e) {
            checkedRadioBtn?.Invoke(this, "guide");
        }

        private void cat2Btn_CheckedChanged(object sender, EventArgs e) {
            checkedRadioBtn?.Invoke(this, "event");
        }

        private void cat3Btn_CheckedChanged(object sender, EventArgs e) {
            checkedRadioBtn?.Invoke(this, "question");
        }

        private void cat4Btn_CheckedChanged(object sender, EventArgs e) {
            checkedRadioBtn?.Invoke(this, "news");
        }

        private void cat5Btn_CheckedChanged(object sender, EventArgs e) {
            checkedRadioBtn?.Invoke(this, "research paper");
        }

        private void cat6Btn_CheckedChanged(object sender, EventArgs e) {
            checkedRadioBtn?.Invoke(this, "others");
        }
    }
}
