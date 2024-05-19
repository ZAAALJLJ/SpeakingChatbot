namespace SpeakingChatbot.UserControls.SubUC {
    partial class UsersUC {
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
            usersTbl = new TableLayoutPanel();
            user = new Label();
            status = new Label();
            usersTbl.SuspendLayout();
            SuspendLayout();
            // 
            // usersTbl
            // 
            usersTbl.BackColor = Color.RosyBrown;
            usersTbl.ColumnCount = 2;
            usersTbl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            usersTbl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            usersTbl.Controls.Add(user, 0, 0);
            usersTbl.Controls.Add(status, 1, 0);
            usersTbl.Dock = DockStyle.Fill;
            usersTbl.Location = new Point(0, 0);
            usersTbl.Name = "usersTbl";
            usersTbl.RowCount = 1;
            usersTbl.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            usersTbl.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            usersTbl.Size = new Size(468, 36);
            usersTbl.TabIndex = 0;
            usersTbl.Paint += usersTbl_Paint;
            // 
            // user
            // 
            user.AutoSize = true;
            user.Dock = DockStyle.Fill;
            user.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            user.Location = new Point(3, 0);
            user.Name = "user";
            user.Size = new Size(321, 36);
            user.TabIndex = 0;
            user.Text = "Public GC";
            user.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // status
            // 
            status.AutoSize = true;
            status.Dock = DockStyle.Fill;
            status.Location = new Point(330, 0);
            status.Name = "status";
            status.Size = new Size(135, 36);
            status.TabIndex = 1;
            status.Text = "Online";
            status.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Users
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(usersTbl);
            Name = "Users";
            Size = new Size(468, 36);
            usersTbl.ResumeLayout(false);
            usersTbl.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel usersTbl;
        private Label user;
        private Label status;
    }
}
