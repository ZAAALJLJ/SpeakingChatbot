namespace SpeakingChatbot.UserControls {
    partial class LoginUC {
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
            loginTbl = new TableLayoutPanel();
            titleTbl = new TableLayoutPanel();
            loginLbl = new PictureBox();
            midTbl = new TableLayoutPanel();
            usernameLbl = new PictureBox();
            passwordLbl = new PictureBox();
            usernameTextBox = new RichTextBox();
            passwordTextBox = new RichTextBox();
            errorMsg = new Label();
            btmTbl = new TableLayoutPanel();
            enterBtn = new PictureBox();
            loginTbl.SuspendLayout();
            titleTbl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)loginLbl).BeginInit();
            midTbl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)usernameLbl).BeginInit();
            ((System.ComponentModel.ISupportInitialize)passwordLbl).BeginInit();
            btmTbl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)enterBtn).BeginInit();
            SuspendLayout();
            // 
            // loginTbl
            // 
            loginTbl.BackColor = Color.Transparent;
            loginTbl.ColumnCount = 1;
            loginTbl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            loginTbl.Controls.Add(titleTbl, 0, 0);
            loginTbl.Controls.Add(midTbl, 0, 1);
            loginTbl.Controls.Add(btmTbl, 0, 2);
            loginTbl.Dock = DockStyle.Fill;
            loginTbl.Location = new Point(0, 0);
            loginTbl.Name = "loginTbl";
            loginTbl.RowCount = 3;
            loginTbl.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            loginTbl.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            loginTbl.RowStyles.Add(new RowStyle(SizeType.Percent, 35F));
            loginTbl.Size = new Size(1280, 720);
            loginTbl.TabIndex = 0;
            // 
            // titleTbl
            // 
            titleTbl.AutoSize = true;
            titleTbl.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            titleTbl.ColumnCount = 3;
            titleTbl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 6F));
            titleTbl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 44F));
            titleTbl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            titleTbl.Controls.Add(loginLbl, 1, 1);
            titleTbl.Dock = DockStyle.Fill;
            titleTbl.Location = new Point(3, 3);
            titleTbl.Name = "titleTbl";
            titleTbl.RowCount = 2;
            titleTbl.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            titleTbl.RowStyles.Add(new RowStyle(SizeType.Percent, 70F));
            titleTbl.Size = new Size(1274, 174);
            titleTbl.TabIndex = 0;
            // 
            // loginLbl
            // 
            loginLbl.Dock = DockStyle.Fill;
            loginLbl.Image = Properties.Resources.loginbutton;
            loginLbl.Location = new Point(76, 52);
            loginLbl.Margin = new Padding(0);
            loginLbl.Name = "loginLbl";
            loginLbl.Size = new Size(560, 122);
            loginLbl.SizeMode = PictureBoxSizeMode.StretchImage;
            loginLbl.TabIndex = 0;
            loginLbl.TabStop = false;
            // 
            // midTbl
            // 
            midTbl.ColumnCount = 5;
            midTbl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 21F));
            midTbl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            midTbl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 1F));
            midTbl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 34F));
            midTbl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14F));
            midTbl.Controls.Add(usernameLbl, 1, 3);
            midTbl.Controls.Add(passwordLbl, 1, 5);
            midTbl.Controls.Add(usernameTextBox, 3, 3);
            midTbl.Controls.Add(passwordTextBox, 3, 5);
            midTbl.Controls.Add(errorMsg, 3, 1);
            midTbl.Dock = DockStyle.Fill;
            midTbl.Location = new Point(3, 183);
            midTbl.Name = "midTbl";
            midTbl.RowCount = 7;
            midTbl.RowStyles.Add(new RowStyle(SizeType.Percent, 13F));
            midTbl.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            midTbl.RowStyles.Add(new RowStyle(SizeType.Percent, 7F));
            midTbl.RowStyles.Add(new RowStyle(SizeType.Percent, 17F));
            midTbl.RowStyles.Add(new RowStyle(SizeType.Percent, 14F));
            midTbl.RowStyles.Add(new RowStyle(SizeType.Percent, 17F));
            midTbl.RowStyles.Add(new RowStyle(SizeType.Percent, 22F));
            midTbl.Size = new Size(1274, 282);
            midTbl.TabIndex = 3;
            // 
            // usernameLbl
            // 
            usernameLbl.Dock = DockStyle.Fill;
            usernameLbl.Image = Properties.Resources.username_label;
            usernameLbl.Location = new Point(267, 83);
            usernameLbl.Margin = new Padding(0);
            usernameLbl.Name = "usernameLbl";
            usernameLbl.Size = new Size(382, 47);
            usernameLbl.SizeMode = PictureBoxSizeMode.StretchImage;
            usernameLbl.TabIndex = 0;
            usernameLbl.TabStop = false;
            // 
            // passwordLbl
            // 
            passwordLbl.Dock = DockStyle.Fill;
            passwordLbl.Image = Properties.Resources.password_label;
            passwordLbl.Location = new Point(267, 169);
            passwordLbl.Margin = new Padding(0);
            passwordLbl.Name = "passwordLbl";
            passwordLbl.Size = new Size(382, 47);
            passwordLbl.SizeMode = PictureBoxSizeMode.StretchImage;
            passwordLbl.TabIndex = 1;
            passwordLbl.TabStop = false;
            // 
            // usernameTextBox
            // 
            usernameTextBox.Dock = DockStyle.Fill;
            usernameTextBox.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            usernameTextBox.Location = new Point(664, 86);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new Size(427, 41);
            usernameTextBox.TabIndex = 2;
            usernameTextBox.Text = "";
            // 
            // passwordTextBox
            // 
            passwordTextBox.Dock = DockStyle.Fill;
            passwordTextBox.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            passwordTextBox.Location = new Point(664, 172);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(427, 41);
            passwordTextBox.TabIndex = 3;
            passwordTextBox.Text = "";
            // 
            // errorMsg
            // 
            errorMsg.AutoSize = true;
            errorMsg.BackColor = Color.Red;
            errorMsg.Dock = DockStyle.Fill;
            errorMsg.ForeColor = Color.White;
            errorMsg.Location = new Point(664, 36);
            errorMsg.Name = "errorMsg";
            errorMsg.Size = new Size(427, 28);
            errorMsg.TabIndex = 4;
            errorMsg.Text = "ERROR MESSAGE";
            errorMsg.TextAlign = ContentAlignment.MiddleRight;
            errorMsg.Visible = false;
            // 
            // btmTbl
            // 
            btmTbl.ColumnCount = 3;
            btmTbl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 39F));
            btmTbl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 22F));
            btmTbl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 39F));
            btmTbl.Controls.Add(enterBtn, 1, 1);
            btmTbl.Dock = DockStyle.Fill;
            btmTbl.Location = new Point(0, 468);
            btmTbl.Margin = new Padding(0);
            btmTbl.Name = "btmTbl";
            btmTbl.RowCount = 3;
            btmTbl.RowStyles.Add(new RowStyle(SizeType.Percent, 37F));
            btmTbl.RowStyles.Add(new RowStyle(SizeType.Percent, 26F));
            btmTbl.RowStyles.Add(new RowStyle(SizeType.Percent, 37F));
            btmTbl.Size = new Size(1280, 252);
            btmTbl.TabIndex = 4;
            // 
            // enterBtn
            // 
            enterBtn.Dock = DockStyle.Fill;
            enterBtn.Image = Properties.Resources.enter;
            enterBtn.Location = new Point(499, 93);
            enterBtn.Margin = new Padding(0);
            enterBtn.Name = "enterBtn";
            enterBtn.Size = new Size(281, 65);
            enterBtn.SizeMode = PictureBoxSizeMode.StretchImage;
            enterBtn.TabIndex = 0;
            enterBtn.TabStop = false;
            enterBtn.Click += enterBtn_Click;
            // 
            // LoginUC
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Log_in_and_signup;
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(loginTbl);
            DoubleBuffered = true;
            Name = "LoginUC";
            Size = new Size(1280, 720);
            Click += LoginUC_Click;
            loginTbl.ResumeLayout(false);
            loginTbl.PerformLayout();
            titleTbl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)loginLbl).EndInit();
            midTbl.ResumeLayout(false);
            midTbl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)usernameLbl).EndInit();
            ((System.ComponentModel.ISupportInitialize)passwordLbl).EndInit();
            btmTbl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)enterBtn).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel loginTbl;
        private TableLayoutPanel titleTbl;
        private TableLayoutPanel midTbl;
        private PictureBox usernameLbl;
        private PictureBox loginLbl;
        private PictureBox passwordLbl;
        private RichTextBox usernameTextBox;
        private RichTextBox passwordTextBox;
        private TableLayoutPanel btmTbl;
        private PictureBox enterBtn;
        private Label errorMsg;
    }
}
