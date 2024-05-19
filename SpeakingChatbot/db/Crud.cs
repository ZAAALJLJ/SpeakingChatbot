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

        public event EventHandler<string[]> createFormItemEvent;

        public event EventHandler<int[]> displaySdg;

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
                // MessageBox.Show("Account created!");
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
                MessageBox.Show("get user by name Error: " + ex.Message);
            }

            return userId;
        }

        public string getUserById(int userId) {
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
                MessageBox.Show("get user by id Error: " + ex.Message);
            }

            return username;
        }

        public void createForm(string userName, string title, string category, string description, int[] sdgs, string filePath = null) {
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
                // MessageBox.Show("Post created!");
            } catch (Exception ex) {
                MessageBox.Show("Post not created: " + ex.Message);
            }

            int postId = getNumPosts();

            for(int i = 0; i < sdgs.Length; i++) {
                addSdgs(postId, sdgs[i]);
            }

            db.closeConnection();
        }

        private void addSdgs(int postId, int sdg) {
            string query;

         
            query = "INSERT INTO `post_sdg`(`postId`, `sdg`) VALUES (@pId, @SDG)";

            MySqlCommand command = new MySqlCommand(query, db.getConnection());

            command.Parameters.Add("@pId", MySqlDbType.Int32).Value = postId;
            command.Parameters.Add("@SDG", MySqlDbType.Int32).Value = sdg;

            try {
                command.ExecuteNonQuery();
                // MessageBox.Show("Sdg added!");
            } catch (Exception ex) {
                MessageBox.Show("sdg not added: " + ex.Message);
            }
        }

        private int getNumPosts() {
            string query = "select max(postId) from posts";

            MySqlCommand command = new MySqlCommand(query, db.getConnection());

            try {
                using (MySqlDataReader reader = command.ExecuteReader()) {
                    if (reader.Read()) {
                        return reader.GetInt32(0);
                    }
                }
            } catch (Exception ex) {
                MessageBox.Show("Creating account not created: " + ex.Message);
            }
            return 0;
        }

        public bool checkCredentials(string username, string password) {
            bool isFound = false;

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
                MessageBox.Show("check credentials Error: " + ex.Message);
            }


            db.closeConnection();

            return isFound;
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
                MessageBox.Show("get users Error: " + ex.Message);
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
                // MessageBox.Show("get users 1 Error: " + ex.Message);
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
                // MessageBox.Show("Comment Posted!");
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
                // MessageBox.Show("Comment Posted!");
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
                    while (reader.Read()) {

                        int postId = reader.GetInt32(0);
                        int userId = reader.GetInt32(1);
                        string postTitle = reader.GetString(2);
                        string postCategory = reader.GetString(3);
                        int votes = reader.GetInt32(4);
                        DateTime postCreated = reader.GetDateTime(5);

                        string[] postInfo = {
                            postId.ToString(),
                            userId.ToString(),
                            postTitle,
                            postCategory,
                            votes.ToString(),
                            postCreated.ToString(),
                        };

                       /* Debug.WriteLine(postId.ToString());
                        Debug.WriteLine(userId.ToString());
                        Debug.WriteLine(postTitle);
                        Debug.WriteLine(postCategory);
                        Debug.WriteLine(votes.ToString());
                        Debug.WriteLine(postCreated.ToString());*/

                        createFormItemEvent?.Invoke(this, postInfo);
                    }

                }
            } catch (Exception ex) {
                MessageBox.Show("Error getPosts: " + ex.Message);
            }

            db.closeConnection();
        }


        public string[] getPostById(int PostId) {
            string[] postInfo = new string[8];

            string query = "SELECT * FROM `posts` WHERE `postId` = @pId LIMIT 1";

            MySqlCommand command = new MySqlCommand(query, db.getConnection());

            command.Parameters.Add("@pId", MySqlDbType.Int32).Value = PostId;

            db.openConnection();

            try {
                using (MySqlDataReader reader = command.ExecuteReader()) {
                    if (reader.Read()) {
                        int postId = reader.GetInt32(0);
                        int userId = reader.GetInt32(1);
                        string postTitle = reader.GetString(2);
                        string postCategory = reader.GetString(3);
                        string postContent = reader.GetString(4);
                        string file = reader.GetString(5);
                        int votes = reader.GetInt32(6);
                        DateTime postCreated = reader.GetDateTime(7);

                        postInfo[0] = postId.ToString();
                        postInfo[1] = userId.ToString();
                        postInfo[2] = postTitle;
                        postInfo[3] = postCategory;
                        postInfo[4] = postContent;
                        postInfo[5] = file;
                        postInfo[6] = votes.ToString();
                        postInfo[7] = postCreated.ToString();
                    }

                }
            } catch (Exception ex) {
                MessageBox.Show("Error getPost by id: " + ex.Message);
                using (MySqlDataReader reader = command.ExecuteReader()) {
                    if (reader.Read()) {
                        int postId = reader.GetInt32(0);
                        int userId = reader.GetInt32(1);
                        string postTitle = reader.GetString(2);
                        string postCategory = reader.GetString(3);
                        string postContent = reader.GetString(4);
                        int votes = reader.GetInt32(6);
                        DateTime postCreated = reader.GetDateTime(7);

                        postInfo[0] = postId.ToString();
                        postInfo[1] = userId.ToString();
                        postInfo[2] = postTitle;
                        postInfo[3] = postCategory;
                        postInfo[4] = postContent;
                        postInfo[6] = votes.ToString();
                        postInfo[7] = postCreated.ToString();
                    }
                }
            }

            db.closeConnection();

            return postInfo;
        }

        public void filterPostSdg() {

            // baguhin yung queryyyyy
            string query = "SELECT `postId`, `userid`, `postTitle`, `postCategory`, `votes`, `createdAt` FROM `posts`";

            MySqlCommand command = new MySqlCommand(query, db.getConnection());

            db.openConnection();

            try {
                using (MySqlDataReader reader = command.ExecuteReader()) {
                    while (reader.Read()) {

                        int postId = reader.GetInt32(0);
                        int userId = reader.GetInt32(1);
                        string postTitle = reader.GetString(2);
                        string postCategory = reader.GetString(3);
                        int votes = reader.GetInt32(4);
                        DateTime postCreated = reader.GetDateTime(5);

                        string[] postInfo = {
                            postId.ToString(),
                            userId.ToString(),
                            postTitle,
                            postCategory,
                            votes.ToString(),
                            postCreated.ToString(),
                        };

                        /* Debug.WriteLine(postId.ToString());
                         Debug.WriteLine(userId.ToString());
                         Debug.WriteLine(postTitle);
                         Debug.WriteLine(postCategory);
                         Debug.WriteLine(votes.ToString());
                         Debug.WriteLine(postCreated.ToString());*/

                        createFormItemEvent?.Invoke(this, postInfo);
                    }

                }
            } catch (Exception ex) {
                MessageBox.Show("Error getPosts: " + ex.Message);
            }

            db.closeConnection();
        }
    }
}
