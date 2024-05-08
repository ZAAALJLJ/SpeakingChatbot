using System;
using System.Windows.Forms;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace SpeakingChatbot {
    public partial class Form1 : Form {
        private string userInput;

        public event EventHandler<string> UserInputEntered;

        private MySqlConnection connection;
        private string connectionString = "server=localhost;user=root;database=chats;password=sqlOMNIVERSE01;";

        public Form1() {
            InitializeComponent();
            InitializeDatabaseConnection();
        }

         private void InitializeDatabaseConnection() {
             connection = new MySqlConnection(connectionString);
             try
             {
                 connection.Open();
                 MessageBox.Show("Database connection established.");
             }
             catch (Exception ex)
             {
                 MessageBox.Show("Error connecting to the database: " + ex.Message);
             }
         }

        bool chatBoxIsOpen = false;

        private void chatBtn_Click(object sender, EventArgs e) {
            if (chatBoxIsOpen == false) {

                chatContainer.Visible = true;

                chatUserControl.ChatBoxInfo cbi = new chatUserControl.ChatBoxInfo {
                    User = "BingBong",
                    NamePlaceholder = "testing",
                    StatusPlaceholder = "online",
                };


                var chatPanel = new chatUserControl.ChatUserControl(cbi) {
                    Dock = DockStyle.Fill,
                    Name = "testing",
                };

                chatPanel.connectToServer(cbi);

                chatContainer.Controls.Add(chatPanel);
                chatBoxIsOpen = true;
                chatBtn.Text = "Exit";

            } else {
                chatContainer.Visible = false;
                chatBoxIsOpen = false;
                chatBtn.Text = "Chatbox";
            }
        }

        private void button1_Click(object sender, EventArgs e) {
            userInput = richTextBox1.Text;
            OnUserInputEntered(userInput);
        }

        private void OnUserInputEntered(string input) {
            if (UserInputEntered != null) {
                UserInputEntered(this, input);
            }
        }

        private async Task<string> SendRequestAndGetResponse(string userInput, string previousConversation) {
            string combinedInput = previousConversation + userInput;
        
            string jsonBody = $@"{{
                                ""contents"": [
                                    {{
                                        ""role"": """",
                                        ""parts"": [
                                            {{
                                                ""text"": ""{combinedInput}""
                                            }}
                                        ]
                                    }}
                                ],
                                ""generationConfig"": {{
                                    ""temperature"": 0.9,
                                    ""topK"": 50,
                                    ""topP"": 0.95,
                                    ""maxOutputTokens"": 4096,
                                    ""stopSequences"": []
                                }},
                                ""safetySettings"": [
        
                                ]
                            }}";
        
            using (var client = new HttpClient())
            {
                var request = new HttpRequestMessage(HttpMethod.Post, "https://generativelanguage.googleapis.com/v1beta/models/gemini-pro:generateContent?key=AIzaSyA4_FnJD9hPi4e7hh-cV6XEHXbyHUezycE");
                request.Content = new StringContent(jsonBody, Encoding.UTF8);
                request.Content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
        
                var response = await client.SendAsync(request).ConfigureAwait(false);
        
                if (response.IsSuccessStatusCode)
                {
                    string responseBody = await response.Content.ReadAsStringAsync();
        
                 
                    InsertConversation(combinedInput, responseBody);
        
                    return responseBody.Substring(responseBody.IndexOf("\"text\": \"") + 9, responseBody.IndexOf("\"", responseBody.IndexOf("\"text\": \"") + 10) - responseBody.IndexOf("\"text\": \"") - 9);
                }
                else
                {
                    MessageBox.Show("Error1");
                    return $"Error: {response.StatusCode} - {response.ReasonPhrase}";
                }
            }
        }

        private string RetrievePreviousConversation() {
            string previousConversation = string.Empty;
        
            return previousConversation;
        }

        private void textBoxInput_TextChanged(object sender, EventArgs e) {
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e) {

        }

         private void InsertConversation(string userInput, string aiResponse) {
             string query = "INSERT INTO conversations (UserInput, BotResponse) VALUES (@UserInput, @BotResponse)"; //names are the colummn names in sql table
             MySqlCommand command = new MySqlCommand(query, connection);
             command.Parameters.AddWithValue("@UserInput", userInput);
             command.Parameters.AddWithValue("@BotResponse", aiResponse);
        
             try
             {
                 command.ExecuteNonQuery();
                 MessageBox.Show("Conversation inserted into the database.");
             }
             catch (Exception ex)
             {
                 MessageBox.Show("Error inserting conversation data: " + ex.Message);
             }
         }

        private async void button2_Click(object sender, EventArgs e) {
            string userInput = textBox1.Text;

            if (!string.IsNullOrEmpty(userInput))
            {
                clearText();
            
                string previousConversation = RetrievePreviousConversation();
            
                string output = await SendRequestAndGetResponse(userInput, previousConversation);
            
                output = output.Replace("\\n", Environment.NewLine)
                               .Replace("\n", "")
                               .Replace("**", "");
            
                richTextBox1.AppendText(output);
            
                InsertConversation(userInput, output);
            }
            else
            {
                MessageBox.Show("Input cannot be empty.", "Error");
            }
        }
    
        protected override void OnFormClosing(FormClosingEventArgs e) {
            base.OnFormClosing(e);
            if (connection != null && connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }

        private void clearText() {
            richTextBox1.Clear();
        }

    }
}
