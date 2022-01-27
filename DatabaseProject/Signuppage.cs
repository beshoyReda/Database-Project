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
    public partial class Signuppage : UserControl
    {
        public Signuppage()
        {
            InitializeComponent();
        }

        private void Lname_Click(object sender, EventArgs e)
        {

        }

        private void signupbutton_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Parent.Dispose();
        }

        private void signupbutton_Click_1(object sender, EventArgs e)
        {
            DBController dBController = new DBController();
            
            try
            {
                string id = Guid.NewGuid().ToString();
                string q = string.Format("call SignUp('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', {6}, '{7}')",
                    FnameBox.Text.Trim(), LnameBox.Text.Trim(), id, Usernamebox.Text.Trim(), PasswordBox.Text.Trim(), phonenumberBox.Text.Trim(), dateTimePicker1.Value.ToShortDateString(), AddressBox.Text.Trim());
                if (dBController.OpenConnection())
                {
                    MySqlCommand cmd = new MySqlCommand(q, dBController.connection);
                    cmd.ExecuteNonQuery();
                    dBController.CloseConnection();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Logger.LogException(ex.Message);
            }

        }
    }
}
