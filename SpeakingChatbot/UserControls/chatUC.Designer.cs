using System.Windows.Forms;

namespace SpeakingChatbot.UserControls {
    partial class ChatUC {
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
            chatTbl = new TableLayoutPanel();
            leftChatTbl = new TableLayoutPanel();
            avatarTbl = new TableLayoutPanel();
            avatarPanel = new Panel();
            usersPanel = new FlowLayoutPanel();
            onlineTblPanel = new TableLayoutPanel();
            botBtn = new PictureBox();
            usersBtn = new PictureBox();
            chatLblTbl = new TableLayoutPanel();
            chatLbl = new PictureBox();
            chatRightTbl = new TableLayoutPanel();
            chatBoxTbl = new TableLayoutPanel();
            chatBoxBottomTbl = new TableLayoutPanel();
            sendBtn = new Button();
            msgBox = new TextBox();
            topTbl = new TableLayoutPanel();
            userNameLbl = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            chatBoxMsgTbl = new TableLayoutPanel();
            chatPanel = new Panel();
            backTbl = new TableLayoutPanel();
            backBtn = new PictureBox();
            chatTbl.SuspendLayout();
            leftChatTbl.SuspendLayout();
            avatarTbl.SuspendLayout();
            avatarPanel.SuspendLayout();
            onlineTblPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)botBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)usersBtn).BeginInit();
            chatLblTbl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chatLbl).BeginInit();
            chatRightTbl.SuspendLayout();
            chatBoxTbl.SuspendLayout();
            chatBoxBottomTbl.SuspendLayout();
            topTbl.SuspendLayout();
            chatBoxMsgTbl.SuspendLayout();
            backTbl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)backBtn).BeginInit();
            SuspendLayout();
            // 
            // chatTbl
            // 
            chatTbl.BackColor = Color.Transparent;
            chatTbl.ColumnCount = 2;
            chatTbl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            chatTbl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            chatTbl.Controls.Add(leftChatTbl, 0, 0);
            chatTbl.Controls.Add(chatRightTbl, 1, 0);
            chatTbl.Dock = DockStyle.Fill;
            chatTbl.Location = new Point(0, 0);
            chatTbl.Name = "chatTbl";
            chatTbl.RowCount = 1;
            chatTbl.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            chatTbl.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            chatTbl.Size = new Size(833, 464);
            chatTbl.TabIndex = 0;
            // 
            // leftChatTbl
            // 
            leftChatTbl.ColumnCount = 1;
            leftChatTbl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            leftChatTbl.Controls.Add(avatarTbl, 0, 3);
            leftChatTbl.Controls.Add(chatLblTbl, 0, 1);
            leftChatTbl.Dock = DockStyle.Fill;
            leftChatTbl.Location = new Point(3, 3);
            leftChatTbl.Name = "leftChatTbl";
            leftChatTbl.RowCount = 5;
            leftChatTbl.RowStyles.Add(new RowStyle(SizeType.Percent, 2F));
            leftChatTbl.RowStyles.Add(new RowStyle(SizeType.Percent, 12F));
            leftChatTbl.RowStyles.Add(new RowStyle(SizeType.Percent, 1F));
            leftChatTbl.RowStyles.Add(new RowStyle(SizeType.Percent, 80F));
            leftChatTbl.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            leftChatTbl.Size = new Size(327, 458);
            leftChatTbl.TabIndex = 0;
            // 
            // avatarTbl
            // 
            avatarTbl.ColumnCount = 3;
            avatarTbl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5F));
            avatarTbl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 90F));
            avatarTbl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5F));
            avatarTbl.Controls.Add(avatarPanel, 1, 1);
            avatarTbl.Controls.Add(onlineTblPanel, 1, 0);
            avatarTbl.Dock = DockStyle.Fill;
            avatarTbl.Location = new Point(0, 67);
            avatarTbl.Margin = new Padding(0);
            avatarTbl.Name = "avatarTbl";
            avatarTbl.RowCount = 2;
            avatarTbl.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            avatarTbl.RowStyles.Add(new RowStyle(SizeType.Percent, 90F));
            avatarTbl.Size = new Size(327, 366);
            avatarTbl.TabIndex = 1;
            // 
            // avatarPanel
            // 
            avatarPanel.AutoSize = true;
            avatarPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            avatarPanel.BackColor = Color.FromArgb(200, 0, 0, 0);
            avatarPanel.Controls.Add(usersPanel);
            avatarPanel.Dock = DockStyle.Fill;
            avatarPanel.Location = new Point(16, 36);
            avatarPanel.Margin = new Padding(0);
            avatarPanel.Name = "avatarPanel";
            avatarPanel.Size = new Size(294, 330);
            avatarPanel.TabIndex = 1;
            avatarPanel.SizeChanged += avatarPanel_SizeChanged;
            // 
            // usersPanel
            // 
            usersPanel.AutoScroll = true;
            usersPanel.BackColor = Color.Transparent;
            usersPanel.Dock = DockStyle.Fill;
            usersPanel.Location = new Point(0, 0);
            usersPanel.Name = "usersPanel";
            usersPanel.Size = new Size(294, 330);
            usersPanel.TabIndex = 0;
            // 
            // onlineTblPanel
            // 
            onlineTblPanel.ColumnCount = 5;
            onlineTblPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5F));
            onlineTblPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 42F));
            onlineTblPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 6F));
            onlineTblPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 42F));
            onlineTblPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5F));
            onlineTblPanel.Controls.Add(botBtn, 1, 1);
            onlineTblPanel.Controls.Add(usersBtn, 3, 1);
            onlineTblPanel.Dock = DockStyle.Fill;
            onlineTblPanel.Location = new Point(16, 0);
            onlineTblPanel.Margin = new Padding(0);
            onlineTblPanel.Name = "onlineTblPanel";
            onlineTblPanel.RowCount = 2;
            onlineTblPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 2F));
            onlineTblPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 98F));
            onlineTblPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            onlineTblPanel.Size = new Size(294, 36);
            onlineTblPanel.TabIndex = 2;
            // 
            // botBtn
            // 
            botBtn.BackgroundImageLayout = ImageLayout.None;
            botBtn.Dock = DockStyle.Fill;
            botBtn.Image = Properties.Resources.dahlia;
            botBtn.Location = new Point(17, 3);
            botBtn.Name = "botBtn";
            botBtn.Size = new Size(117, 30);
            botBtn.SizeMode = PictureBoxSizeMode.StretchImage;
            botBtn.TabIndex = 0;
            botBtn.TabStop = false;
            botBtn.Click += botBtn_Click;
            // 
            // usersBtn
            // 
            usersBtn.Dock = DockStyle.Fill;
            usersBtn.Image = Properties.Resources.users;
            usersBtn.Location = new Point(157, 3);
            usersBtn.Name = "usersBtn";
            usersBtn.Size = new Size(117, 30);
            usersBtn.SizeMode = PictureBoxSizeMode.StretchImage;
            usersBtn.TabIndex = 1;
            usersBtn.TabStop = false;
            usersBtn.Click += usersBtn_Click;
            // 
            // chatLblTbl
            // 
            chatLblTbl.ColumnCount = 3;
            chatLblTbl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            chatLblTbl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            chatLblTbl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            chatLblTbl.Controls.Add(chatLbl, 1, 1);
            chatLblTbl.Dock = DockStyle.Fill;
            chatLblTbl.Location = new Point(3, 12);
            chatLblTbl.Name = "chatLblTbl";
            chatLblTbl.RowCount = 3;
            chatLblTbl.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            chatLblTbl.RowStyles.Add(new RowStyle(SizeType.Percent, 80F));
            chatLblTbl.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            chatLblTbl.Size = new Size(321, 48);
            chatLblTbl.TabIndex = 2;
            // 
            // chatLbl
            // 
            chatLbl.Dock = DockStyle.Fill;
            chatLbl.Image = Properties.Resources.chats_label;
            chatLbl.Location = new Point(67, 7);
            chatLbl.Name = "chatLbl";
            chatLbl.Size = new Size(186, 32);
            chatLbl.SizeMode = PictureBoxSizeMode.StretchImage;
            chatLbl.TabIndex = 0;
            chatLbl.TabStop = false;
            // 
            // chatRightTbl
            // 
            chatRightTbl.ColumnCount = 2;
            chatRightTbl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 95F));
            chatRightTbl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5F));
            chatRightTbl.Controls.Add(chatBoxTbl, 0, 2);
            chatRightTbl.Controls.Add(backTbl, 0, 1);
            chatRightTbl.Dock = DockStyle.Fill;
            chatRightTbl.Location = new Point(336, 3);
            chatRightTbl.Name = "chatRightTbl";
            chatRightTbl.RowCount = 4;
            chatRightTbl.RowStyles.Add(new RowStyle(SizeType.Percent, 2F));
            chatRightTbl.RowStyles.Add(new RowStyle(SizeType.Percent, 13F));
            chatRightTbl.RowStyles.Add(new RowStyle(SizeType.Percent, 80F));
            chatRightTbl.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            chatRightTbl.Size = new Size(494, 458);
            chatRightTbl.TabIndex = 1;
            // 
            // chatBoxTbl
            // 
            chatBoxTbl.BackColor = Color.FromArgb(200, 0, 0, 0);
            chatBoxTbl.ColumnCount = 1;
            chatBoxTbl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            chatBoxTbl.Controls.Add(chatBoxBottomTbl, 0, 2);
            chatBoxTbl.Controls.Add(topTbl, 0, 0);
            chatBoxTbl.Controls.Add(chatBoxMsgTbl, 0, 1);
            chatBoxTbl.Dock = DockStyle.Fill;
            chatBoxTbl.Location = new Point(0, 68);
            chatBoxTbl.Margin = new Padding(0);
            chatBoxTbl.Name = "chatBoxTbl";
            chatBoxTbl.RowCount = 3;
            chatBoxTbl.RowStyles.Add(new RowStyle(SizeType.Percent, 13F));
            chatBoxTbl.RowStyles.Add(new RowStyle(SizeType.Percent, 77F));
            chatBoxTbl.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            chatBoxTbl.Size = new Size(469, 366);
            chatBoxTbl.TabIndex = 0;
            // 
            // chatBoxBottomTbl
            // 
            chatBoxBottomTbl.BackColor = Color.Transparent;
            chatBoxBottomTbl.ColumnCount = 2;
            chatBoxBottomTbl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 77F));
            chatBoxBottomTbl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 23F));
            chatBoxBottomTbl.Controls.Add(sendBtn, 1, 0);
            chatBoxBottomTbl.Controls.Add(msgBox, 0, 0);
            chatBoxBottomTbl.Dock = DockStyle.Fill;
            chatBoxBottomTbl.Location = new Point(0, 328);
            chatBoxBottomTbl.Margin = new Padding(0);
            chatBoxBottomTbl.Name = "chatBoxBottomTbl";
            chatBoxBottomTbl.RowCount = 1;
            chatBoxBottomTbl.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            chatBoxBottomTbl.Size = new Size(469, 38);
            chatBoxBottomTbl.TabIndex = 0;
            // 
            // sendBtn
            // 
            sendBtn.AutoSize = true;
            sendBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            sendBtn.Dock = DockStyle.Fill;
            sendBtn.FlatStyle = FlatStyle.Flat;
            sendBtn.ForeColor = Color.White;
            sendBtn.Location = new Point(364, 3);
            sendBtn.Name = "sendBtn";
            sendBtn.Size = new Size(102, 32);
            sendBtn.TabIndex = 0;
            sendBtn.Text = "Send";
            sendBtn.UseVisualStyleBackColor = true;
            sendBtn.Click += sendBtn_Click;
            // 
            // msgBox
            // 
            msgBox.Dock = DockStyle.Fill;
            msgBox.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            msgBox.Location = new Point(5, 5);
            msgBox.Margin = new Padding(5);
            msgBox.Name = "msgBox";
            msgBox.Size = new Size(351, 31);
            msgBox.TabIndex = 1;
            // 
            // topTbl
            // 
            topTbl.ColumnCount = 4;
            topTbl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5F));
            topTbl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 85F));
            topTbl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 7F));
            topTbl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 3F));
            topTbl.Controls.Add(userNameLbl, 1, 0);
            topTbl.Controls.Add(tableLayoutPanel1, 2, 0);
            topTbl.Dock = DockStyle.Fill;
            topTbl.Location = new Point(3, 3);
            topTbl.Name = "topTbl";
            topTbl.RowCount = 1;
            topTbl.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            topTbl.Size = new Size(463, 41);
            topTbl.TabIndex = 1;
            // 
            // userNameLbl
            // 
            userNameLbl.AutoSize = true;
            userNameLbl.BackColor = Color.Transparent;
            userNameLbl.Dock = DockStyle.Left;
            userNameLbl.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            userNameLbl.ForeColor = Color.White;
            userNameLbl.Location = new Point(26, 0);
            userNameLbl.Name = "userNameLbl";
            userNameLbl.Size = new Size(133, 41);
            userNameLbl.TabIndex = 0;
            userNameLbl.Text = "USERNAME";
            userNameLbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(416, 0);
            tableLayoutPanel1.Margin = new Padding(0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 17F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 66F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 17F));
            tableLayoutPanel1.Size = new Size(32, 41);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // chatBoxMsgTbl
            // 
            chatBoxMsgTbl.AutoScroll = true;
            chatBoxMsgTbl.ColumnCount = 3;
            chatBoxMsgTbl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 1F));
            chatBoxMsgTbl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 98F));
            chatBoxMsgTbl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 1F));
            chatBoxMsgTbl.Controls.Add(chatPanel, 1, 0);
            chatBoxMsgTbl.Dock = DockStyle.Fill;
            chatBoxMsgTbl.Location = new Point(3, 50);
            chatBoxMsgTbl.Name = "chatBoxMsgTbl";
            chatBoxMsgTbl.RowCount = 1;
            chatBoxMsgTbl.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            chatBoxMsgTbl.Size = new Size(463, 275);
            chatBoxMsgTbl.TabIndex = 2;
            // 
            // chatPanel
            // 
            chatPanel.BackColor = Color.Transparent;
            chatPanel.Dock = DockStyle.Fill;
            chatPanel.Location = new Point(8, 3);
            chatPanel.Margin = new Padding(4, 3, 4, 3);
            chatPanel.Name = "chatPanel";
            chatPanel.Size = new Size(445, 269);
            chatPanel.TabIndex = 0;
            // 
            // backTbl
            // 
            backTbl.ColumnCount = 2;
            backTbl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            backTbl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            backTbl.Controls.Add(backBtn, 1, 0);
            backTbl.Dock = DockStyle.Fill;
            backTbl.Location = new Point(3, 12);
            backTbl.Name = "backTbl";
            backTbl.RowCount = 1;
            backTbl.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            backTbl.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            backTbl.Size = new Size(463, 53);
            backTbl.TabIndex = 1;
            // 
            // backBtn
            // 
            backBtn.Dock = DockStyle.Fill;
            backBtn.Image = Properties.Resources.backbutton;
            backBtn.Location = new Point(324, 0);
            backBtn.Margin = new Padding(0);
            backBtn.Name = "backBtn";
            backBtn.Size = new Size(139, 53);
            backBtn.SizeMode = PictureBoxSizeMode.StretchImage;
            backBtn.TabIndex = 0;
            backBtn.TabStop = false;
            backBtn.Click += backBtn_Click;
            // 
            // ChatUC
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.chat;
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(chatTbl);
            DoubleBuffered = true;
            Margin = new Padding(0);
            Name = "ChatUC";
            Size = new Size(833, 464);
            Load += ChatUC_Load;
            chatTbl.ResumeLayout(false);
            leftChatTbl.ResumeLayout(false);
            avatarTbl.ResumeLayout(false);
            avatarTbl.PerformLayout();
            avatarPanel.ResumeLayout(false);
            onlineTblPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)botBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)usersBtn).EndInit();
            chatLblTbl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chatLbl).EndInit();
            chatRightTbl.ResumeLayout(false);
            chatBoxTbl.ResumeLayout(false);
            chatBoxBottomTbl.ResumeLayout(false);
            chatBoxBottomTbl.PerformLayout();
            topTbl.ResumeLayout(false);
            topTbl.PerformLayout();
            chatBoxMsgTbl.ResumeLayout(false);
            backTbl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)backBtn).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel chatTbl;
        private TableLayoutPanel leftChatTbl;
        private TableLayoutPanel avatarTbl;
        private Panel avatarPanel;
        private TableLayoutPanel onlineTblPanel;
        private TableLayoutPanel chatRightTbl;
        private TableLayoutPanel chatBoxTbl;
        private TableLayoutPanel chatBoxBottomTbl;
        private Button sendBtn;
        private TextBox msgBox;
        private TableLayoutPanel chatLblTbl;
        private PictureBox chatLbl;
        private PictureBox botBtn;
        private PictureBox usersBtn;
        private TableLayoutPanel backTbl;
        private PictureBox backBtn;
        private TableLayoutPanel topTbl;
        private Label userNameLbl;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel chatBoxMsgTbl;
        private Panel chatPanel;
        private FlowLayoutPanel usersPanel;
    }
}
