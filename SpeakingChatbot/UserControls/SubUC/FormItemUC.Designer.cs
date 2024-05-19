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
            usernameLbl = new Label();
            topRightPanel = new Panel();
            categoryPic = new PictureBox();
            dateLbl = new Label();
            formTbl = new TableLayoutPanel();
            contentPanel = new Panel();
            titleLbl = new Label();
            votesLbl = new Label();
            topRightPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)categoryPic).BeginInit();
            formTbl.SuspendLayout();
            contentPanel.SuspendLayout();
            SuspendLayout();
            // 
            // usernameLbl
            // 
            usernameLbl.AutoSize = true;
            usernameLbl.Cursor = Cursors.IBeam;
            usernameLbl.Dock = DockStyle.Left;
            usernameLbl.ForeColor = SystemColors.Highlight;
            usernameLbl.Location = new Point(3, 0);
            usernameLbl.Name = "usernameLbl";
            usernameLbl.Size = new Size(86, 40);
            usernameLbl.TabIndex = 1;
            usernameLbl.Text = "USERNAME";
            usernameLbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // topRightPanel
            // 
            topRightPanel.Controls.Add(categoryPic);
            topRightPanel.Controls.Add(dateLbl);
            topRightPanel.Dock = DockStyle.Fill;
            topRightPanel.Location = new Point(356, 5);
            topRightPanel.Margin = new Padding(5);
            topRightPanel.Name = "topRightPanel";
            topRightPanel.Size = new Size(341, 30);
            topRightPanel.TabIndex = 2;
            // 
            // categoryPic
            // 
            categoryPic.Dock = DockStyle.Right;
            categoryPic.Image = Properties.Resources.guidetag;
            categoryPic.Location = new Point(131, 0);
            categoryPic.Margin = new Padding(3, 3, 10, 3);
            categoryPic.Name = "categoryPic";
            categoryPic.Size = new Size(125, 30);
            categoryPic.SizeMode = PictureBoxSizeMode.StretchImage;
            categoryPic.TabIndex = 0;
            categoryPic.TabStop = false;
            // 
            // dateLbl
            // 
            dateLbl.AutoSize = true;
            dateLbl.Dock = DockStyle.Right;
            dateLbl.ForeColor = Color.White;
            dateLbl.Location = new Point(256, 0);
            dateLbl.Margin = new Padding(10, 0, 3, 0);
            dateLbl.Name = "dateLbl";
            dateLbl.Size = new Size(85, 20);
            dateLbl.TabIndex = 3;
            dateLbl.Text = "00-00-0000";
            // 
            // formTbl
            // 
            formTbl.BackColor = Color.Transparent;
            formTbl.ColumnCount = 2;
            formTbl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            formTbl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            formTbl.Controls.Add(usernameLbl, 0, 0);
            formTbl.Controls.Add(topRightPanel, 1, 0);
            formTbl.Controls.Add(contentPanel, 0, 1);
            formTbl.Dock = DockStyle.Fill;
            formTbl.Location = new Point(0, 0);
            formTbl.Margin = new Padding(5);
            formTbl.Name = "formTbl";
            formTbl.RowCount = 2;
            formTbl.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            formTbl.RowStyles.Add(new RowStyle());
            formTbl.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            formTbl.Size = new Size(702, 122);
            formTbl.TabIndex = 0;
            // 
            // contentPanel
            // 
            contentPanel.AutoSize = true;
            contentPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            formTbl.SetColumnSpan(contentPanel, 2);
            contentPanel.Controls.Add(titleLbl);
            contentPanel.Controls.Add(votesLbl);
            contentPanel.Dock = DockStyle.Fill;
            contentPanel.Location = new Point(3, 43);
            contentPanel.Name = "contentPanel";
            contentPanel.Size = new Size(696, 76);
            contentPanel.TabIndex = 4;
            contentPanel.Click += contentPanel_Click;
            // 
            // titleLbl
            // 
            titleLbl.AutoSize = true;
            titleLbl.Cursor = Cursors.IBeam;
            titleLbl.Dock = DockStyle.Fill;
            titleLbl.ForeColor = Color.White;
            titleLbl.Location = new Point(0, 0);
            titleLbl.MaximumSize = new Size(500, 0);
            titleLbl.Name = "titleLbl";
            titleLbl.Size = new Size(500, 40);
            titleLbl.TabIndex = 1;
            titleLbl.Text = "TITLEeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeee";
            titleLbl.TextAlign = ContentAlignment.MiddleLeft;
            titleLbl.Click += titleLbl_Click;
            titleLbl.Resize += titleLbl_Resize;
            // 
            // votesLbl
            // 
            votesLbl.AutoSize = true;
            votesLbl.Dock = DockStyle.Right;
            votesLbl.ForeColor = Color.White;
            votesLbl.Location = new Point(679, 0);
            votesLbl.Name = "votesLbl";
            votesLbl.Size = new Size(17, 20);
            votesLbl.TabIndex = 0;
            votesLbl.Text = "0";
            votesLbl.TextAlign = ContentAlignment.TopRight;
            votesLbl.Resize += votesLbl_Resize;
            // 
            // FormItemUC
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(formTbl);
            Name = "FormItemUC";
            Size = new Size(702, 122);
            Load += FormItemUC_Load;
            topRightPanel.ResumeLayout(false);
            topRightPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)categoryPic).EndInit();
            formTbl.ResumeLayout(false);
            formTbl.PerformLayout();
            contentPanel.ResumeLayout(false);
            contentPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label usernameLbl;
        private Label categoryLbl;
        private Panel topRightPanel;
        private TableLayoutPanel formTbl;
        private Label dateLbl;
        private Panel contentPanel;
        private Label titleLbl;
        private Label votesLbl;
        private Panel sdgPanel;
        private PictureBox categoryPic;
        private Label lineLbl;
    }
}
