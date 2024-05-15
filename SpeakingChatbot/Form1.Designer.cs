namespace SpeakingChatbot {
    public partial class Form1 {
        private System.ComponentModel.IContainer components = null;

        public void SetPictureBoxImage(Image image) {
            pictureBox1.Image = image;
        }
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox1 = new PictureBox();
            button1 = new Button();
            richTextBox1 = new RichTextBox();
            textBox1 = new TextBox();
            button2 = new Button();
            chatBtn = new Button();
            chatContainer = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(627, 263);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(218, 187);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.Location = new Point(393, 419);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(86, 31);
            button1.TabIndex = 3;
            button1.Text = "Read";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(235, 192);
            richTextBox1.Margin = new Padding(3, 4, 3, 4);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(397, 217);
            richTextBox1.TabIndex = 4;
            richTextBox1.Text = "";
            richTextBox1.TextChanged += richTextBox1_TextChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(235, 45);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(397, 27);
            textBox1.TabIndex = 5;
            // 
            // button2
            // 
            button2.Location = new Point(239, 84);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(86, 31);
            button2.TabIndex = 6;
            button2.Text = "Enter";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // chatBtn
            // 
            chatBtn.Location = new Point(11, 12);
            chatBtn.Name = "chatBtn";
            chatBtn.Size = new Size(94, 29);
            chatBtn.TabIndex = 7;
            chatBtn.Text = "Open Chat";
            chatBtn.UseVisualStyleBackColor = true;
            chatBtn.Click += chatBtn_Click;
            // 
            // chatContainer
            // 
            chatContainer.Location = new Point(11, 45);
            chatContainer.Name = "chatContainer";
            chatContainer.Size = new Size(776, 405);
            chatContainer.TabIndex = 8;
            chatContainer.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 451);
            Controls.Add(chatBtn);
            Controls.Add(button2);
            Controls.Add(textBox1);
            Controls.Add(richTextBox1);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Controls.Add(chatContainer);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            Text = "Speaking Chatbot";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public PictureBox pictureBox1;
        private Button button1;
        private RichTextBox richTextBox1;
        private TextBox textBox1;
        private Button button2;
        private Button chatBtn;
        private Panel chatContainer;
    }
}