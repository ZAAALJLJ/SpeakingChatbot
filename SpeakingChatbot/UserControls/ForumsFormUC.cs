using SpeakingChatbot.socket;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Windows.Forms.Design;
using System.IO;
using SpeakingChatbot.db;
using SpeakingChatbot.Properties;
using System.Resources;

namespace SpeakingChatbot.UserControls {
    public partial class ForumsFormUC : UserControl {

        public event EventHandler<string> BackBtnClick;

        socketControl client;

        Crud crud = new Crud();
        string username;
        string filePath;
        string cat;

        public ForumsFormUC(string userName, Object Client) {
            username = userName;
            client = (socketControl?)Client;
            InitializeComponent();
        }

        private void backBtn_Click(object sender, EventArgs e) {
            BackBtnClick?.Invoke(this, username);
        }

        private void submitBtn_Click(object sender, EventArgs e) {
            var title = titleTextBox.Text.Trim();
            var description = descriptionTextBox.Text.Trim();

            bool sdg = false;

            foreach (Control cBox in sdgCheckTbl.Controls) {
                if (cBox is CheckBox) {
                    if (((CheckBox)cBox).Checked == true) {
                        sdg = true;
                        break;
                    }
                }
            }

            if (cat == null ||
              string.IsNullOrEmpty(title) ||
              string.IsNullOrEmpty(description) ||
              sdg == false) {
                errLbl.Visible = true;
            } else {
                errLbl.Visible = true;
                errLbl.Text = "form successfully added.";
                errLbl.BackColor = Color.Lime;
                errLbl.ForeColor = Color.Black;
                if (filePath != null) {
                    string fileName = username + "-" + Path.GetFileName(filePath);
                    string newFilePath = @"..\..\..\Files\" + fileName;

                    int i = 1;
                    while (File.Exists(newFilePath)) {
                        Debug.WriteLine(newFilePath);
                        string file = Path.GetFileNameWithoutExtension(filePath);
                        string extension = Path.GetExtension(filePath);

                        fileName = $"{username}-{file} ({i}){extension}";
                        newFilePath = @"..\..\..\Files\" + fileName;
                        i++;
                    }
                    File.Copy(filePath, newFilePath);


                    crud.createForm(username, title, cat, description, newFilePath);

                } else {
                    crud.createForm(username, title, cat, description);
                }
                clearForm();
            }
        }

        private void clearForm() {
            // clear lahat

            int milliseconds = 1500;
            Thread.Sleep(milliseconds);

            titleTextBox.Clear();
            descriptionTextBox.Clear();
            filePath = null;
            cat = null;
            filePathLbl.Text = null;
            addFileBtn.Image = Properties.Resources.addfile;

            foreach (Control cBox in sdgCheckTbl.Controls) {
                if (cBox is CheckBox) {
                    ((CheckBox)cBox).Checked = false;
                }
            }

            foreach (Control rBtn in categoriesTbl.Controls) {
                if (rBtn is RadioButton) {
                    ((RadioButton)rBtn).Checked = false;
                }
            }

            errLbl.Visible = false;
        }

        private void addFileBtn_Click(object sender, EventArgs e) {
            if (filePath != null) {
                addFileBtn.Image = Properties.Resources.addfile;

                filePathLbl.Text = null;
                filePath = null;
            } else {
                using (OpenFileDialog openFileDialog1 = new OpenFileDialog()) {
                    openFileDialog1.InitialDirectory = "c:\\";
                    openFileDialog1.RestoreDirectory = true;

                    if (openFileDialog1.ShowDialog() == DialogResult.OK) {
                        filePath = openFileDialog1.FileName;
                        addFileBtn.Image = Properties.Resources.clear_button;
                        filePathLbl.Text = filePath;
                    }
                }
            }

        }





        private void cat1_Click(object sender, EventArgs e) {
            cat = "guide";
        }

        private void cat2_Click(object sender, EventArgs e) {
            cat = "event";
        }

        private void cat3_Click(object sender, EventArgs e) {
            cat = "question";
        }

        private void cat4_Click(object sender, EventArgs e) {
            cat = "news";
        }

        private void cat5_Click(object sender, EventArgs e) {
            cat = "research paper";
        }

        private void cat6_Click(object sender, EventArgs e) {
            cat = "others";
        }


        private void sdgLbl1_Click(object sender, EventArgs e) {
            if (sdg1.Checked == true) {
                sdg1.Checked = false;
            } else {
                sdg1.Checked = true;
            }
        }
        private void sdgLbl2_Click(object sender, EventArgs e) {
            if (sdg2.Checked == true) {
                sdg2.Checked = false;
            } else {
                sdg2.Checked = true;
            }
        }
        private void sdgLbl3_Click(object sender, EventArgs e) {
            if (sdg3.Checked == true) {
                sdg3.Checked = false;
            } else {
                sdg3.Checked = true;
            }
        }
        private void sdgLbl4_Click(object sender, EventArgs e) {
            if (sdg4.Checked == true) {
                sdg4.Checked = false;
            } else {
                sdg4.Checked = true;
            }
        }
        private void sdgLbl5_Click(object sender, EventArgs e) {
            if (sdg5.Checked == true) {
                sdg5.Checked = false;
            } else {
                sdg5.Checked = true;
            }
        }
        private void sdgLbl6_Click(object sender, EventArgs e) {
            if (sdg6.Checked == true) {
                sdg6.Checked = false;
            } else {
                sdg6.Checked = true;
            }
        }
        private void sdgLbl7_Click(object sender, EventArgs e) {
            if (sdg7.Checked == true) {
                sdg7.Checked = false;
            } else {
                sdg7.Checked = true;
            }
        }
        private void sdgLbl8_Click(object sender, EventArgs e) {
            if (sdg8.Checked == true) {
                sdg8.Checked = false;
            } else {
                sdg8.Checked = true;
            }
        }
        private void sdgLbl9_Click(object sender, EventArgs e) {
            if (sdg9.Checked == true) {
                sdg9.Checked = false;
            } else {
                sdg9.Checked = true;
            }
        }
        private void sdgLbl10_Click(object sender, EventArgs e) {
            if (sdg10.Checked == true) {
                sdg10.Checked = false;
            } else {
                sdg10.Checked = true;
            }
        }
        private void sdgLbl11_Click(object sender, EventArgs e) {
            if (sdg11.Checked == true) {
                sdg11.Checked = false;
            } else {
                sdg11.Checked = true;
            }
        }
        private void sdgLbl12_Click(object sender, EventArgs e) {
            if (sdg12.Checked == true) {
                sdg12.Checked = false;
            } else {
                sdg12.Checked = true;
            }
        }
        private void sdgLbl13_Click(object sender, EventArgs e) {
            if (sdg13.Checked == true) {
                sdg13.Checked = false;
            } else {
                sdg13.Checked = true;
            }
        }
        private void sdgLbl14_Click(object sender, EventArgs e) {
            if (sdg14.Checked == true) {
                sdg14.Checked = false;
            } else {
                sdg14.Checked = true;
            }
        }
        private void sdgLbl15_Click(object sender, EventArgs e) {
            if (sdg15.Checked == true) {
                sdg15.Checked = false;
            } else {
                sdg15.Checked = true;
            }
        }
        private void sdgLbl16_Click(object sender, EventArgs e) {
            if (sdg16.Checked == true) {
                sdg16.Checked = false;
            } else {
                sdg16.Checked = true;
            }
        }
        private void sdgLbl17_Click(object sender, EventArgs e) {
            if (sdg17.Checked == true) {
                sdg17.Checked = false;
            } else {
                sdg17.Checked = true;
            }
        }
    }
}
