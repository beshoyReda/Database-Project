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
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void Login_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LoginPage_Load(object sender, EventArgs e)
        {
            UserLogin userLogin = new UserLogin();
            Login.Controls.Add(userLogin);
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            Login.Controls.Clear();
            UserLogin userLogin = new UserLogin();
            Login.Controls.Add(userLogin);
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            Login.Controls.Clear();
            AdminLogin userLogin = new AdminLogin();
            Login.Controls.Add(userLogin);
        }
    }
}
