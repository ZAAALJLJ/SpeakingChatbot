namespace SpeakingChatbot.UserControls {
    partial class LoginSignUpUC {
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
        protected override CreateParams CreateParams {
            get {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;
                return cp;
            }
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            loginTbl = new TableLayoutPanel();
            midTbl = new TableLayoutPanel();
            loginBtn = new PictureBox();
            signUpBtn = new PictureBox();
            white = new Label();
            titleTbl = new TableLayoutPanel();
            titleLbl = new PictureBox();
            continueTbl = new TableLayoutPanel();
            loginTbl.SuspendLayout();
            midTbl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)loginBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)signUpBtn).BeginInit();
            titleTbl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)titleLbl).BeginInit();
            SuspendLayout();
            // 
            // loginTbl
            // 
            loginTbl.ColumnCount = 1;
            loginTbl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            loginTbl.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            loginTbl.Controls.Add(midTbl, 0, 1);
            loginTbl.Controls.Add(titleTbl, 0, 0);
            loginTbl.Controls.Add(continueTbl, 0, 2);
            loginTbl.Dock = DockStyle.Fill;
            loginTbl.Location = new Point(0, 0);
            loginTbl.Name = "loginTbl";
            loginTbl.RowCount = 3;
            loginTbl.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            loginTbl.RowStyles.Add(new RowStyle(SizeType.Percent, 45F));
            loginTbl.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            loginTbl.Size = new Size(720, 480);
            loginTbl.TabIndex = 0;
            // 
            // midTbl
            // 
            midTbl.ColumnCount = 7;
            midTbl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 19.5F));
            midTbl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            midTbl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5F));
            midTbl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 1F));
            midTbl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5F));
            midTbl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            midTbl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 19.5F));
            midTbl.Controls.Add(loginBtn, 1, 1);
            midTbl.Controls.Add(signUpBtn, 5, 1);
            midTbl.Controls.Add(white, 3, 1);
            midTbl.Dock = DockStyle.Fill;
            midTbl.Location = new Point(3, 123);
            midTbl.Name = "midTbl";
            midTbl.RowCount = 3;
            midTbl.RowStyles.Add(new RowStyle(SizeType.Percent, 35.3137245F));
            midTbl.RowStyles.Add(new RowStyle(SizeType.Percent, 29.372551F));
            midTbl.RowStyles.Add(new RowStyle(SizeType.Percent, 35.3137245F));
            midTbl.Size = new Size(714, 210);
            midTbl.TabIndex = 2;
            midTbl.Click += titleLbl_Click;
            // 
            // loginBtn
            // 
            loginBtn.Cursor = Cursors.Hand;
            loginBtn.Dock = DockStyle.Fill;
            loginBtn.Image = Properties.Resources.loginbutton;
            loginBtn.Location = new Point(139, 74);
            loginBtn.Margin = new Padding(0);
            loginBtn.Name = "loginBtn";
            loginBtn.Size = new Size(178, 61);
            loginBtn.SizeMode = PictureBoxSizeMode.StretchImage;
            loginBtn.TabIndex = 0;
            loginBtn.TabStop = false;
            loginBtn.Click += loginBtn_Click;
            // 
            // signUpBtn
            // 
            signUpBtn.Cursor = Cursors.Hand;
            signUpBtn.Dock = DockStyle.Fill;
            signUpBtn.Image = Properties.Resources.signupbutton;
            signUpBtn.Location = new Point(394, 74);
            signUpBtn.Margin = new Padding(0);
            signUpBtn.Name = "signUpBtn";
            signUpBtn.Size = new Size(178, 61);
            signUpBtn.SizeMode = PictureBoxSizeMode.StretchImage;
            signUpBtn.TabIndex = 1;
            signUpBtn.TabStop = false;
            signUpBtn.Click += signUpBtn_Click;
            // 
            // white
            // 
            white.AutoSize = true;
            white.BackColor = Color.White;
            white.Dock = DockStyle.Fill;
            white.Location = new Point(352, 74);
            white.Margin = new Padding(0);
            white.Name = "white";
            white.Size = new Size(7, 61);
            white.TabIndex = 2;
            // 
            // titleTbl
            // 
            titleTbl.ColumnCount = 3;
            titleTbl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 18F));
            titleTbl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 64F));
            titleTbl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 18F));
            titleTbl.Controls.Add(titleLbl, 1, 1);
            titleTbl.Dock = DockStyle.Fill;
            titleTbl.Location = new Point(0, 0);
            titleTbl.Margin = new Padding(0);
            titleTbl.Name = "titleTbl";
            titleTbl.RowCount = 3;
            titleTbl.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            titleTbl.RowStyles.Add(new RowStyle(SizeType.Percent, 70F));
            titleTbl.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            titleTbl.Size = new Size(720, 120);
            titleTbl.TabIndex = 3;
            titleTbl.Click += titleLbl_Click;
            // 
            // titleLbl
            // 
            titleLbl.Dock = DockStyle.Fill;
            titleLbl.Image = Properties.Resources.CHAVATARtitle;
            titleLbl.Location = new Point(129, 18);
            titleLbl.Margin = new Padding(0);
            titleLbl.Name = "titleLbl";
            titleLbl.Size = new Size(460, 84);
            titleLbl.SizeMode = PictureBoxSizeMode.StretchImage;
            titleLbl.TabIndex = 0;
            titleLbl.TabStop = false;
            titleLbl.Click += titleLbl_Click;
            // 
            // continueTbl
            // 
            continueTbl.ColumnCount = 3;
            continueTbl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16F));
            continueTbl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 68F));
            continueTbl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16F));
            continueTbl.Dock = DockStyle.Fill;
            continueTbl.Location = new Point(0, 336);
            continueTbl.Margin = new Padding(0);
            continueTbl.Name = "continueTbl";
            continueTbl.RowCount = 3;
            continueTbl.RowStyles.Add(new RowStyle(SizeType.Percent, 35F));
            continueTbl.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            continueTbl.RowStyles.Add(new RowStyle(SizeType.Percent, 35F));
            continueTbl.Size = new Size(720, 144);
            continueTbl.TabIndex = 4;
            continueTbl.Click += titleLbl_Click;
            // 
            // LoginSignUpUC
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.Transparent;
            BackgroundImage = Properties.Resources.start2;
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(loginTbl);
            DoubleBuffered = true;
            Name = "LoginSignUpUC";
            Size = new Size(720, 480);
            loginTbl.ResumeLayout(false);
            midTbl.ResumeLayout(false);
            midTbl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)loginBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)signUpBtn).EndInit();
            titleTbl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)titleLbl).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel loginTbl;
        private TableLayoutPanel midTbl;
        private TableLayoutPanel titleTbl;
        private PictureBox titleLbl;
        private TableLayoutPanel continueTbl;
        private PictureBox loginBtn;
        private PictureBox signUpBtn;
        private PictureBox continueLbl;
        private Label white;
    }
}
