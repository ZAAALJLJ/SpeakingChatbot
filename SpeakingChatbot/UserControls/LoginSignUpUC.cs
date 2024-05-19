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
    public partial class LoginSignUpUC : UserControl {

        public event Action WelcomeClick;
        public event Action LoginClick;
        public event Action SignUpClick;

        public LoginSignUpUC() {
            InitializeComponent();
        }

        private void loginBtn_Click(object sender, EventArgs e) {
            LoginClick?.Invoke();
        }

        private void signUpBtn_Click(object sender, EventArgs e) {
            SignUpClick?.Invoke();
        }

        private void titleLbl_Click(object sender, EventArgs e) {
            WelcomeClick?.Invoke();
        }
    }
}
