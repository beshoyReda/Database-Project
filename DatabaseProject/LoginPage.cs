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
    }
}
