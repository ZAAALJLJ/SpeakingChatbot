namespace SpeakingChatbot.UserControls {
    partial class SignUpUC {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            signUpTbl = new TableLayoutPanel();
            titleTbl = new TableLayoutPanel();
            signUpLbl = new PictureBox();
            enterTbl = new TableLayoutPanel();
            enterBtn = new PictureBox();
            midTbl = new TableLayoutPanel();
            usernameTbl = new TableLayoutPanel();
            usernameLbl = new PictureBox();
            passwordTbl = new TableLayoutPanel();
            passwordLbl = new PictureBox();
            cPasswordLbl = new PictureBox();
            usernameTextBox = new RichTextBox();
            passwordTextBox = new RichTextBox();
            cPasswordTextBox = new RichTextBox();
            errorMsg = new Label();
            signUpTbl.SuspendLayout();
            titleTbl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)signUpLbl).BeginInit();
            enterTbl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)enterBtn).BeginInit();
            midTbl.SuspendLayout();
            usernameTbl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)usernameLbl).BeginInit();
            passwordTbl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)passwordLbl).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cPasswordLbl).BeginInit();
            SuspendLayout();
            // 
            // signUpTbl
            // 
            signUpTbl.AutoSize = true;
            signUpTbl.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            signUpTbl.BackColor = Color.Transparent;
            signUpTbl.ColumnCount = 1;
            signUpTbl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            signUpTbl.Controls.Add(titleTbl, 0, 0);
            signUpTbl.Controls.Add(enterTbl, 0, 2);
            signUpTbl.Controls.Add(midTbl, 0, 1);
            signUpTbl.Dock = DockStyle.Fill;
            signUpTbl.Location = new Point(0, 0);
            signUpTbl.Name = "signUpTbl";
            signUpTbl.RowCount = 3;
            signUpTbl.RowStyles.Add(new RowStyle(SizeType.Percent, 26F));
            signUpTbl.RowStyles.Add(new RowStyle(SizeType.Percent, 41F));
            signUpTbl.RowStyles.Add(new RowStyle(SizeType.Percent, 33F));
            signUpTbl.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            signUpTbl.Size = new Size(1280, 720);
            signUpTbl.TabIndex = 0;
            // 
            // titleTbl
            // 
            titleTbl.ColumnCount = 3;
            titleTbl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 6F));
            titleTbl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 44F));
            titleTbl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            titleTbl.Controls.Add(signUpLbl, 1, 1);
            titleTbl.Dock = DockStyle.Fill;
            titleTbl.Location = new Point(3, 3);
            titleTbl.Name = "titleTbl";
            titleTbl.RowCount = 2;
            titleTbl.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            titleTbl.RowStyles.Add(new RowStyle(SizeType.Percent, 70F));
            titleTbl.Size = new Size(1274, 181);
            titleTbl.TabIndex = 0;
            // 
            // signUpLbl
            // 
            signUpLbl.Dock = DockStyle.Fill;
            signUpLbl.Image = Properties.Resources.signupbutton;
            signUpLbl.Location = new Point(76, 54);
            signUpLbl.Margin = new Padding(0);
            signUpLbl.Name = "signUpLbl";
            signUpLbl.Size = new Size(560, 127);
            signUpLbl.SizeMode = PictureBoxSizeMode.StretchImage;
            signUpLbl.TabIndex = 0;
            signUpLbl.TabStop = false;
            // 
            // enterTbl
            // 
            enterTbl.ColumnCount = 3;
            enterTbl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 39F));
            enterTbl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 22F));
            enterTbl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 39F));
            enterTbl.Controls.Add(enterBtn, 1, 1);
            enterTbl.Dock = DockStyle.Fill;
            enterTbl.Location = new Point(3, 485);
            enterTbl.Name = "enterTbl";
            enterTbl.RowCount = 3;
            enterTbl.RowStyles.Add(new RowStyle(SizeType.Percent, 37F));
            enterTbl.RowStyles.Add(new RowStyle(SizeType.Percent, 26F));
            enterTbl.RowStyles.Add(new RowStyle(SizeType.Percent, 37F));
            enterTbl.Size = new Size(1274, 232);
            enterTbl.TabIndex = 2;
            // 
            // enterBtn
            // 
            enterBtn.Dock = DockStyle.Fill;
            enterBtn.Image = Properties.Resources.enter;
            enterBtn.Location = new Point(496, 85);
            enterBtn.Margin = new Padding(0);
            enterBtn.Name = "enterBtn";
            enterBtn.Size = new Size(280, 60);
            enterBtn.SizeMode = PictureBoxSizeMode.StretchImage;
            enterBtn.TabIndex = 0;
            enterBtn.TabStop = false;
            enterBtn.Click += enterBtn_Click;
            // 
            // midTbl
            // 
            midTbl.ColumnCount = 5;
            midTbl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14F));
            midTbl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 37F));
            midTbl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 1F));
            midTbl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 34F));
            midTbl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14F));
            midTbl.Controls.Add(usernameTbl, 1, 2);
            midTbl.Controls.Add(passwordTbl, 1, 4);
            midTbl.Controls.Add(cPasswordLbl, 1, 6);
            midTbl.Controls.Add(usernameTextBox, 3, 2);
            midTbl.Controls.Add(passwordTextBox, 3, 4);
            midTbl.Controls.Add(cPasswordTextBox, 3, 6);
            midTbl.Controls.Add(errorMsg, 3, 0);
            midTbl.Dock = DockStyle.Fill;
            midTbl.Location = new Point(3, 190);
            midTbl.Name = "midTbl";
            midTbl.RowCount = 7;
            midTbl.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            midTbl.RowStyles.Add(new RowStyle(SizeType.Percent, 7F));
            midTbl.RowStyles.Add(new RowStyle(SizeType.Percent, 17F));
            midTbl.RowStyles.Add(new RowStyle(SizeType.Percent, 16F));
            midTbl.RowStyles.Add(new RowStyle(SizeType.Percent, 17F));
            midTbl.RowStyles.Add(new RowStyle(SizeType.Percent, 16F));
            midTbl.RowStyles.Add(new RowStyle(SizeType.Percent, 17F));
            midTbl.Size = new Size(1274, 289);
            midTbl.TabIndex = 3;
            // 
            // usernameTbl
            // 
            usernameTbl.ColumnCount = 2;
            usernameTbl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            usernameTbl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 75F));
            usernameTbl.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            usernameTbl.Controls.Add(usernameLbl, 1, 0);
            usernameTbl.Dock = DockStyle.Fill;
            usernameTbl.Location = new Point(178, 48);
            usernameTbl.Margin = new Padding(0);
            usernameTbl.Name = "usernameTbl";
            usernameTbl.RowCount = 1;
            usernameTbl.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            usernameTbl.Size = new Size(471, 49);
            usernameTbl.TabIndex = 0;
            // 
            // usernameLbl
            // 
            usernameLbl.Dock = DockStyle.Fill;
            usernameLbl.Image = Properties.Resources.username_label;
            usernameLbl.Location = new Point(120, 3);
            usernameLbl.Name = "usernameLbl";
            usernameLbl.Size = new Size(348, 43);
            usernameLbl.SizeMode = PictureBoxSizeMode.StretchImage;
            usernameLbl.TabIndex = 0;
            usernameLbl.TabStop = false;
            // 
            // passwordTbl
            // 
            passwordTbl.ColumnCount = 2;
            passwordTbl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            passwordTbl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 75F));
            passwordTbl.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            passwordTbl.Controls.Add(passwordLbl, 1, 0);
            passwordTbl.Dock = DockStyle.Fill;
            passwordTbl.Location = new Point(178, 143);
            passwordTbl.Margin = new Padding(0);
            passwordTbl.Name = "passwordTbl";
            passwordTbl.RowCount = 1;
            passwordTbl.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            passwordTbl.Size = new Size(471, 49);
            passwordTbl.TabIndex = 1;
            // 
            // passwordLbl
            // 
            passwordLbl.Dock = DockStyle.Fill;
            passwordLbl.Image = Properties.Resources.password_label;
            passwordLbl.Location = new Point(117, 0);
            passwordLbl.Margin = new Padding(0);
            passwordLbl.Name = "passwordLbl";
            passwordLbl.Size = new Size(354, 49);
            passwordLbl.SizeMode = PictureBoxSizeMode.StretchImage;
            passwordLbl.TabIndex = 0;
            passwordLbl.TabStop = false;
            // 
            // cPasswordLbl
            // 
            cPasswordLbl.Dock = DockStyle.Fill;
            cPasswordLbl.Image = Properties.Resources.confirm_password_label;
            cPasswordLbl.Location = new Point(178, 238);
            cPasswordLbl.Margin = new Padding(0);
            cPasswordLbl.Name = "cPasswordLbl";
            cPasswordLbl.Size = new Size(471, 51);
            cPasswordLbl.SizeMode = PictureBoxSizeMode.StretchImage;
            cPasswordLbl.TabIndex = 2;
            cPasswordLbl.TabStop = false;
            // 
            // usernameTextBox
            // 
            usernameTextBox.Dock = DockStyle.Fill;
            usernameTextBox.Location = new Point(664, 51);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new Size(427, 43);
            usernameTextBox.TabIndex = 3;
            usernameTextBox.Text = "";
            // 
            // passwordTextBox
            // 
            passwordTextBox.Dock = DockStyle.Fill;
            passwordTextBox.Location = new Point(664, 146);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(427, 43);
            passwordTextBox.TabIndex = 4;
            passwordTextBox.Text = "";
            // 
            // cPasswordTextBox
            // 
            cPasswordTextBox.Dock = DockStyle.Fill;
            cPasswordTextBox.Location = new Point(664, 241);
            cPasswordTextBox.Name = "cPasswordTextBox";
            cPasswordTextBox.Size = new Size(427, 45);
            cPasswordTextBox.TabIndex = 5;
            cPasswordTextBox.Text = "";
            // 
            // errorMsg
            // 
            errorMsg.AutoSize = true;
            errorMsg.BackColor = Color.Red;
            errorMsg.Dock = DockStyle.Fill;
            errorMsg.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            errorMsg.ForeColor = Color.White;
            errorMsg.Location = new Point(664, 0);
            errorMsg.Name = "errorMsg";
            errorMsg.Size = new Size(427, 28);
            errorMsg.TabIndex = 6;
            errorMsg.Text = "ERROR MESSAGE HERE";
            errorMsg.TextAlign = ContentAlignment.MiddleRight;
            errorMsg.Visible = false;
            // 
            // SignUpUC
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Log_in_and_signup;
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(signUpTbl);
            DoubleBuffered = true;
            Name = "SignUpUC";
            Size = new Size(1280, 720);
            Resize += SignUpUC_Resize;
            signUpTbl.ResumeLayout(false);
            titleTbl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)signUpLbl).EndInit();
            enterTbl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)enterBtn).EndInit();
            midTbl.ResumeLayout(false);
            midTbl.PerformLayout();
            usernameTbl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)usernameLbl).EndInit();
            passwordTbl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)passwordLbl).EndInit();
            ((System.ComponentModel.ISupportInitialize)cPasswordLbl).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel signUpTbl;
        private TableLayoutPanel titleTbl;
        private TableLayoutPanel enterTbl;
        private TableLayoutPanel midTbl;
        private TableLayoutPanel usernameTbl;
        private PictureBox usernameLbl;
        private TableLayoutPanel passwordTbl;
        private PictureBox passwordLbl;
        private PictureBox cPasswordLbl;
        private RichTextBox usernameTextBox;
        private RichTextBox passwordTextBox;
        private PictureBox enterBtn;
        private RichTextBox cPasswordTextBox;
        private PictureBox signUpLbl;
        private Label errorMsg;
    }
}
