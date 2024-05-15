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
    public partial class UsersUC : UserControl {
        public UsersUC() {
            InitializeComponent();
        }

        public UsersUC(string username, bool isOnline) {
            InitializeComponent();
            user.Text = username;
            if (isOnline) {
                status.Text = "online";
            } else {
                status.Text = "offline";
            }
        }

        private void usersTbl_Paint(object sender, PaintEventArgs e) {
            ControlPaint.DrawBorder(e.Graphics, ClientRectangle, Color.Black, ButtonBorderStyle.Solid);
        }


    }
}
