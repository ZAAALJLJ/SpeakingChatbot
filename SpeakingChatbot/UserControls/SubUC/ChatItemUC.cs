using static System.Net.Mime.MediaTypeNames;
using System.Drawing;
using NAudio.Gui;
using System.Windows.Forms;

namespace SpeakingChatbot.UserControls.SubUC {
    public partial class ChatItemUC : UserControl {

        string text = null;

        public IChatModel ChatModel { get; set; }

        public ChatItemUC() {
            InitializeComponent();
        }

        public ChatItemUC(IChatModel chatModel) {
            InitializeComponent();

            ChatModel = chatModel;

            chatTbl.Controls.Clear();

            // receiver
            if (ChatModel.Inbound) {
                chatTbl.Controls.Add(chatMsg, 1, 0);
                chatMsg.BackColor = SystemColors.AppWorkspace;
                chatMsg.Dock = DockStyle.Left;

                // picture
                // profilePic.Image = Properties.Resources.forumicon;
                chatTbl.Controls.Add(profilePic, 0, 0);
            }
            // sender
            else {
                chatTbl.Controls.Add(chatMsg, 2, 0);
                chatMsg.BackColor = SystemColors.ActiveCaption;
                chatMsg.Dock = DockStyle.Right;
            }

            switch (chatModel.Type) {
                case "text":
                    var textMode = ChatModel as TextChatModel;
                    chatMsg.Text = textMode.Body.Trim();
                    break;
                case "image":
                    break;
                case "attachment":
                    break;
                default:
                    break;
            }
        }

        public void ResizeBubbles(int maxwidth) {
            SuspendLayout();

            var textmodel = ChatModel as TextChatModel;
            //Ah, this is hell. Alright, so the implementation for this is similar to the image one, except the width can't be automatically calculated. Instead, it
            //has to be calculated through the size and length of the text. See TextChange().
            string body = textmodel.Body;
            TextChange(chatMsg.Text);

            ResumeLayout();

            void TextChange(string body) {
                int fontheight = chatMsg.Font.Height;
                var gfx = this.CreateGraphics();
                int lines = 1;
                double stringwidth = gfx.MeasureString(body, chatMsg.Font).Width;

                //The system is as follows. The box width can only go to MaxWidth, if it goes to MaxWidth, then wordwrap will bring the text down to a new line.
                //In order to fit it, we'll need to adjust the height by a certain amount of units.

                // chatTbl.Controls.Add(chatMsg, 2, 0);

                int width = chatTbl.GetColumnWidths()[2];
                // int height = tableLayoutPanel1.GetRowHeights()[pos.Row];

                if (stringwidth < maxwidth + width - chatMsg.Width) {
                    //This is great, we can set the width to be a small as the actual text.
                    width = (int)(stringwidth + width - chatMsg.Width + 5);
                } else {
                    lines = 0;
                    width = maxwidth + width - chatMsg.Width;
                    string noescapebody = body.Replace("\r\n", string.Empty).Replace("\r\n", string.Empty);
                    stringwidth = gfx.MeasureString(noescapebody, chatMsg.Font).Width;

                    while (stringwidth > 0) {
                        stringwidth -= width;
                        lines++;
                    }
                }
                if (body.Contains("\n")) {
                    while (body.Contains("\r\n")) {
                        body = body.Remove(body.IndexOf("\r\n"), "\r\n".Length);
                        lines++;
                    }
                    while (body.Contains("\n")) {
                        body = body.Remove(body.IndexOf("\n"), "\n".Length);
                        lines++;
                    }
                }

                //Adjusts the height based on the number of lines.
                this.Height = (lines * fontheight) + Height - chatMsg.Height;
            }
        }

    }
}
