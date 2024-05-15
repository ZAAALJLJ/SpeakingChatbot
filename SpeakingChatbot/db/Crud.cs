using MySql.Data.MySqlClient;
using System.Net.Sockets;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using System.Windows.Forms;
using System.Diagnostics;
using System.ComponentModel;
using SpeakingChatbot.UserControls.SubUC;

namespace SpeakingChatbot.db {
    internal class Crud {
        dbConnection db;

        string currentIpAddress;

        FormItemUC formItem;

        public Crud() {
            db = new dbConnection();
        }

        private string hashPassword(string password) {
            byte[] passByteArr;
            byte[] hashByteArr;
            string hashedPass;

            passByteArr = ASCIIEncoding.ASCII.GetBytes(password);
            hashByteArr = new MD5CryptoServiceProvider().ComputeHash(passByteArr);

            hashedPass = ByteArrayToString(hashByteArr);
            return hashedPass;
        }

        private string ByteArrayToString(byte[] hashByteArr) {
            StringBuilder output = new StringBuilder(hashByteArr.Length);
            for(int i = 0; i < hashByteArr.Length - 1; i++) {
                output.Append(hashByteArr[i].ToString("X2"));
            }
            return output.ToString();
        }

        public void createUser(string username, string password) {
            string query = "INSERT INTO `users`(`userName`, `userPassword`) VALUES (@usn, @pass)";
            MySqlCommand command = new MySqlCommand(query, db.getConnection());

            string hashedPass = hashPassword(password);

            command.Parameters.Add("@usn", MySqlDbType.VarChar).Value = username;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = hashedPass;

            db.openConnection();

            try {
                command.ExecuteNonQuery();
                MessageBox.Show("Account created!");
            } catch (Exception ex) {
                MessageBox.Show("Creating account not created: " + ex.Message);
            }

            db.closeConnection();
        }

        private int getUserByName(string username) {
            int userId = 0;
            string query = "SELECT `userId` FROM `users` WHERE `userName` = @usn LIMIT 1";

            MySqlCommand command = new MySqlCommand(query, db.getConnection());

            command.Parameters.Add("@usn", MySqlDbType.VarChar).Value = username;

            db.openConnection();

            try {
                using (MySqlDataReader reader = command.ExecuteReader()) {
                    if (reader.Read()) {
                        userId = reader.GetInt32(0);
                    }
                }
            } catch (Exception ex) {
                MessageBox.Show("Error: " + ex.Message);
            }

            return userId;
        }

        private string getUserById(int userId) {
            string username = "";
            string query = "SELECT `userName` FROM `users` WHERE `userId` = @usId LIMIT 1";

            MySqlCommand command = new MySqlCommand(query, db.getConnection());

            command.Parameters.Add("@usId", MySqlDbType.Int32).Value = userId;

            db.openConnection();

            try {
                using (MySqlDataReader reader = command.ExecuteReader()) {
                    if (reader.Read()) {
                        username = reader.GetString(0);
                    }
                }
            } catch (Exception ex) {
                MessageBox.Show("Error: " + ex.Message);
            }

            return username;
        }

        public void createForm(string userName, string title, string category, string description, string filePath = null) {
            int userId = getUserByName(userName);
            string query;

            if (filePath != null) {
                query = "INSERT INTO `posts`(`userId`, `postTitle`, `postCategory`, `content`, `postFileLoc`)" +
                            "VALUES (@uId, @title, @cat, @desc, @fPath)";
            } else {
                query = "INSERT INTO `posts`(`userId`, `postTitle`, `postCategory`, `content`)" +
                            "VALUES (@uId, @title, @cat, @desc)";
            }

            MySqlCommand command = new MySqlCommand(query, db.getConnection());

            command.Parameters.Add("@uId", MySqlDbType.VarChar).Value = userId;
            command.Parameters.Add("@title", MySqlDbType.VarChar).Value = title;
            command.Parameters.Add("@cat", MySqlDbType.VarChar).Value = category;
            command.Parameters.Add("@desc", MySqlDbType.VarChar).Value = description;

            if (filePath != null) {
                command.Parameters.Add("@fPath", MySqlDbType.VarChar).Value = filePath;
            }

            db.openConnection();

            try {
                command.ExecuteNonQuery();
                MessageBox.Show("Account created!");
            } catch (Exception ex) {
                MessageBox.Show("Creating account not created: " + ex.Message);
            }

            db.closeConnection();
        }

        public bool checkCredentials(string username, string password) {
            bool isFound = false;
            string IPAddress;

            string hashedPass = hashPassword(password);

            string query = "SELECT * FROM `users` WHERE `userName` = @usn AND `userPassword` = @pass LIMIT 1";

            MySqlCommand command = new MySqlCommand(query, db.getConnection());

            command.Parameters.Add("@usn", MySqlDbType.VarChar).Value = username;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = hashedPass;

            db.openConnection();

            try {
                using (MySqlDataReader reader = command.ExecuteReader()) {
                    if (reader.Read()) {
                        isFound = true;
                    }
                }
            } catch (Exception ex) {
                MessageBox.Show("Error: " + ex.Message);
            }

            if(isFound) {
                currentIpAddress = GetLocalIPAddress();
                addLocalIPAddress(currentIpAddress, username);
            }

            db.closeConnection();

            return isFound;
        }

        private string GetLocalIPAddress() {
            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in host.AddressList) {
                if (ip.AddressFamily == AddressFamily.InterNetwork) {
                    return ip.ToString();
                }
            }
            throw new Exception("No network adapters with an IPv4 address in the system!");
        }

