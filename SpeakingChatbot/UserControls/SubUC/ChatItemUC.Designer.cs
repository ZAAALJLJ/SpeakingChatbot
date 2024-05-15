namespace SpeakingChatbot.UserControls.SubUC {
    partial class ChatItemUC {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChatItemUC));
            chatTbl = new TableLayoutPanel();
            profilePic = new PictureBox();
            chatMsg = new Label();
            chatTbl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)profilePic).BeginInit();
            SuspendLayout();
            // 
            // chatTbl
            // 
            chatTbl.AutoSize = true;
            chatTbl.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            chatTbl.BackColor = Color.Transparent;
            chatTbl.ColumnCount = 4;
            chatTbl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5F));
            chatTbl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45F));
            chatTbl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45F));
            chatTbl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5F));
            chatTbl.Controls.Add(profilePic, 0, 0);
            chatTbl.Controls.Add(chatMsg, 2, 0);
            chatTbl.Dock = DockStyle.Fill;
            chatTbl.Location = new Point(0, 0);
            chatTbl.Name = "chatTbl";
            chatTbl.RowCount = 1;
            chatTbl.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            chatTbl.Size = new Size(760, 126);
            chatTbl.TabIndex = 0;
            // 
            // profilePic
            // 
            profilePic.Dock = DockStyle.Bottom;
            profilePic.Image = Properties.Resources.forumicon;
            profilePic.Location = new Point(3, 91);
            profilePic.Name = "profilePic";
            profilePic.Size = new Size(32, 32);
            profilePic.SizeMode = PictureBoxSizeMode.StretchImage;
            profilePic.TabIndex = 0;
            profilePic.TabStop = false;
            // 
            // chatMsg
            // 
            chatMsg.AutoSize = true;
            chatMsg.BackColor = SystemColors.ActiveCaption;
            chatMsg.Dock = DockStyle.Right;
            chatMsg.Location = new Point(384, 3);
            chatMsg.Margin = new Padding(3);
            chatMsg.Name = "chatMsg";
            chatMsg.Size = new Size(335, 120);
            chatMsg.TabIndex = 1;
            chatMsg.Text = resources.GetString("chatMsg.Text");
            chatMsg.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // ChatItemUC
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.Transparent;
            Controls.Add(chatTbl);
            Name = "ChatItemUC";
            Size = new Size(760, 126);
            chatTbl.ResumeLayout(false);
            chatTbl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)profilePic).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel chatTbl;
        private PictureBox profilePic;
        private Label chatMsg;
    }
}
