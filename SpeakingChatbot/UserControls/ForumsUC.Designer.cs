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
            forumsTbl = new TableLayoutPanel();
            filterTbl = new TableLayoutPanel();
            clearBtn = new PictureBox();
            applyBtn = new PictureBox();
            filterBtnTbl = new TableLayoutPanel();
            sdgBtn = new PictureBox();
            categoryBtn = new PictureBox();
            filterLblTbl = new TableLayoutPanel();
            filterLbl = new PictureBox();
            sdgCatPanel = new Panel();
            forumsRightTbl = new TableLayoutPanel();
            titleTbl = new TableLayoutPanel();
            forumsLbl = new PictureBox();
            backBtn = new PictureBox();
            formTbl = new TableLayoutPanel();
            formPanel = new Panel();
            uploadBtn = new PictureBox();
            forumsTbl.SuspendLayout();
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
            formTbl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)uploadBtn).BeginInit();
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
            forumsTbl.Controls.Add(filterTbl, 1, 0);
            forumsTbl.Controls.Add(forumsRightTbl, 3, 0);
            forumsTbl.Dock = DockStyle.Fill;
            forumsTbl.Location = new Point(0, 0);
            forumsTbl.Name = "forumsTbl";
            forumsTbl.RowCount = 1;
            forumsTbl.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            forumsTbl.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            forumsTbl.Size = new Size(960, 540);
            forumsTbl.TabIndex = 0;
            // 
            // filterTbl
            // 
            filterTbl.AutoSize = true;
            filterTbl.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            filterTbl.BackColor = Color.FromArgb(200, 0, 0, 0);
            filterTbl.ColumnCount = 1;
            filterTbl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            filterTbl.Controls.Add(clearBtn, 0, 4);
            filterTbl.Controls.Add(applyBtn, 0, 3);
            filterTbl.Controls.Add(filterBtnTbl, 0, 1);
            filterTbl.Controls.Add(filterLblTbl, 0, 0);
            filterTbl.Controls.Add(sdgCatPanel, 0, 2);
            filterTbl.Dock = DockStyle.Fill;
            filterTbl.Location = new Point(31, 3);
            filterTbl.Name = "filterTbl";
            filterTbl.RowCount = 5;
            filterTbl.RowStyles.Add(new RowStyle(SizeType.Percent, 8F));
            filterTbl.RowStyles.Add(new RowStyle(SizeType.Percent, 9F));
            filterTbl.RowStyles.Add(new RowStyle(SizeType.Percent, 67F));
            filterTbl.RowStyles.Add(new RowStyle(SizeType.Percent, 8F));
            filterTbl.RowStyles.Add(new RowStyle(SizeType.Percent, 8F));
            filterTbl.Size = new Size(224, 534);
            filterTbl.TabIndex = 1;
            // 
            // clearBtn
            // 
            clearBtn.Cursor = Cursors.Hand;
            clearBtn.Dock = DockStyle.Fill;
            clearBtn.ErrorImage = Properties.Resources.clear_button;
            clearBtn.Image = Properties.Resources.clear_button;
            clearBtn.InitialImage = Properties.Resources.clear_button;
            clearBtn.Location = new Point(3, 492);
            clearBtn.Name = "clearBtn";
            clearBtn.Size = new Size(218, 39);
            clearBtn.SizeMode = PictureBoxSizeMode.StretchImage;
            clearBtn.TabIndex = 0;
            clearBtn.TabStop = false;
            // 
            // applyBtn
            // 
            applyBtn.Cursor = Cursors.Hand;
            applyBtn.Dock = DockStyle.Fill;
            applyBtn.ErrorImage = Properties.Resources.apply_button;
            applyBtn.Image = Properties.Resources.apply_button;
            applyBtn.InitialImage = Properties.Resources.apply_button;
            applyBtn.Location = new Point(3, 450);
            applyBtn.Name = "applyBtn";
            applyBtn.Size = new Size(218, 36);
            applyBtn.SizeMode = PictureBoxSizeMode.StretchImage;
            applyBtn.TabIndex = 1;
            applyBtn.TabStop = false;
            applyBtn.Click += applyBtn_Click;
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
            filterBtnTbl.Location = new Point(3, 45);
            filterBtnTbl.Name = "filterBtnTbl";
            filterBtnTbl.RowCount = 3;
            filterBtnTbl.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            filterBtnTbl.RowStyles.Add(new RowStyle(SizeType.Percent, 80F));
            filterBtnTbl.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            filterBtnTbl.Size = new Size(218, 42);
            filterBtnTbl.TabIndex = 3;
            // 
            // sdgBtn
            // 
            sdgBtn.Cursor = Cursors.Hand;
            sdgBtn.Dock = DockStyle.Fill;
            sdgBtn.Image = Properties.Resources.sdg;
            sdgBtn.Location = new Point(3, 7);
            sdgBtn.Name = "sdgBtn";
            sdgBtn.Size = new Size(103, 27);
            sdgBtn.SizeMode = PictureBoxSizeMode.StretchImage;
            sdgBtn.TabIndex = 2;
            sdgBtn.TabStop = false;
            sdgBtn.Click += sdgBtn_Click;
            // 
            // categoryBtn
            // 
            categoryBtn.Cursor = Cursors.Hand;
            categoryBtn.Dock = DockStyle.Fill;
            categoryBtn.Image = Properties.Resources.categories;
            categoryBtn.Location = new Point(112, 7);
            categoryBtn.Name = "categoryBtn";
            categoryBtn.Size = new Size(103, 27);
            categoryBtn.SizeMode = PictureBoxSizeMode.StretchImage;
            categoryBtn.TabIndex = 3;
            categoryBtn.TabStop = false;
            categoryBtn.Click += categoryBtn_Click;
            // 
            // filterLblTbl
            // 
            filterLblTbl.BackColor = Color.Transparent;
            filterLblTbl.ColumnCount = 3;
            filterLblTbl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            filterLblTbl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
            filterLblTbl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            filterLblTbl.Controls.Add(filterLbl, 1, 1);
            filterLblTbl.Dock = DockStyle.Fill;
            filterLblTbl.Location = new Point(3, 3);
            filterLblTbl.Name = "filterLblTbl";
            filterLblTbl.RowCount = 3;
            filterLblTbl.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            filterLblTbl.RowStyles.Add(new RowStyle(SizeType.Percent, 90F));
            filterLblTbl.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            filterLblTbl.Size = new Size(218, 36);
            filterLblTbl.TabIndex = 5;
            // 
            // filterLbl
            // 
            filterLbl.Dock = DockStyle.Fill;
            filterLbl.Image = Properties.Resources.filter;
            filterLbl.Location = new Point(24, 4);
            filterLbl.Name = "filterLbl";
            filterLbl.Size = new Size(168, 26);
            filterLbl.SizeMode = PictureBoxSizeMode.StretchImage;
            filterLbl.TabIndex = 0;
            filterLbl.TabStop = false;
            // 
            // sdgCatPanel
            // 
            sdgCatPanel.Dock = DockStyle.Fill;
            sdgCatPanel.Location = new Point(3, 93);
            sdgCatPanel.Name = "sdgCatPanel";
            sdgCatPanel.Size = new Size(218, 351);
            sdgCatPanel.TabIndex = 6;
            // 
            // forumsRightTbl
            // 
            forumsRightTbl.ColumnCount = 2;
            forumsRightTbl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 97F));
            forumsRightTbl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 3F));
            forumsRightTbl.Controls.Add(titleTbl, 0, 1);
            forumsRightTbl.Controls.Add(formTbl, 0, 2);
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
            backBtn.Cursor = Cursors.Hand;
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
            // formTbl
            // 
            formTbl.BackColor = Color.FromArgb(200, 0, 0, 0);
            formTbl.ColumnCount = 2;
            formTbl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
            formTbl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            formTbl.Controls.Add(formPanel, 0, 1);
            formTbl.Controls.Add(uploadBtn, 1, 0);
            formTbl.Dock = DockStyle.Fill;
            formTbl.Location = new Point(3, 94);
            formTbl.Name = "formTbl";
            formTbl.RowCount = 2;
            formTbl.RowStyles.Add(new RowStyle(SizeType.Percent, 12F));
            formTbl.RowStyles.Add(new RowStyle(SizeType.Percent, 88F));
            formTbl.Size = new Size(647, 426);
            formTbl.TabIndex = 1;
            // 
            // formPanel
            // 
            formPanel.AutoScroll = true;
            formTbl.SetColumnSpan(formPanel, 2);
            formPanel.Dock = DockStyle.Fill;
            formPanel.Location = new Point(3, 54);
            formPanel.Name = "formPanel";
            formPanel.Size = new Size(641, 369);
            formPanel.TabIndex = 0;
            // 
            // uploadBtn
            // 
            uploadBtn.BackColor = Color.Transparent;
            uploadBtn.Cursor = Cursors.Hand;
            uploadBtn.Dock = DockStyle.Fill;
            uploadBtn.Image = Properties.Resources.uploadbutton;
            uploadBtn.Location = new Point(520, 3);
            uploadBtn.Name = "uploadBtn";
            uploadBtn.Size = new Size(124, 45);
            uploadBtn.SizeMode = PictureBoxSizeMode.StretchImage;
            uploadBtn.TabIndex = 1;
            uploadBtn.TabStop = false;
            uploadBtn.Click += uploadBtn_Click;
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
            forumsTbl.PerformLayout();
            filterTbl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)clearBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)applyBtn).EndInit();
            filterBtnTbl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)sdgBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)categoryBtn).EndInit();
            filterLblTbl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)filterLbl).EndInit();
            forumsRightTbl.ResumeLayout(false);
            titleTbl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)forumsLbl).EndInit();
            ((System.ComponentModel.ISupportInitialize)backBtn).EndInit();
            formTbl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)uploadBtn).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel forumsTbl;
        private TableLayoutPanel forumsRightTbl;
        private TableLayoutPanel titleTbl;
        private PictureBox forumsLbl;
        private PictureBox backBtn;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel filterTbl;
        private PictureBox clearBtn;
        private PictureBox applyBtn;
        private TableLayoutPanel filterBtnTbl;
        private PictureBox sdgBtn;
        private PictureBox categoryBtn;
        private TableLayoutPanel filterLblTbl;
        private PictureBox filterLbl;
        private Panel sdgCatPanel;
        private TableLayoutPanel formTbl;
        private Panel formPanel;
        private PictureBox uploadBtn;
    }
}
