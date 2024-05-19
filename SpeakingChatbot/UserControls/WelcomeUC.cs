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

namespace SpeakingChatbot.UserControls {
    public partial class WelcomeUC : UserControl {

        public event Action WelcomeClick;
        public WelcomeUC() {
            InitializeComponent();
        }

        private void continueTbl_Click(object sender, EventArgs e) {
            WelcomeClick?.Invoke();
        }
    }


}
