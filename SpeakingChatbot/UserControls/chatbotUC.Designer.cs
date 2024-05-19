using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace SpeakingChatbot.UserControls {
    partial class ChatbotUC {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        /// 
        public void SetPictureBoxImage(Image image) {
            avatar.Image = image;
        }
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
            chatbotTbl = new TableLayoutPanel();
            botTbl = new TableLayoutPanel();
            topTbl = new TableLayoutPanel();
            meetDahlia = new PictureBox();
            backTbl = new TableLayoutPanel();
            backBtn = new PictureBox();
            avatar = new PictureBox();
            chatTbl = new TableLayoutPanel();
            chatBottomPanel = new TableLayoutPanel();
            sendBtn = new Button();
            msgBox = new RichTextBox();
            chatPanelTbl = new TableLayoutPanel();
            chatPanel = new FlowLayoutPanel();
            chatbotTbl.SuspendLayout();
            botTbl.SuspendLayout();
            topTbl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)meetDahlia).BeginInit();
            backTbl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)backBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)avatar).BeginInit();
            chatTbl.SuspendLayout();
            chatBottomPanel.SuspendLayout();
            chatPanelTbl.SuspendLayout();
            SuspendLayout();
            // 
            // chatbotTbl
            // 
            chatbotTbl.BackColor = Color.Transparent;
            chatbotTbl.ColumnCount = 2;
            chatbotTbl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            chatbotTbl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            chatbotTbl.Controls.Add(botTbl, 1, 0);
            chatbotTbl.Controls.Add(chatTbl, 0, 0);
            chatbotTbl.Dock = DockStyle.Fill;
            chatbotTbl.Location = new Point(0, 0);
            chatbotTbl.Name = "chatbotTbl";
            chatbotTbl.RowCount = 1;
            chatbotTbl.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            chatbotTbl.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            chatbotTbl.Size = new Size(1165, 737);
            chatbotTbl.TabIndex = 0;
            // 
            // botTbl
            // 
            botTbl.ColumnCount = 1;
            botTbl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            botTbl.Controls.Add(topTbl, 0, 0);
            botTbl.Controls.Add(avatar, 0, 1);
            botTbl.Dock = DockStyle.Fill;
            botTbl.Location = new Point(585, 3);
            botTbl.Name = "botTbl";
            botTbl.RowCount = 2;
            botTbl.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            botTbl.RowStyles.Add(new RowStyle(SizeType.Percent, 80F));
            botTbl.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            botTbl.Size = new Size(577, 731);
            botTbl.TabIndex = 0;
            // 
            // topTbl
            // 
            topTbl.ColumnCount = 4;
            topTbl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5F));
            topTbl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 65F));
            topTbl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5F));
            topTbl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            topTbl.Controls.Add(meetDahlia, 1, 1);
            topTbl.Controls.Add(backTbl, 3, 1);
            topTbl.Dock = DockStyle.Fill;
            topTbl.Location = new Point(3, 3);
            topTbl.Name = "topTbl";
            topTbl.RowCount = 2;
            topTbl.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            topTbl.RowStyles.Add(new RowStyle(SizeType.Percent, 95F));
            topTbl.Size = new Size(571, 140);
            topTbl.TabIndex = 1;
            // 
            // meetDahlia
            // 
            meetDahlia.Dock = DockStyle.Fill;
            meetDahlia.Image = Properties.Resources.meet_dahlia_label;
            meetDahlia.Location = new Point(28, 7);
            meetDahlia.Margin = new Padding(0);
            meetDahlia.Name = "meetDahlia";
            meetDahlia.Size = new Size(371, 133);
            meetDahlia.SizeMode = PictureBoxSizeMode.StretchImage;
            meetDahlia.TabIndex = 2;
            meetDahlia.TabStop = false;
            // 
            // backTbl
            // 
            backTbl.ColumnCount = 1;
            backTbl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            backTbl.Controls.Add(backBtn, 0, 0);
            backTbl.Dock = DockStyle.Fill;
            backTbl.Location = new Point(430, 10);
            backTbl.Name = "backTbl";
            backTbl.RowCount = 2;
            backTbl.RowStyles.Add(new RowStyle(SizeType.Percent, 53F));
            backTbl.RowStyles.Add(new RowStyle(SizeType.Percent, 47F));
            backTbl.Size = new Size(138, 127);
            backTbl.TabIndex = 1;
            // 
            // backBtn
            // 
            backBtn.Cursor = Cursors.Hand;
            backBtn.Dock = DockStyle.Fill;
            backBtn.Image = Properties.Resources.backbutton;
            backBtn.Location = new Point(0, 0);
            backBtn.Margin = new Padding(0);
            backBtn.Name = "backBtn";
            backBtn.Size = new Size(138, 67);
            backBtn.SizeMode = PictureBoxSizeMode.StretchImage;
            backBtn.TabIndex = 0;
            backBtn.TabStop = false;
            backBtn.Click += backBtn_Click;
            // 
            // avatar
            // 
            avatar.BackColor = Color.Transparent;
            avatar.Dock = DockStyle.Fill;
            avatar.Image = Properties.Resources.Idle1;
            avatar.Location = new Point(3, 149);
            avatar.Name = "avatar";
            avatar.Size = new Size(571, 579);
            avatar.SizeMode = PictureBoxSizeMode.StretchImage;
            avatar.TabIndex = 0;
            avatar.TabStop = false;
            // 
            // chatTbl
            // 
            chatTbl.BackColor = Color.FromArgb(200, 0, 0, 0);
            chatTbl.ColumnCount = 1;
            chatTbl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            chatTbl.Controls.Add(chatBottomPanel, 0, 1);
            chatTbl.Controls.Add(chatPanelTbl, 0, 0);
            chatTbl.Dock = DockStyle.Fill;
            chatTbl.Location = new Point(20, 20);
            chatTbl.Margin = new Padding(20);
            chatTbl.Name = "chatTbl";
            chatTbl.RowCount = 2;
            chatTbl.RowStyles.Add(new RowStyle(SizeType.Percent, 93F));
            chatTbl.RowStyles.Add(new RowStyle(SizeType.Percent, 7F));
            chatTbl.Size = new Size(542, 697);
            chatTbl.TabIndex = 1;
            // 
            // chatBottomPanel
            // 
            chatBottomPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            chatBottomPanel.BackColor = Color.Transparent;
            chatBottomPanel.ColumnCount = 2;
            chatBottomPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 77F));
            chatBottomPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 23F));
            chatBottomPanel.Controls.Add(sendBtn, 1, 0);
            chatBottomPanel.Controls.Add(msgBox, 0, 0);
            chatBottomPanel.Dock = DockStyle.Fill;
            chatBottomPanel.Location = new Point(0, 648);
            chatBottomPanel.Margin = new Padding(0);
            chatBottomPanel.Name = "chatBottomPanel";
            chatBottomPanel.RowCount = 1;
            chatBottomPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            chatBottomPanel.Size = new Size(542, 49);
            chatBottomPanel.TabIndex = 0;
            // 
            // sendBtn
            // 
            sendBtn.AutoSize = true;
            sendBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            sendBtn.Cursor = Cursors.Hand;
            sendBtn.Dock = DockStyle.Fill;
            sendBtn.FlatStyle = FlatStyle.Flat;
            sendBtn.FlatAppearance.MouseOverBackColor = Color.Transparent;
            sendBtn.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            sendBtn.ForeColor = Color.White;
            sendBtn.Location = new Point(420, 3);
            sendBtn.Name = "sendBtn";
            sendBtn.Size = new Size(119, 43);
            sendBtn.TabIndex = 0;
            sendBtn.Text = "Send";
            sendBtn.UseVisualStyleBackColor = true;
            sendBtn.Click += sendBtn_Click;
            // 
            // msgBox
            // 
            msgBox.Cursor = Cursors.IBeam;
            msgBox.Dock = DockStyle.Fill;
            msgBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            msgBox.Location = new Point(3, 3);
            msgBox.Name = "msgBox";
            msgBox.Size = new Size(411, 43);
            msgBox.TabIndex = 1;
            msgBox.Text = "";
            // 
            // chatPanelTbl
            // 
            chatPanelTbl.BackColor = Color.Transparent;
            chatPanelTbl.ColumnCount = 3;
            chatPanelTbl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 1F));
            chatPanelTbl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 98F));
            chatPanelTbl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 1F));
            chatPanelTbl.Controls.Add(chatPanel, 1, 0);
            chatPanelTbl.Dock = DockStyle.Fill;
            chatPanelTbl.Location = new Point(3, 3);
            chatPanelTbl.Name = "chatPanelTbl";
            chatPanelTbl.RowCount = 1;
            chatPanelTbl.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            chatPanelTbl.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            chatPanelTbl.Size = new Size(536, 642);
            chatPanelTbl.TabIndex = 1;
            // 
            // chatPanel
            // 
            chatPanel.AutoScroll = true;
            chatPanel.BackColor = Color.Transparent;
            chatPanel.Dock = DockStyle.Fill;
            chatPanel.Location = new Point(8, 3);
            chatPanel.Name = "chatPanel";
            chatPanel.Size = new Size(519, 636);
            chatPanel.TabIndex = 0;
            // 
            // ChatbotUC
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.ai;
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(chatbotTbl);
            DoubleBuffered = true;
            Name = "ChatbotUC";
            Size = new Size(1165, 737);
            Paint += ChatbotUC_Paint;
            Resize += ChatbotUC_Resize;
            chatbotTbl.ResumeLayout(false);
            botTbl.ResumeLayout(false);
            topTbl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)meetDahlia).EndInit();
            backTbl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)backBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)avatar).EndInit();
            chatTbl.ResumeLayout(false);
            chatBottomPanel.ResumeLayout(false);
            chatBottomPanel.PerformLayout();
            chatPanelTbl.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel chatbotTbl;
        private TableLayoutPanel botTbl;
        private PictureBox avatar;
        private TableLayoutPanel topTbl;
        private TableLayoutPanel chatTbl;
        private TableLayoutPanel chatBottomPanel;
        private Button sendBtn;
        private TableLayoutPanel backTbl;
        private PictureBox backBtn;
        private PictureBox meetDahlia;
        private TableLayoutPanel chatPanelTbl;
        private FlowLayoutPanel chatPanel;
        private RichTextBox msgBox;
    }
}