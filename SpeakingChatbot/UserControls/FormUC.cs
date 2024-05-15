using SpeakingChatbot.UserControls.SubUC;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Speech.Recognition;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Diagnostics;

namespace SpeakingChatbot.UserControls {
    public partial class FormUC : UserControl {

        FormCommentsUC formComments;

        int i = 1;
        public FormUC() {
            InitializeComponent();
        }

        private void submitBtn_Click(object sender, EventArgs e) {
            // add comment using the commentUC

            // disable submit btn if wala laman textbox

            formComments = new FormCommentsUC(i) {
                Name = "comment" + i++,
                Dock = DockStyle.Top,
            };

            commentPanel.Controls.Add(formComments);
        }

        // for now wala muna to
        private void FormUC_Load(object sender, EventArgs e) {
            /*            SpeechRecognitionEngine speechRecognizer = new SpeechRecognitionEngine();
                        speechRecognizer.SetInputToDefaultAudioDevice();
                        Grammar grammar = new DictationGrammar();
                        speechRecognizer.LoadGrammar(grammar);
                        speechRecognizer.SpeechRecognized += new EventHandler<SpeechRecognizedEventArgs>(speechRecognizer_SpeechRecognized);
                        speechRecognizer.RecognizeAsync(RecognizeMode.Multiple);*/
        }

        /*        private void speechRecognizer_SpeechRecognized(object sender, SpeechRecognizedEventArgs e) {
                    content.Text = e.Result.Text + "\r\n";
                    Debug.WriteLine(e.Result.Text);
                }*/

    }
}
