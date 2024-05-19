namespace SpeakingChatbot.UserControls {
    partial class MainMenuUC {
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
            mainMenuTbl = new TableLayoutPanel();
            startedTbl = new TableLayoutPanel();
            getStartedLbl = new PictureBox();
            midPanel = new TableLayoutPanel();
            forumTbl = new TableLayoutPanel();
            forumIcon = new PictureBox();
            forumBtn = new PictureBox();
            chatTbl = new TableLayoutPanel();
            chatIcon = new PictureBox();
            chatBtn = new PictureBox();
            chatbotTbl = new TableLayoutPanel();
            chatbotIcon = new PictureBox();
            chatbotBtn = new PictureBox();
            mainMenuTbl.SuspendLayout();
            startedTbl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)getStartedLbl).BeginInit();
            midPanel.SuspendLayout();
            forumTbl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)forumIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)forumBtn).BeginInit();
            chatTbl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chatIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chatBtn).BeginInit();
            chatbotTbl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chatbotIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chatbotBtn).BeginInit();
            SuspendLayout();
            // 
            // mainMenuTbl
            // 
            mainMenuTbl.ColumnCount = 1;
            mainMenuTbl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            mainMenuTbl.Controls.Add(startedTbl, 0, 3);
            mainMenuTbl.Controls.Add(midPanel, 0, 1);
            mainMenuTbl.Dock = DockStyle.Fill;
            mainMenuTbl.Location = new Point(0, 0);
            mainMenuTbl.Name = "mainMenuTbl";
            mainMenuTbl.RowCount = 5;
            mainMenuTbl.RowStyles.Add(new RowStyle(SizeType.Percent, 18F));
            mainMenuTbl.RowStyles.Add(new RowStyle(SizeType.Percent, 44F));
            mainMenuTbl.RowStyles.Add(new RowStyle(SizeType.Percent, 17F));
            mainMenuTbl.RowStyles.Add(new RowStyle(SizeType.Percent, 16F));
            mainMenuTbl.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            mainMenuTbl.Size = new Size(1163, 720);
            mainMenuTbl.TabIndex = 0;
            // 
            // startedTbl
            // 
            startedTbl.ColumnCount = 3;
            startedTbl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12F));
            startedTbl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 76F));
            startedTbl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12F));
            startedTbl.Controls.Add(getStartedLbl, 1, 0);
            startedTbl.Dock = DockStyle.Fill;
            startedTbl.Location = new Point(3, 570);
            startedTbl.Name = "startedTbl";
            startedTbl.RowCount = 1;
            startedTbl.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            startedTbl.Size = new Size(1157, 109);
            startedTbl.TabIndex = 0;
            // 
            // getStartedLbl
            // 
            getStartedLbl.Dock = DockStyle.Fill;
            getStartedLbl.Image = Properties.Resources.get_started_label;
            getStartedLbl.Location = new Point(138, 0);
            getStartedLbl.Margin = new Padding(0);
            getStartedLbl.Name = "getStartedLbl";
            getStartedLbl.Size = new Size(879, 109);
            getStartedLbl.SizeMode = PictureBoxSizeMode.StretchImage;
            getStartedLbl.TabIndex = 0;
            getStartedLbl.TabStop = false;
            // 
            // midPanel
            // 
            midPanel.AutoSize = true;
            midPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            midPanel.ColumnCount = 7;
            midPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 8.823529F));
            midPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 21.5686283F));
            midPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 8.823529F));
            midPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 21.5686283F));
            midPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 8.823529F));
            midPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 21.5686283F));
            midPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 8.823529F));
            midPanel.Controls.Add(forumTbl, 5, 0);
            midPanel.Controls.Add(chatTbl, 3, 0);
            midPanel.Controls.Add(chatbotTbl, 1, 0);
            midPanel.Dock = DockStyle.Fill;
            midPanel.Location = new Point(3, 132);
            midPanel.Name = "midPanel";
            midPanel.RowCount = 1;
            midPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            midPanel.Size = new Size(1157, 310);
            midPanel.TabIndex = 1;
            // 
            // forumTbl
            // 
            forumTbl.ColumnCount = 1;
            forumTbl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            forumTbl.Controls.Add(forumIcon, 0, 0);
            forumTbl.Controls.Add(forumBtn, 0, 1);
            forumTbl.Dock = DockStyle.Fill;
            forumTbl.Location = new Point(804, 0);
            forumTbl.Margin = new Padding(0);
            forumTbl.Name = "forumTbl";
            forumTbl.RowCount = 2;
            forumTbl.RowStyles.Add(new RowStyle(SizeType.Percent, 63F));
            forumTbl.RowStyles.Add(new RowStyle(SizeType.Percent, 37F));
            forumTbl.Size = new Size(249, 310);
            forumTbl.TabIndex = 5;
            // 
            // forumIcon
            // 
            forumIcon.Cursor = Cursors.Hand;
            forumIcon.Dock = DockStyle.Fill;
            forumIcon.ErrorImage = Properties.Resources.forumicon;
            forumIcon.Image = Properties.Resources.forumicon;
            forumIcon.InitialImage = Properties.Resources.forumicon;
            forumIcon.Location = new Point(0, 0);
            forumIcon.Margin = new Padding(0);
            forumIcon.Name = "forumIcon";
            forumIcon.Size = new Size(249, 195);
            forumIcon.SizeMode = PictureBoxSizeMode.StretchImage;
            forumIcon.TabIndex = 0;
            forumIcon.TabStop = false;
            forumIcon.Click += forumIcon_Click;
            // 
            // forumBtn
            // 
            forumBtn.Cursor = Cursors.Hand;
            forumBtn.Dock = DockStyle.Fill;
            forumBtn.ErrorImage = Properties.Resources.forumsbutton;
            forumBtn.Image = Properties.Resources.forumsbutton;
            forumBtn.InitialImage = Properties.Resources.forumsbutton;
            forumBtn.Location = new Point(0, 195);
            forumBtn.Margin = new Padding(0);
            forumBtn.Name = "forumBtn";
            forumBtn.Size = new Size(249, 115);
            forumBtn.SizeMode = PictureBoxSizeMode.StretchImage;
            forumBtn.TabIndex = 1;
            forumBtn.TabStop = false;
            forumBtn.Click += forumBtn_Click;
            // 
            // chatTbl
            // 
            chatTbl.ColumnCount = 1;
            chatTbl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            chatTbl.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            chatTbl.Controls.Add(chatIcon, 0, 0);
            chatTbl.Controls.Add(chatBtn, 0, 1);
            chatTbl.Dock = DockStyle.Fill;
            chatTbl.Location = new Point(453, 0);
            chatTbl.Margin = new Padding(0);
            chatTbl.Name = "chatTbl";
            chatTbl.RowCount = 2;
            chatTbl.RowStyles.Add(new RowStyle(SizeType.Percent, 63F));
            chatTbl.RowStyles.Add(new RowStyle(SizeType.Percent, 37F));
            chatTbl.Size = new Size(249, 310);
            chatTbl.TabIndex = 6;
            // 
            // chatIcon
            // 
            chatIcon.Cursor = Cursors.Hand;
            chatIcon.Dock = DockStyle.Fill;
            chatIcon.ErrorImage = Properties.Resources.onlinechaticon;
            chatIcon.Image = Properties.Resources.onlinechaticon;
            chatIcon.InitialImage = Properties.Resources.onlinechaticon;
            chatIcon.Location = new Point(0, 0);
            chatIcon.Margin = new Padding(0);
            chatIcon.Name = "chatIcon";
            chatIcon.Size = new Size(249, 195);
            chatIcon.SizeMode = PictureBoxSizeMode.StretchImage;
            chatIcon.TabIndex = 0;
            chatIcon.TabStop = false;
            chatIcon.Click += chatIcon_Click;
            // 
            // chatBtn
            // 
            chatBtn.Cursor = Cursors.Hand;
            chatBtn.Dock = DockStyle.Fill;
            chatBtn.ErrorImage = Properties.Resources.onlinechatbutton;
            chatBtn.Image = Properties.Resources.onlinechatbutton;
            chatBtn.InitialImage = Properties.Resources.onlinechatbutton;
            chatBtn.Location = new Point(0, 195);
            chatBtn.Margin = new Padding(0);
            chatBtn.Name = "chatBtn";
            chatBtn.Size = new Size(249, 115);
            chatBtn.SizeMode = PictureBoxSizeMode.StretchImage;
            chatBtn.TabIndex = 1;
            chatBtn.TabStop = false;
            chatBtn.Click += chatBtn_Click;
            // 
            // chatbotTbl
            // 
            chatbotTbl.ColumnCount = 1;
            chatbotTbl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            chatbotTbl.Controls.Add(chatbotIcon, 0, 0);
            chatbotTbl.Controls.Add(chatbotBtn, 0, 1);
            chatbotTbl.Dock = DockStyle.Fill;
            chatbotTbl.Location = new Point(102, 0);
            chatbotTbl.Margin = new Padding(0);
            chatbotTbl.Name = "chatbotTbl";
            chatbotTbl.RowCount = 2;
            chatbotTbl.RowStyles.Add(new RowStyle(SizeType.Percent, 63F));
            chatbotTbl.RowStyles.Add(new RowStyle(SizeType.Percent, 37F));
            chatbotTbl.Size = new Size(249, 310);
            chatbotTbl.TabIndex = 7;
            // 
            // chatbotIcon
            // 
            chatbotIcon.Cursor = Cursors.Hand;
            chatbotIcon.Dock = DockStyle.Fill;
            chatbotIcon.ErrorImage = Properties.Resources.chatboticon;
            chatbotIcon.Image = Properties.Resources.chatboticon;
            chatbotIcon.InitialImage = Properties.Resources.chatboticon;
            chatbotIcon.Location = new Point(0, 0);
            chatbotIcon.Margin = new Padding(0);
            chatbotIcon.Name = "chatbotIcon";
            chatbotIcon.Size = new Size(249, 195);
            chatbotIcon.SizeMode = PictureBoxSizeMode.StretchImage;
            chatbotIcon.TabIndex = 0;
            chatbotIcon.TabStop = false;
            chatbotIcon.Click += chatbotIcon_Click;
            // 
            // chatbotBtn
            // 
            chatbotBtn.Cursor = Cursors.Hand;
            chatbotBtn.Dock = DockStyle.Fill;
            chatbotBtn.ErrorImage = Properties.Resources.chatbotbutton;
            chatbotBtn.Image = Properties.Resources.chatbotbutton;
            chatbotBtn.InitialImage = Properties.Resources.chatbotbutton;
            chatbotBtn.Location = new Point(0, 195);
            chatbotBtn.Margin = new Padding(0);
            chatbotBtn.Name = "chatbotBtn";
            chatbotBtn.Size = new Size(249, 115);
            chatbotBtn.SizeMode = PictureBoxSizeMode.StretchImage;
            chatbotBtn.TabIndex = 1;
            chatbotBtn.TabStop = false;
            chatbotBtn.Click += chatbotBtn_Click;
            // 
            // MainMenuUC
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.Transparent;
            BackgroundImage = Properties.Resources.main_menu;
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(mainMenuTbl);
            DoubleBuffered = true;
            Name = "MainMenuUC";
            Size = new Size(1163, 720);
            mainMenuTbl.ResumeLayout(false);
            mainMenuTbl.PerformLayout();
            startedTbl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)getStartedLbl).EndInit();
            midPanel.ResumeLayout(false);
            forumTbl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)forumIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)forumBtn).EndInit();
            chatTbl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chatIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)chatBtn).EndInit();
            chatbotTbl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chatbotIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)chatbotBtn).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel mainMenuTbl;
        private TableLayoutPanel startedTbl;
        private TableLayoutPanel midPanel;
        private PictureBox chatIcon;
        private PictureBox chatBtn;
        private TableLayoutPanel chatbotTbl;
        private PictureBox chatbotIcon;
        private PictureBox chatbotBtn;
        private PictureBox forumIcon;
        private TableLayoutPanel forumTbl;
        private PictureBox forumBtn;
        private TableLayoutPanel chatTbl;
        private PictureBox getStartedLbl;
    }
}
