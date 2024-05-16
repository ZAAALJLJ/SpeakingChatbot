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
    public partial class SDGUC : UserControl {

        public event EventHandler<int> checkedBtn;
        public SDGUC() {
            InitializeComponent();
        }

        private void sdg1CB_CheckedChanged(object sender, EventArgs e) {
            checkedBtn?.Invoke(this, 1);
        }

        private void sdg2CB_CheckedChanged(object sender, EventArgs e) {
            checkedBtn?.Invoke(this, 2);
        }

        private void sdg3CB_CheckedChanged(object sender, EventArgs e) {
            checkedBtn?.Invoke(this, 3);
        }

        private void sdg4CB_CheckedChanged(object sender, EventArgs e) {
            checkedBtn?.Invoke(this, 4);
        }

        private void sdg5CB_CheckedChanged(object sender, EventArgs e) {
            checkedBtn?.Invoke(this, 5);
        }

        private void sdg6CB_CheckedChanged(object sender, EventArgs e) {
            checkedBtn?.Invoke(this, 6);
        }

        private void sdg7CB_CheckedChanged(object sender, EventArgs e) {
            checkedBtn?.Invoke(this, 7);
        }

        private void sdg8CB_CheckedChanged(object sender, EventArgs e) {
            checkedBtn?.Invoke(this, 8);
        }

        private void sdg9CB_CheckedChanged(object sender, EventArgs e) {
            checkedBtn?.Invoke(this, 9);
        }

        private void sdg10CB_CheckedChanged(object sender, EventArgs e) {
            checkedBtn?.Invoke(this, 10);
        }
    }
}
