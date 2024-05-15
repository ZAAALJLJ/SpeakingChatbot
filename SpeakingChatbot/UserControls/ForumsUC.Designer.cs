namespace SpeakingChatbot.UserControls {
    partial class ForumsUC {
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
            forumsTbl = new TableLayoutPanel();
            forumsLeftTbl = new TableLayoutPanel();
            uploadBtn = new PictureBox();
            filterTbl = new TableLayoutPanel();
            clearBtn = new PictureBox();
            applyBtn = new PictureBox();
            filterBtnTbl = new TableLayoutPanel();
            sdgBtn = new PictureBox();
            categoryBtn = new PictureBox();
            sdgPanel = new Panel();
            filterLblTbl = new TableLayoutPanel();
            filterLbl = new PictureBox();
            forumsRightTbl = new TableLayoutPanel();
            titleTbl = new TableLayoutPanel();
            forumsLbl = new PictureBox();
            backBtn = new PictureBox();
            forumsPanel = new Panel();
            forumsTbl.SuspendLayout();
            forumsLeftTbl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)uploadBtn).BeginInit();
            filterTbl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)clearBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)applyBtn).BeginInit();
            filterBtnTbl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)sdgBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)categoryBtn).BeginInit();
            filterLblTbl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)filterLbl).BeginInit();
            forumsRightTbl.SuspendLayout();
            titleTbl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)forumsLbl).BeginInit();
            ((System.ComponentModel.ISupportInitialize)backBtn).BeginInit();
            SuspendLayout();
            // 
            // forumsTbl
            // 
            forumsTbl.AutoSize = true;
            forumsTbl.ColumnCount = 4;
            forumsTbl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 3F));
            forumsTbl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 24F));
            forumsTbl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 3F));
            forumsTbl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            forumsTbl.Controls.Add(forumsLeftTbl, 1, 0);
            forumsTbl.Controls.Add(forumsRightTbl, 3, 0);
            forumsTbl.Dock = DockStyle.Fill;
            forumsTbl.Location = new Point(0, 0);
            forumsTbl.Name = "forumsTbl";
            forumsTbl.RowCount = 1;
            forumsTbl.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            forumsTbl.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            forumsTbl.Size = new Size(960, 540);
            forumsTbl.TabIndex = 0;
            forumsTbl.Paint += forumsTbl_Paint;
            // 
            // forumsLeftTbl
            // 
            forumsLeftTbl.BackColor = Color.FromArgb(200, 0, 0, 0);
            forumsLeftTbl.ColumnCount = 1;
            forumsLeftTbl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            forumsLeftTbl.Controls.Add(uploadBtn, 0, 1);
            forumsLeftTbl.Controls.Add(filterTbl, 0, 0);
            forumsLeftTbl.Dock = DockStyle.Fill;
            forumsLeftTbl.Location = new Point(31, 8);
            forumsLeftTbl.Margin = new Padding(3, 8, 3, 8);
            forumsLeftTbl.Name = "forumsLeftTbl";
            forumsLeftTbl.RowCount = 2;
            forumsLeftTbl.RowStyles.Add(new RowStyle(SizeType.Percent, 88F));
            forumsLeftTbl.RowStyles.Add(new RowStyle(SizeType.Percent, 12F));
            forumsLeftTbl.Size = new Size(224, 524);
            forumsLeftTbl.TabIndex = 0;
            // 
            // uploadBtn
            // 
            uploadBtn.Dock = DockStyle.Fill;
            uploadBtn.ErrorImage = Properties.Resources.uploadbutton;
            uploadBtn.Image = Properties.Resources.uploadbutton;
            uploadBtn.InitialImage = Properties.Resources.uploadbutton;
            uploadBtn.Location = new Point(3, 464);
            uploadBtn.Name = "uploadBtn";
            uploadBtn.Size = new Size(218, 57);
            uploadBtn.SizeMode = PictureBoxSizeMode.StretchImage;
            uploadBtn.TabIndex = 0;
            uploadBtn.TabStop = false;
            uploadBtn.Click += uploadBtn_Click;
            // 
            // filterTbl
            // 
            filterTbl.AutoSize = true;
            filterTbl.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            filterTbl.BackColor = Color.Transparent;
            filterTbl.ColumnCount = 1;
            filterTbl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            filterTbl.Controls.Add(clearBtn, 0, 4);
            filterTbl.Controls.Add(applyBtn, 0, 3);
            filterTbl.Controls.Add(filterBtnTbl, 0, 1);
            filterTbl.Controls.Add(sdgPanel, 0, 2);
            filterTbl.Controls.Add(filterLblTbl, 0, 0);
            filterTbl.Dock = DockStyle.Fill;
            filterTbl.Location = new Point(3, 3);
            filterTbl.Name = "filterTbl";
            filterTbl.RowCount = 5;
            filterTbl.RowStyles.Add(new RowStyle(SizeType.Percent, 8F));
            filterTbl.RowStyles.Add(new RowStyle(SizeType.Percent, 9F));
            filterTbl.RowStyles.Add(new RowStyle(SizeType.Percent, 67F));
            filterTbl.RowStyles.Add(new RowStyle(SizeType.Percent, 8F));
            filterTbl.RowStyles.Add(new RowStyle(SizeType.Percent, 8F));
            filterTbl.Size = new Size(218, 455);
            filterTbl.TabIndex = 1;
            // 
            // clearBtn
            // 
            clearBtn.Dock = DockStyle.Fill;
            clearBtn.ErrorImage = Properties.Resources.clear_button;
            clearBtn.Image = Properties.Resources.clear_button;
            clearBtn.InitialImage = Properties.Resources.clear_button;
            clearBtn.Location = new Point(3, 419);
            clearBtn.Name = "clearBtn";
            clearBtn.Size = new Size(212, 33);
            clearBtn.SizeMode = PictureBoxSizeMode.StretchImage;
            clearBtn.TabIndex = 0;
            clearBtn.TabStop = false;
            // 
            // applyBtn
            // 
            applyBtn.Dock = DockStyle.Fill;
            applyBtn.ErrorImage = Properties.Resources.apply_button;
            applyBtn.Image = Properties.Resources.apply_button;
            applyBtn.InitialImage = Properties.Resources.apply_button;
            applyBtn.Location = new Point(3, 383);
            applyBtn.Name = "applyBtn";
            applyBtn.Size = new Size(212, 30);
            applyBtn.SizeMode = PictureBoxSizeMode.StretchImage;
            applyBtn.TabIndex = 1;
            applyBtn.TabStop = false;
            // 
            // filterBtnTbl
            // 
            filterBtnTbl.BackColor = Color.Transparent;
            filterBtnTbl.ColumnCount = 2;
            filterBtnTbl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            filterBtnTbl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            filterBtnTbl.Controls.Add(sdgBtn, 0, 1);
            filterBtnTbl.Controls.Add(categoryBtn, 1, 1);
            filterBtnTbl.Dock = DockStyle.Fill;
            filterBtnTbl.Location = new Point(3, 39);
            filterBtnTbl.Name = "filterBtnTbl";
            filterBtnTbl.RowCount = 3;
            filterBtnTbl.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            filterBtnTbl.RowStyles.Add(new RowStyle(SizeType.Percent, 80F));
            filterBtnTbl.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            filterBtnTbl.Size = new Size(212, 34);
            filterBtnTbl.TabIndex = 3;
            // 
            // sdgBtn
            // 
            sdgBtn.Dock = DockStyle.Fill;
            sdgBtn.Image = Properties.Resources.sdg;
            sdgBtn.Location = new Point(3, 6);
            sdgBtn.Name = "sdgBtn";
            sdgBtn.Size = new Size(100, 21);
            sdgBtn.SizeMode = PictureBoxSizeMode.StretchImage;
            sdgBtn.TabIndex = 2;
            sdgBtn.TabStop = false;
            // 
            // categoryBtn
            // 
            categoryBtn.Dock = DockStyle.Fill;
            categoryBtn.Image = Properties.Resources.categories;
            categoryBtn.Location = new Point(109, 6);
            categoryBtn.Name = "categoryBtn";
            categoryBtn.Size = new Size(100, 21);
            categoryBtn.SizeMode = PictureBoxSizeMode.StretchImage;
            categoryBtn.TabIndex = 3;
            categoryBtn.TabStop = false;
            // 
            // sdgPanel
            // 
            sdgPanel.BackColor = Color.Transparent;
            sdgPanel.Dock = DockStyle.Fill;
            sdgPanel.Location = new Point(0, 76);
            sdgPanel.Margin = new Padding(0);
            sdgPanel.Name = "sdgPanel";
            sdgPanel.Size = new Size(218, 304);
            sdgPanel.TabIndex = 4;
            // 
            // filterLblTbl
            // 
            filterLblTbl.ColumnCount = 3;
            filterLblTbl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            filterLblTbl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
            filterLblTbl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            filterLblTbl.Controls.Add(filterLbl, 1, 1);
            filterLblTbl.Location = new Point(3, 3);
            filterLblTbl.Name = "filterLblTbl";
            filterLblTbl.RowCount = 3;
            filterLblTbl.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            filterLblTbl.RowStyles.Add(new RowStyle(SizeType.Percent, 90F));
            filterLblTbl.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            filterLblTbl.Size = new Size(212, 30);
            filterLblTbl.TabIndex = 5;
            // 
            // filterLbl
            // 
            filterLbl.Dock = DockStyle.Fill;
            filterLbl.Image = Properties.Resources.filter;
            filterLbl.Location = new Point(24, 4);
            filterLbl.Name = "filterLbl";
            filterLbl.Size = new Size(163, 21);
            filterLbl.SizeMode = PictureBoxSizeMode.StretchImage;
            filterLbl.TabIndex = 0;
            filterLbl.TabStop = false;
            // 
            // forumsRightTbl
            // 
            forumsRightTbl.ColumnCount = 2;
            forumsRightTbl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 97F));
            forumsRightTbl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 3F));
            forumsRightTbl.Controls.Add(titleTbl, 0, 1);
            forumsRightTbl.Controls.Add(forumsPanel, 0, 2);
            forumsRightTbl.Dock = DockStyle.Fill;
            forumsRightTbl.Location = new Point(286, 0);
            forumsRightTbl.Margin = new Padding(0);
            forumsRightTbl.Name = "forumsRightTbl";
            forumsRightTbl.RowCount = 4;
            forumsRightTbl.RowStyles.Add(new RowStyle(SizeType.Percent, 2F));
            forumsRightTbl.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            forumsRightTbl.RowStyles.Add(new RowStyle(SizeType.Percent, 80F));
            forumsRightTbl.RowStyles.Add(new RowStyle(SizeType.Percent, 3F));
            forumsRightTbl.Size = new Size(674, 540);
            forumsRightTbl.TabIndex = 1;
            // 
            // titleTbl
            // 
            titleTbl.ColumnCount = 4;
            titleTbl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 3F));
            titleTbl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45F));
            titleTbl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 32F));
            titleTbl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            titleTbl.Controls.Add(forumsLbl, 1, 1);
            titleTbl.Controls.Add(backBtn, 3, 1);
            titleTbl.Dock = DockStyle.Fill;
            titleTbl.Location = new Point(0, 10);
            titleTbl.Margin = new Padding(0);
            titleTbl.Name = "titleTbl";
            titleTbl.RowCount = 2;
            titleTbl.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            titleTbl.RowStyles.Add(new RowStyle(SizeType.Percent, 80F));
            titleTbl.Size = new Size(653, 81);
            titleTbl.TabIndex = 0;
            // 
            // forumsLbl
            // 
            forumsLbl.Dock = DockStyle.Fill;
            forumsLbl.Image = Properties.Resources.forumsLbl;
            forumsLbl.Location = new Point(22, 19);
            forumsLbl.Name = "forumsLbl";
            forumsLbl.Size = new Size(287, 59);
            forumsLbl.SizeMode = PictureBoxSizeMode.StretchImage;
            forumsLbl.TabIndex = 0;
            forumsLbl.TabStop = false;
            // 
            // backBtn
            // 
            backBtn.Dock = DockStyle.Fill;
            backBtn.Image = Properties.Resources.backbutton;
            backBtn.Location = new Point(523, 19);
            backBtn.Name = "backBtn";
            backBtn.Size = new Size(127, 59);
            backBtn.SizeMode = PictureBoxSizeMode.StretchImage;
            backBtn.TabIndex = 1;
            backBtn.TabStop = false;
            backBtn.Click += backBtn_Click;
            // 
            // forumsPanel
            // 
            forumsPanel.AutoSize = true;
            forumsPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            forumsPanel.BackColor = Color.FromArgb(200, 0, 0, 0);
            forumsPanel.Dock = DockStyle.Fill;
            forumsPanel.Location = new Point(0, 91);
            forumsPanel.Margin = new Padding(0);
            forumsPanel.Name = "forumsPanel";
            forumsPanel.Size = new Size(653, 432);
            forumsPanel.TabIndex = 1;
            // 
            // ForumsUC
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            BackgroundImage = Properties.Resources.forums;
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(forumsTbl);
            DoubleBuffered = true;
            ForeColor = SystemColors.ControlText;
            Name = "ForumsUC";
            Size = new Size(960, 540);
            forumsTbl.ResumeLayout(false);
            forumsLeftTbl.ResumeLayout(false);
            forumsLeftTbl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)uploadBtn).EndInit();
            filterTbl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)clearBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)applyBtn).EndInit();
            filterBtnTbl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)sdgBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)categoryBtn).EndInit();
            filterLblTbl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)filterLbl).EndInit();
            forumsRightTbl.ResumeLayout(false);
            forumsRightTbl.PerformLayout();
            titleTbl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)forumsLbl).EndInit();
            ((System.ComponentModel.ISupportInitialize)backBtn).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel forumsTbl;
        private TableLayoutPanel forumsLeftTbl;
        private PictureBox uploadBtn;
        private TableLayoutPanel filterTbl;
        private PictureBox clearBtn;
        private PictureBox applyBtn;
        private TableLayoutPanel filterBtnTbl;
        private Panel sdgPanel;
        private TableLayoutPanel forumsRightTbl;
        private TableLayoutPanel titleTbl;
        private Panel forumsPanel;
        private PictureBox sdgBtn;
        private PictureBox categoryBtn;
        private TableLayoutPanel filterLblTbl;
        private PictureBox filterLbl;
        private PictureBox forumsLbl;
        private PictureBox backBtn;
    }
}
