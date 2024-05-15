namespace SpeakingChatbot.UserControls.SubUC {
    partial class FormItemUC {
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
            usernameLbl = new Label();
            lineLbl = new Label();
            categoryLbl = new Label();
            sdgLbl = new Label();
            topRightPanel = new Panel();
            formTbl = new TableLayoutPanel();
            dateLbl = new Label();
            contentPanel = new Panel();
            titleLbl = new Label();
            votesLbl = new Label();
            topRightPanel.SuspendLayout();
            formTbl.SuspendLayout();
            contentPanel.SuspendLayout();
            SuspendLayout();
            // 
            // usernameLbl
            // 
            usernameLbl.AutoSize = true;
            usernameLbl.Dock = DockStyle.Left;
            usernameLbl.ForeColor = SystemColors.Highlight;
            usernameLbl.Location = new Point(3, 0);
            usernameLbl.Name = "usernameLbl";
            usernameLbl.Size = new Size(86, 40);
            usernameLbl.TabIndex = 1;
            usernameLbl.Text = "USERNAME";
            usernameLbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lineLbl
            // 
            lineLbl.AutoSize = true;
            lineLbl.Dock = DockStyle.Right;
            lineLbl.ForeColor = Color.White;
            lineLbl.Location = new Point(126, 0);
            lineLbl.Name = "lineLbl";
            lineLbl.Size = new Size(13, 20);
            lineLbl.TabIndex = 1;
            lineLbl.Text = "|";
            lineLbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // categoryLbl
            // 
            categoryLbl.AutoSize = true;
            categoryLbl.BackColor = SystemColors.MenuHighlight;
            categoryLbl.Dock = DockStyle.Right;
            categoryLbl.ForeColor = Color.White;
            categoryLbl.Location = new Point(139, 0);
            categoryLbl.Name = "categoryLbl";
            categoryLbl.Size = new Size(81, 20);
            categoryLbl.TabIndex = 0;
            categoryLbl.Text = "CATEGORY";
            categoryLbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // sdgLbl
            // 
            sdgLbl.AutoSize = true;
            sdgLbl.BackColor = SystemColors.MenuHighlight;
            sdgLbl.Dock = DockStyle.Right;
            sdgLbl.ForeColor = Color.White;
            sdgLbl.Location = new Point(47, 0);
            sdgLbl.Name = "sdgLbl";
            sdgLbl.Size = new Size(79, 20);
            sdgLbl.TabIndex = 2;
            sdgLbl.Text = "SDGLABEL";
            // 
            // topRightPanel
            // 
            topRightPanel.Controls.Add(sdgLbl);
            topRightPanel.Controls.Add(lineLbl);
            topRightPanel.Controls.Add(categoryLbl);
            topRightPanel.Dock = DockStyle.Fill;
            topRightPanel.Location = new Point(229, 3);
            topRightPanel.Name = "topRightPanel";
            topRightPanel.Size = new Size(220, 34);
            topRightPanel.TabIndex = 2;
            // 
            // formTbl
            // 
            formTbl.ColumnCount = 2;
            formTbl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            formTbl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            formTbl.Controls.Add(usernameLbl, 0, 0);
            formTbl.Controls.Add(topRightPanel, 1, 0);
            formTbl.Controls.Add(dateLbl, 1, 1);
            formTbl.Controls.Add(contentPanel, 0, 2);
            formTbl.Dock = DockStyle.Fill;
            formTbl.Location = new Point(0, 0);
            formTbl.Name = "formTbl";
            formTbl.RowCount = 3;
            formTbl.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            formTbl.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            formTbl.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            formTbl.Size = new Size(452, 244);
            formTbl.TabIndex = 0;
            // 
            // dateLbl
            // 
            dateLbl.AutoSize = true;
            dateLbl.Dock = DockStyle.Right;
            dateLbl.ForeColor = Color.White;
            dateLbl.Location = new Point(364, 40);
            dateLbl.Name = "dateLbl";
            dateLbl.Size = new Size(85, 20);
            dateLbl.TabIndex = 3;
            dateLbl.Text = "00-00-0000";
            // 
            // contentPanel
            // 
            formTbl.SetColumnSpan(contentPanel, 2);
            contentPanel.Controls.Add(titleLbl);
            contentPanel.Controls.Add(votesLbl);
            contentPanel.Dock = DockStyle.Fill;
            contentPanel.Location = new Point(3, 63);
            contentPanel.Name = "contentPanel";
            contentPanel.Size = new Size(446, 178);
            contentPanel.TabIndex = 4;
            // 
            // titleLbl
            // 
            titleLbl.AutoSize = true;
            titleLbl.Dock = DockStyle.Fill;
            titleLbl.ForeColor = Color.White;
            titleLbl.Location = new Point(0, 0);
            titleLbl.Name = "titleLbl";
            titleLbl.Size = new Size(44, 20);
            titleLbl.TabIndex = 1;
            titleLbl.Text = "TITLE";
            titleLbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // votesLbl
            // 
            votesLbl.AutoSize = true;
            votesLbl.Dock = DockStyle.Right;
            votesLbl.ForeColor = Color.White;
            votesLbl.Location = new Point(429, 0);
            votesLbl.Name = "votesLbl";
            votesLbl.Size = new Size(17, 20);
            votesLbl.TabIndex = 0;
            votesLbl.Text = "0";
            votesLbl.TextAlign = ContentAlignment.TopRight;
            // 
            // FormItemUC
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(formTbl);
            Name = "FormItemUC";
            Size = new Size(452, 244);
            Load += FormItemUC_Load;
            topRightPanel.ResumeLayout(false);
            topRightPanel.PerformLayout();
            formTbl.ResumeLayout(false);
            formTbl.PerformLayout();
            contentPanel.ResumeLayout(false);
            contentPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label usernameLbl;
        private Label lineLbl;
        private Label categoryLbl;
        private Label sdgLbl;
        private Panel topRightPanel;
        private TableLayoutPanel formTbl;
        private Label dateLbl;
        private Panel contentPanel;
        private Label titleLbl;
        private Label votesLbl;
    }
}
