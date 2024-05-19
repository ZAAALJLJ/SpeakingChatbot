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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUC));
            formTbl = new TableLayoutPanel();
            bottomPanel = new Panel();
            submitBtn = new Button();
            topPanel = new Panel();
            content = new Label();
            panel1 = new Panel();
            backBtn = new PictureBox();
            titleLbl = new Label();
            commentPanel = new Panel();
            formTbl.SuspendLayout();
            bottomPanel.SuspendLayout();
            topPanel.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)backBtn).BeginInit();
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
            bottomPanel.Controls.Add(submitBtn);
            bottomPanel.Dock = DockStyle.Fill;
            bottomPanel.Location = new Point(13, 593);
            bottomPanel.Margin = new Padding(3, 10, 3, 3);
            bottomPanel.Name = "bottomPanel";
            bottomPanel.Size = new Size(865, 37);
            bottomPanel.TabIndex = 0;
            // 
            // submitBtn
            // 
            submitBtn.AutoSize = true;
            submitBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            submitBtn.Cursor = Cursors.Hand;
            submitBtn.Dock = DockStyle.Fill;
            submitBtn.Location = new Point(0, 0);
            submitBtn.Name = "submitBtn";
            submitBtn.Padding = new Padding(10, 0, 10, 0);
            submitBtn.Size = new Size(865, 37);
            submitBtn.TabIndex = 0;
            submitBtn.Text = "Open File";
            submitBtn.UseVisualStyleBackColor = true;
            submitBtn.Click += submitBtn_Click;
            // 
            // topPanel
            // 
            topPanel.AutoScroll = true;
            topPanel.BackColor = Color.Transparent;
            topPanel.Controls.Add(content);
            topPanel.Controls.Add(panel1);
            topPanel.Controls.Add(commentPanel);
            topPanel.Dock = DockStyle.Fill;
            topPanel.Location = new Point(13, 13);
            topPanel.Margin = new Padding(3, 3, 3, 10);
            topPanel.Name = "topPanel";
            topPanel.Size = new Size(865, 560);
            topPanel.TabIndex = 1;
            // 
            // content
            // 
            content.Cursor = Cursors.IBeam;
            content.Dock = DockStyle.Fill;
            content.ForeColor = Color.White;
            content.Location = new Point(0, 81);
            content.Name = "content";
            content.Size = new Size(865, 479);
            content.TabIndex = 1;
            content.Text = resources.GetString("content.Text");
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel1.Controls.Add(backBtn);
            panel1.Controls.Add(titleLbl);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(865, 81);
            panel1.TabIndex = 4;
            // 
            // backBtn
            // 
            backBtn.Cursor = Cursors.Hand;
            backBtn.Dock = DockStyle.Right;
            backBtn.Image = Properties.Resources.backbutton;
            backBtn.Location = new Point(737, 0);
            backBtn.MaximumSize = new Size(128, 78);
            backBtn.Name = "backBtn";
            backBtn.Size = new Size(128, 78);
            backBtn.SizeMode = PictureBoxSizeMode.StretchImage;
            backBtn.TabIndex = 1;
            backBtn.TabStop = false;
            backBtn.Click += backBtn_Click;
            // 
            // titleLbl
            // 
            titleLbl.AutoSize = true;
            titleLbl.Cursor = Cursors.IBeam;
            titleLbl.Dock = DockStyle.Fill;
            titleLbl.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point);
            titleLbl.ForeColor = Color.White;
            titleLbl.Location = new Point(0, 0);
            titleLbl.MaximumSize = new Size(700, 0);
            titleLbl.Name = "titleLbl";
            titleLbl.Size = new Size(171, 81);
            titleLbl.TabIndex = 0;
            titleLbl.Text = "TITLE";
            titleLbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // commentPanel
            // 
            commentPanel.AutoSize = true;
            commentPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            commentPanel.Dock = DockStyle.Top;
            commentPanel.Location = new Point(0, 0);
            commentPanel.Name = "commentPanel";
            commentPanel.Size = new Size(865, 0);
            commentPanel.TabIndex = 3;
            // 
            // FormUC
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            AutoSize = true;
            BackgroundImage = Properties.Resources.upload;
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(formTbl);
            DoubleBuffered = true;
            Name = "FormUC";
            Padding = new Padding(20);
            Size = new Size(931, 683);
            Load += FormUC_Load;
            Resize += FormUC_Resize;
            formTbl.ResumeLayout(false);
            bottomPanel.ResumeLayout(false);
            bottomPanel.PerformLayout();
            topPanel.ResumeLayout(false);
            topPanel.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)backBtn).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel formTbl;
        private Panel topPanel;
        private Label titleLbl;
        private Label content;
        private Panel commentPanel;
        private Panel bottomPanel;
        private Button submitBtn;
        private Panel panel1;
        private PictureBox backBtn;
    }
}
