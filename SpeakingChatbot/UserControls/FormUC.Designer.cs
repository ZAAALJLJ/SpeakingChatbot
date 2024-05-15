namespace SpeakingChatbot.UserControls {
    partial class FormUC {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUC));
            formTbl = new TableLayoutPanel();
            bottomPanel = new Panel();
            commentTextBox = new TextBox();
            submitBtn = new Button();
            topPanel = new Panel();
            commentPanel = new Panel();
            btnTbl = new TableLayoutPanel();
            upVote = new Button();
            downVote = new Button();
            votes = new Label();
            content = new Label();
            titleLbl = new Label();
            formTbl.SuspendLayout();
            bottomPanel.SuspendLayout();
            topPanel.SuspendLayout();
            btnTbl.SuspendLayout();
            SuspendLayout();
            // 
            // formTbl
            // 
            formTbl.BackColor = Color.FromArgb(200, 0, 0, 0);
            formTbl.ColumnCount = 1;
            formTbl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            formTbl.Controls.Add(bottomPanel, 0, 1);
            formTbl.Controls.Add(topPanel, 0, 0);
            formTbl.Dock = DockStyle.Fill;
            formTbl.Location = new Point(20, 20);
            formTbl.Name = "formTbl";
            formTbl.Padding = new Padding(10);
            formTbl.RowCount = 2;
            formTbl.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            formTbl.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            formTbl.Size = new Size(891, 643);
            formTbl.TabIndex = 0;
            // 
            // bottomPanel
            // 
            bottomPanel.BackColor = Color.Transparent;
            bottomPanel.Controls.Add(commentTextBox);
            bottomPanel.Controls.Add(submitBtn);
            bottomPanel.Dock = DockStyle.Fill;
            bottomPanel.Location = new Point(13, 593);
            bottomPanel.Margin = new Padding(3, 10, 3, 3);
            bottomPanel.Name = "bottomPanel";
            bottomPanel.Size = new Size(865, 37);
            bottomPanel.TabIndex = 0;
            // 
            // commentTextBox
            // 
            commentTextBox.Dock = DockStyle.Fill;
            commentTextBox.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            commentTextBox.Location = new Point(0, 0);
            commentTextBox.Name = "commentTextBox";
            commentTextBox.Size = new Size(779, 38);
            commentTextBox.TabIndex = 1;
            // 
            // submitBtn
            // 
            submitBtn.AutoSize = true;
            submitBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            submitBtn.Dock = DockStyle.Right;
            submitBtn.Location = new Point(779, 0);
            submitBtn.Name = "submitBtn";
            submitBtn.Padding = new Padding(10, 0, 10, 0);
            submitBtn.Size = new Size(86, 37);
            submitBtn.TabIndex = 0;
            submitBtn.Text = "Submit";
            submitBtn.UseVisualStyleBackColor = true;
            submitBtn.Click += submitBtn_Click;
            // 
            // topPanel
            // 
            topPanel.AutoScroll = true;
            topPanel.BackColor = Color.Transparent;
            topPanel.Controls.Add(commentPanel);
            topPanel.Controls.Add(btnTbl);
            topPanel.Controls.Add(content);
            topPanel.Controls.Add(titleLbl);
            topPanel.Dock = DockStyle.Fill;
            topPanel.Location = new Point(13, 13);
            topPanel.Margin = new Padding(3, 3, 3, 10);
            topPanel.Name = "topPanel";
            topPanel.Size = new Size(865, 560);
            topPanel.TabIndex = 1;
            // 
            // commentPanel
            // 
            commentPanel.AutoSize = true;
            commentPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            commentPanel.Dock = DockStyle.Top;
            commentPanel.Location = new Point(0, 305);
            commentPanel.Name = "commentPanel";
            commentPanel.Size = new Size(865, 0);
            commentPanel.TabIndex = 3;
            // 
            // btnTbl
            // 
            btnTbl.ColumnCount = 3;
            btnTbl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            btnTbl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            btnTbl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            btnTbl.Controls.Add(upVote, 0, 0);
            btnTbl.Controls.Add(downVote, 1, 0);
            btnTbl.Controls.Add(votes, 2, 0);
            btnTbl.Dock = DockStyle.Top;
            btnTbl.Location = new Point(0, 264);
            btnTbl.Name = "btnTbl";
            btnTbl.RowCount = 1;
            btnTbl.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            btnTbl.Size = new Size(865, 41);
            btnTbl.TabIndex = 2;
            // 
            // upVote
            // 
            upVote.BackColor = Color.FromArgb(0, 192, 0);
            upVote.Dock = DockStyle.Fill;
            upVote.FlatStyle = FlatStyle.Popup;
            upVote.Location = new Point(3, 3);
            upVote.Name = "upVote";
            upVote.Size = new Size(340, 35);
            upVote.TabIndex = 0;
            upVote.Text = "upVote";
            upVote.UseVisualStyleBackColor = false;
            // 
            // downVote
            // 
            downVote.AutoSize = true;
            downVote.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            downVote.BackColor = Color.Red;
            downVote.BackgroundImageLayout = ImageLayout.None;
            downVote.Dock = DockStyle.Fill;
            downVote.FlatStyle = FlatStyle.Popup;
            downVote.ForeColor = Color.White;
            downVote.Location = new Point(349, 3);
            downVote.Name = "downVote";
            downVote.Size = new Size(340, 35);
            downVote.TabIndex = 1;
            downVote.Text = "downVote";
            downVote.UseVisualStyleBackColor = false;
            // 
            // votes
            // 
            votes.AutoSize = true;
            votes.Dock = DockStyle.Fill;
            votes.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            votes.ForeColor = Color.White;
            votes.Location = new Point(695, 0);
            votes.Name = "votes";
            votes.Size = new Size(167, 41);
            votes.TabIndex = 2;
            votes.Text = "0";
            votes.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // content
            // 
            content.Dock = DockStyle.Top;
            content.ForeColor = Color.White;
            content.Location = new Point(0, 81);
            content.Name = "content";
            content.Size = new Size(865, 183);
            content.TabIndex = 1;
            content.Text = resources.GetString("content.Text");
            // 
            // titleLbl
            // 
            titleLbl.AutoSize = true;
            titleLbl.Dock = DockStyle.Top;
            titleLbl.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point);
            titleLbl.ForeColor = Color.White;
            titleLbl.Location = new Point(0, 0);
            titleLbl.Name = "titleLbl";
            titleLbl.Size = new Size(231, 81);
            titleLbl.TabIndex = 0;
            titleLbl.Text = "TITLEEE";
            titleLbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // FormUC
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            AutoSize = true;
            BackgroundImage = Properties.Resources.forums;
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(formTbl);
            DoubleBuffered = true;
            Name = "FormUC";
            Padding = new Padding(20);
            Size = new Size(931, 683);
            Load += FormUC_Load;
            formTbl.ResumeLayout(false);
            bottomPanel.ResumeLayout(false);
            bottomPanel.PerformLayout();
            topPanel.ResumeLayout(false);
            topPanel.PerformLayout();
            btnTbl.ResumeLayout(false);
            btnTbl.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel formTbl;
        private Panel bottomPanel;
        private TextBox commentTextBox;
        private Button submitBtn;
        private Panel topPanel;
        private Label titleLbl;
        private TableLayoutPanel btnTbl;
        private Button upVote;
        private Button downVote;
        private Label content;
        private Panel commentPanel;
        private Label votes;
    }
}
