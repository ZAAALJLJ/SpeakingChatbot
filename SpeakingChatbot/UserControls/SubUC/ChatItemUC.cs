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
            string body = textmodel.Body;
            TextChange(chatMsg.Text);

            ResumeLayout();

            void TextChange(string body) {
                int fontheight = chatMsg.Font.Height;
                var gfx = this.CreateGraphics();
                int lines = 1;
                double stringwidth = gfx.MeasureString(body, chatMsg.Font).Width;

                int width = chatTbl.GetColumnWidths()[2];
                int height = chatTbl.GetRowHeights()[0];

                if (stringwidth < maxwidth + width - chatMsg.Width) {
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
                this.Height = (lines * fontheight) + Height - chatMsg.Height;
            }
        }

    }
}
