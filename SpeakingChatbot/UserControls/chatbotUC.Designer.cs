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
            msgBox = new TextBox();
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
            chatbotTbl.Size = new Size(948, 569);
            chatbotTbl.TabIndex = 0;
            // 
            // botTbl
            // 
            botTbl.ColumnCount = 1;
            botTbl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            botTbl.Controls.Add(topTbl, 0, 0);
            botTbl.Controls.Add(avatar, 0, 1);
            botTbl.Dock = DockStyle.Fill;
            botTbl.Location = new Point(477, 3);
            botTbl.Name = "botTbl";
            botTbl.RowCount = 2;
            botTbl.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            botTbl.RowStyles.Add(new RowStyle(SizeType.Percent, 80F));
            botTbl.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            botTbl.Size = new Size(468, 563);
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
            topTbl.Size = new Size(462, 106);
            topTbl.TabIndex = 1;
            // 
            // meetDahlia
            // 
            meetDahlia.Dock = DockStyle.Fill;
            meetDahlia.Image = Properties.Resources.meet_dahlia_label;
            meetDahlia.Location = new Point(23, 5);
            meetDahlia.Margin = new Padding(0);
            meetDahlia.Name = "meetDahlia";
            meetDahlia.Size = new Size(300, 101);
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
            backTbl.Location = new Point(349, 8);
            backTbl.Name = "backTbl";
            backTbl.RowCount = 2;
            backTbl.RowStyles.Add(new RowStyle(SizeType.Percent, 53F));
            backTbl.RowStyles.Add(new RowStyle(SizeType.Percent, 47F));
            backTbl.Size = new Size(110, 95);
            backTbl.TabIndex = 1;
            // 
            // backBtn
            // 
            backBtn.Dock = DockStyle.Fill;
            backBtn.Image = Properties.Resources.backbutton;
            backBtn.Location = new Point(0, 0);
            backBtn.Margin = new Padding(0);
            backBtn.Name = "backBtn";
            backBtn.Size = new Size(110, 50);
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
            avatar.Location = new Point(3, 115);
            avatar.Name = "avatar";
            avatar.Size = new Size(462, 445);
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
            chatTbl.RowStyles.Add(new RowStyle(SizeType.Percent, 92F));
            chatTbl.RowStyles.Add(new RowStyle(SizeType.Percent, 8F));
            chatTbl.Size = new Size(434, 529);
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
            chatBottomPanel.Location = new Point(0, 486);
            chatBottomPanel.Margin = new Padding(0);
            chatBottomPanel.Name = "chatBottomPanel";
            chatBottomPanel.RowCount = 1;
            chatBottomPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            chatBottomPanel.Size = new Size(434, 43);
            chatBottomPanel.TabIndex = 0;
            // 
            // sendBtn
            // 
            sendBtn.AutoSize = true;
            sendBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            sendBtn.Dock = DockStyle.Fill;
            sendBtn.FlatStyle = FlatStyle.Flat;
            sendBtn.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            sendBtn.ForeColor = Color.White;
            sendBtn.Location = new Point(337, 3);
            sendBtn.Name = "sendBtn";
            sendBtn.Size = new Size(94, 37);
            sendBtn.TabIndex = 0;
            sendBtn.Text = "Send";
            sendBtn.UseVisualStyleBackColor = true;
            sendBtn.Click += sendBtn_Click;
            // 
            // msgBox
            // 
            msgBox.Dock = DockStyle.Fill;
            msgBox.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            msgBox.Location = new Point(5, 5);
            msgBox.Margin = new Padding(5);
            msgBox.Name = "msgBox";
            msgBox.Size = new Size(324, 30);
            msgBox.TabIndex = 1;
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
            chatPanelTbl.Size = new Size(428, 480);
            chatPanelTbl.TabIndex = 1;
            // 
            // chatPanel
            // 
            chatPanel.BackColor = Color.Transparent;
            chatPanel.Dock = DockStyle.Fill;
            chatPanel.Location = new Point(7, 3);
            chatPanel.Name = "chatPanel";
            chatPanel.Size = new Size(413, 474);
            chatPanel.TabIndex = 0;
            // 
            // ChatbotUC
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.ai;
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(chatbotTbl);
            Name = "ChatbotUC";
            Size = new Size(948, 569);
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
        private TextBox msgBox;
        private TableLayoutPanel backTbl;
        private PictureBox backBtn;
        private PictureBox meetDahlia;
        private TableLayoutPanel chatPanelTbl;
        private FlowLayoutPanel chatPanel;
    }
}
