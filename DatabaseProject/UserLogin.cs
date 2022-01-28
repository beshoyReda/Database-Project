using DatabaseProject.models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseProject
{
    public partial class UserLogin : UserControl
    {
        public UserLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            DBController dBController = new DBController();

            try
            {
                string q = string.Format("call LogIn('{0}', '{1}')", txtUsername.Text, txtPassword.Text);

                if (dBController.OpenConnection())
                {
                    MySqlCommand cmd = new MySqlCommand(q, dBController.connection);
                    MySqlDataReader dataReader = cmd.ExecuteReader();
                    string FirstName = "";
                    string LastName = string.Empty;
                    int Balance = 0;
                    string ID = string.Empty;
                    string Address = string.Empty;
                    string DoB = string.Empty;
                    string username = string.Empty;
                    string password = string.Empty;
                    string phone = string.Empty;

                    while (dataReader.Read())
                    {
                        FirstName += dataReader.GetString("Fname");
                        LastName = dataReader.GetString("Lname");
                        Balance = ((int)dataReader.GetUInt32(2));
                        ID = dataReader.GetString("Customer_ID");
                        username = dataReader.GetString("Customer_Username");
                        password = dataReader.GetString("Customer_Password");
                        phone = dataReader.GetString("Phone_number");
                        DoB = dataReader.GetString("Date_of_birth");
                        Address = dataReader.GetString("Address");
                    }
                    dataReader.Close();
                    dBController.CloseConnection();
                    Console.WriteLine("++" + FirstName);
                    Customer customer = new Customer(FirstName, LastName, Balance, ID, Address, DoB, username, password, phone);
                    GlobalManager.SigninUser(customer);
                    MainPage mainPage = new MainPage();
                    mainPage.Show();
                    this.Parent.Parent.Parent.Dispose();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Logger.LogException(ex.Message);
            }

            
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Signuppage signuppage = new Signuppage();  
            signuppage.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SignUpPopup signUpPopup = new SignUpPopup();
            signUpPopup.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Can't help you!");
        }
    }
}