        private void addLocalIPAddress(string IPAddress, string username) {
            string query = "UPDATE `users` SET `IPAddress` = @ipadd, `isOnline` = true WHERE `userName` = @usn LIMIT 1";
            // string query = "INSERT INTO `users`(`IPAdress`) VALUES (@ipadd)";
            MySqlCommand command = new MySqlCommand(query, db.getConnection());

            command.Parameters.Add("@ipadd", MySqlDbType.VarChar).Value = IPAddress;
            command.Parameters.Add("@usn", MySqlDbType.VarChar).Value = username;

            try {
                command.ExecuteNonQuery();
                MessageBox.Show("IP Address Added!");
            } catch (Exception ex) {
                MessageBox.Show("IP Address not Added: " + ex.Message);
            }
        }

        public string getIpAddress(int id) {
            return "";
        }

        public string[] getUsers(string username, int isOnline) {
            string[] users;
            int usersCnt = 0;

            string query = "SELECT COUNT(*) from `users` WHERE isOnline = @isOn";

            MySqlCommand command = new MySqlCommand(query, db.getConnection());

            command.Parameters.Add("@isOn", MySqlDbType.Int32).Value = isOnline;

            db.openConnection();

            try {
                using (MySqlDataReader reader = command.ExecuteReader()) {
                    if (reader.Read()) {
                        usersCnt = reader.GetInt32(0);
                    }
                }
            } catch (Exception ex) {
                MessageBox.Show("Error: " + ex.Message);
            }

            query = "SELECT `userName` FROM `users` WHERE isOnline = @isOn AND `userName` != @curUser";

            command = new MySqlCommand(query, db.getConnection());


            command.Parameters.Add("@curUser", MySqlDbType.VarChar).Value = username;
            command.Parameters.Add("@isOn", MySqlDbType.Int32).Value = isOnline;

            if (isOnline == 1) {
                users = new string[usersCnt - 1];
            } else {
                users = new string[usersCnt];
            }

            int i = 0;

            try {
                using (MySqlDataReader reader = command.ExecuteReader()) {
                    while (reader.Read()) {
                        users[i] = reader.GetString(0);
                        i++;
                    }
                }
            } catch (Exception ex) {
                MessageBox.Show("Error: " + ex.Message);
            }

            db.closeConnection();

            return users;
        }

        public void addComment(int postId, string username, string comment) {
            int userId = getUserByName(username);
            string query = "INSERT INTO `comments`(`postId`, `userId`, `comment`)" +
                                "VALUES (@pId, @uId, @cmt)";

            MySqlCommand command = new MySqlCommand(query, db.getConnection());

            command.Parameters.Add("@pId", MySqlDbType.Int32).Value = postId;
            command.Parameters.Add("@uId", MySqlDbType.Int32).Value = userId;
            command.Parameters.Add("@cmt", MySqlDbType.Text).Value = comment;

            db.openConnection();

            try {
                command.ExecuteNonQuery();
                MessageBox.Show("Comment Posted!");
            } catch (Exception ex) {
                MessageBox.Show("Error posting comment: " + ex.Message);
            }

            db.closeConnection();
        }

        public int getVotes(int postId) {
            int votes = 0;
            
            string query = "SELECT `votes` FROM `posts` WHERE `postId` = @pId";

            MySqlCommand command = new MySqlCommand(query, db.getConnection());

            command.Parameters.Add("@pId", MySqlDbType.Int32).Value = postId;

            db.openConnection();

            try {
                using (MySqlDataReader reader = command.ExecuteReader()) {
                    if (reader.Read()) {
                        votes = reader.GetInt32(0);
                    }
                }
            } catch (Exception ex) {
                MessageBox.Show("Error getVotesd: " + ex.Message);
            }

            db.closeConnection();

            return votes;
        }

        public void addVotes(int postId, bool isUpVote) {
            int votes = getVotes(postId);

            string query = "UPDATE `posts` SET `votes` = @vote WHERE `postId` = @pId";

            if (isUpVote) {
                votes++;
            } else {
                votes--;
            }

            MySqlCommand command = new MySqlCommand(query, db.getConnection());

            command.Parameters.Add("@vote", MySqlDbType.Int32).Value = votes;
            command.Parameters.Add("@pId", MySqlDbType.Int32).Value = postId;

            db.openConnection();

            try {
                command.ExecuteNonQuery();
                MessageBox.Show("Comment Posted!");
            } catch (Exception ex) {
                MessageBox.Show("Error addVotes: " + ex.Message);
            }

            db.closeConnection();
        }

        public void getPosts() {
            string query = "SELECT `postId`, `userid`, `postTitle`, `postCategory`, `votes`, `createdAt` FROM `posts`";

            MySqlCommand command = new MySqlCommand(query, db.getConnection());

            db.openConnection();

            try {
                using (MySqlDataReader reader = command.ExecuteReader()) {
                    int postId = reader.GetInt32(0);
                    int userId = reader.GetInt32(1);
                    string postTitle = reader.GetString(2);
                    string postCategory = reader.GetString(3);
                    int votes = reader.GetInt32(4);
                    string postCreated = reader.GetString(5);

                    string username = getUserById(userId);

                    formItem = new FormItemUC(postId, username, postTitle, postCategory, votes, postCreated) {
                        Name = "post" + postId.ToString(),
                        Dock = DockStyle.Top,
                    };

                }
            } catch (Exception ex) {
                MessageBox.Show("Error getPosts: ", ex.Message);
            }

            db.closeConnection();

            // return formItem;
        }
    }
}
