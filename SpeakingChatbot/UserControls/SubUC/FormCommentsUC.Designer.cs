namespace SpeakingChatbot.UserControls.SubUC {
    partial class FormCommentsUC {
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
            commentTbl = new TableLayoutPanel();
            topPanel = new Panel();
            username = new Label();
            dateLbl = new Label();
            comment = new Label();
            commentTbl.SuspendLayout();
            topPanel.SuspendLayout();
            SuspendLayout();
            // 
            // commentTbl
            // 
            commentTbl.ColumnCount = 1;
            commentTbl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            commentTbl.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            commentTbl.Controls.Add(topPanel, 0, 0);
            commentTbl.Controls.Add(comment, 0, 1);
            commentTbl.Dock = DockStyle.Fill;
            commentTbl.Location = new Point(0, 0);
            commentTbl.Name = "commentTbl";
            commentTbl.RowCount = 2;
            commentTbl.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            commentTbl.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            commentTbl.Size = new Size(674, 150);
            commentTbl.TabIndex = 0;
            // 
            // topPanel
            // 
            topPanel.Controls.Add(username);
            topPanel.Controls.Add(dateLbl);
            topPanel.Dock = DockStyle.Fill;
            topPanel.Location = new Point(3, 3);
            topPanel.Name = "topPanel";
            topPanel.Size = new Size(668, 24);
            topPanel.TabIndex = 0;
            // 
            // username
            // 
            username.AutoSize = true;
            username.Dock = DockStyle.Fill;
            username.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            username.ForeColor = Color.White;
            username.Location = new Point(0, 0);
            username.Name = "username";
            username.Size = new Size(114, 31);
            username.TabIndex = 1;
            username.Text = "username";
            // 
            // dateLbl
            // 
            dateLbl.AutoSize = true;
            dateLbl.Dock = DockStyle.Right;
            dateLbl.ForeColor = Color.White;
            dateLbl.Location = new Point(531, 0);
            dateLbl.Name = "dateLbl";
            dateLbl.Size = new Size(137, 20);
            dateLbl.TabIndex = 0;
            dateLbl.Text = "December 31, 2000";
            // 
            // comment
            // 
            comment.AutoSize = true;
            comment.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            comment.Location = new Point(3, 30);
            comment.Name = "comment";
            comment.Size = new Size(662, 120);
            comment.TabIndex = 1;
            comment.Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Venenatis a condimentum vitae sapien pellentesque habitant morbi. ";
            // 
            // FormCommentsUC
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.Transparent;
            Controls.Add(commentTbl);
            Name = "FormCommentsUC";
            Size = new Size(674, 150);
            Paint += FormCommentsUC_Paint;
            commentTbl.ResumeLayout(false);
            commentTbl.PerformLayout();
            topPanel.ResumeLayout(false);
            topPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel commentTbl;
        private Panel topPanel;
        private Label username;
        private Label dateLbl;
        private Label comment;
    }
}
