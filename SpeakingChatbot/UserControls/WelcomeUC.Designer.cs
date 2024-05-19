using SpeakingChatbot;
using System.Windows.Forms;

namespace SpeakingChatbot.UserControls {
    partial class WelcomeUC {
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
            welcomeTblPanel = new TableLayoutPanel();
            titleTbl = new TableLayoutPanel();
            titleLbl = new PictureBox();
            continueTbl = new TableLayoutPanel();
            continueLbl = new PictureBox();
            welcomeTblPanel.SuspendLayout();
            titleTbl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)titleLbl).BeginInit();
            continueTbl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)continueLbl).BeginInit();
            SuspendLayout();
            // 
            // welcomeTblPanel
            // 
            welcomeTblPanel.AutoSize = true;
            welcomeTblPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            welcomeTblPanel.BackColor = Color.Transparent;
            welcomeTblPanel.ColumnCount = 1;
            welcomeTblPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            welcomeTblPanel.Controls.Add(titleTbl, 0, 0);
            welcomeTblPanel.Controls.Add(continueTbl, 0, 2);
            welcomeTblPanel.Dock = DockStyle.Fill;
            welcomeTblPanel.Location = new Point(0, 0);
            welcomeTblPanel.Name = "welcomeTblPanel";
            welcomeTblPanel.RowCount = 3;
            welcomeTblPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            welcomeTblPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 45F));
            welcomeTblPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            welcomeTblPanel.Size = new Size(1515, 600);
            welcomeTblPanel.TabIndex = 4;
            welcomeTblPanel.Click += continueTbl_Click;
            // 
            // titleTbl
            // 
            titleTbl.AutoSize = true;
            titleTbl.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            titleTbl.ColumnCount = 3;
            titleTbl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 18F));
            titleTbl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 64F));
            titleTbl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 18F));
            titleTbl.Controls.Add(titleLbl, 1, 1);
            titleTbl.Dock = DockStyle.Fill;
            titleTbl.Location = new Point(0, 0);
            titleTbl.Margin = new Padding(0);
            titleTbl.Name = "titleTbl";
            titleTbl.RowCount = 3;
            titleTbl.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            titleTbl.RowStyles.Add(new RowStyle(SizeType.Percent, 70F));
            titleTbl.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            titleTbl.Size = new Size(1515, 150);
            titleTbl.TabIndex = 3;
            titleTbl.Click += continueTbl_Click;
            // 
            // titleLbl
            // 
            titleLbl.Dock = DockStyle.Fill;
            titleLbl.Image = Properties.Resources.CHAVATARtitle;
            titleLbl.Location = new Point(272, 22);
            titleLbl.Margin = new Padding(0);
            titleLbl.Name = "titleLbl";
            titleLbl.Size = new Size(969, 105);
            titleLbl.SizeMode = PictureBoxSizeMode.StretchImage;
            titleLbl.TabIndex = 0;
            titleLbl.TabStop = false;
            titleLbl.Click += continueTbl_Click;
            // 
            // continueTbl
            // 
            continueTbl.ColumnCount = 3;
            continueTbl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16F));
            continueTbl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 68F));
            continueTbl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16F));
            continueTbl.Controls.Add(continueLbl, 1, 1);
            continueTbl.Dock = DockStyle.Fill;
            continueTbl.Location = new Point(0, 420);
            continueTbl.Margin = new Padding(0);
            continueTbl.Name = "continueTbl";
            continueTbl.RowCount = 3;
            continueTbl.RowStyles.Add(new RowStyle(SizeType.Percent, 35F));
            continueTbl.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            continueTbl.RowStyles.Add(new RowStyle(SizeType.Percent, 35F));
            continueTbl.Size = new Size(1515, 180);
            continueTbl.TabIndex = 4;
            continueTbl.Click += continueTbl_Click;
            // 
            // continueLbl
            // 
            continueLbl.Dock = DockStyle.Fill;
            continueLbl.Image = Properties.Resources.clicktocontinue;
            continueLbl.Location = new Point(242, 63);
            continueLbl.Margin = new Padding(0);
            continueLbl.Name = "continueLbl";
            continueLbl.Size = new Size(1030, 54);
            continueLbl.SizeMode = PictureBoxSizeMode.StretchImage;
            continueLbl.TabIndex = 0;
            continueLbl.TabStop = false;
            continueLbl.Click += continueTbl_Click;
            // 
            // WelcomeUC
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackgroundImage = Properties.Resources.start1;
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(welcomeTblPanel);
            DoubleBuffered = true;
            Name = "WelcomeUC";
            Size = new Size(1515, 600);
            welcomeTblPanel.ResumeLayout(false);
            welcomeTblPanel.PerformLayout();
            titleTbl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)titleLbl).EndInit();
            continueTbl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)continueLbl).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TableLayoutPanel welcomeTblPanel;
        private TableLayoutPanel titleTbl;
        private PictureBox titleLbl;
        private TableLayoutPanel continueTbl;
        private PictureBox continueLbl;
    }
}
