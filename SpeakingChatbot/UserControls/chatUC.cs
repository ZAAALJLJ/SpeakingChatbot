﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpeakingChatbot.UserControls {
    public partial class ChatUC : UserControl {
        public event Action BackBtnClick;
        public ChatUC() {
            InitializeComponent();
            // avatarPanel.BackColor = Color.FromArgb(200, Color.Black);
            // chatPanel.BackColor = Color.FromArgb(200, Color.Black);
        }

        private void backBtn_Click(object sender, EventArgs e) {
            BackBtnClick?.Invoke();
        }
    }
}