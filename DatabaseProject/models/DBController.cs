using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseProject.models
{
    internal class DBController
    {
        private string server;
        private string database;
        private string uid;
        private string password;
        public MySqlConnection connection;

        public DBController()
        {
            Initialize();
        }
        public void Initialize()
        {
            server = "localhost";
            database = "nuelectronics";
            uid = "root";
            password = "mysqlpassword";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

            connection = new MySqlConnection(connectionString);
        }

        public bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                if (ex.Number == 0)
                {
                    MessageBox.Show("Cannot connect to server.");
                }
                if (ex.Number == 1045)
                {
                    MessageBox.Show("Invalid Credentials.");
                }
                else
                {
                    MessageBox.Show(ex.Message);
                }
                return false;
            }
        }


        public bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
    }
}
