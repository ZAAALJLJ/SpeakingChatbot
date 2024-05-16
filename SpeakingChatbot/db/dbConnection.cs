using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpeakingChatbot.db {
    internal class dbConnection {

        private MySqlConnection connection;

        // private string connectionString = "server=192.168.18.77;port=3306;database=chavatar;user=dahlia;password=CHAVATAR-chavatar-12345;";
        private string connectionString = "server=127.0.0.1;port=3306;database=chavatar;user=dahlia";

        public dbConnection() {
            // connect to db
            connection = new MySqlConnection(connectionString);
            try {
                connection.Open();
                MessageBox.Show("Database connection established.");
            } catch (Exception ex) {
                MessageBox.Show("Error connecting to the database: " + ex.Message);
            }
        }

        // 1 connection lang


        public void openConnection() {
            if (connection.State == System.Data.ConnectionState.Closed) {
                connection.Open();
            }
        }

        public void closeConnection() {
            if (connection.State == System.Data.ConnectionState.Open) {
                connection.Close();
            }
        }

        public MySqlConnection getConnection() {
            return connection;
        }


        private void InsertConversation(string userInput, string aiResponse) {
            string query = "INSERT INTO conversations (UserInput, BotResponse) VALUES (@UserInput, @BotResponse)"; //names are the colummn names in sql table
            MySqlCommand command = new MySqlCommand(query, connection);
            command.Parameters.AddWithValue("@UserInput", userInput);
            command.Parameters.AddWithValue("@BotResponse", aiResponse);

            try {
                command.ExecuteNonQuery();
                MessageBox.Show("Conversation inserted into the database.");
            } catch (Exception ex) {
                MessageBox.Show("Error inserting conversation data: " + ex.Message);
            }
        }


    }
}
