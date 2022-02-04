using DatabaseProject.models;
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
    public partial class Profile : UserControl
    {
        public Profile()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Profile_Load(object sender, EventArgs e)
        {
            var ac = GlobalManager.ActiveUser;
            Namelbl.Text = ac.FirstName + ' ' + ac.LastName;
            Age.Text = ac.DoB.Split(' ')[0];
            Console.WriteLine(ac.FirstName);
            label1.Text = ac.Balance.ToString();
            usernamelbl.Text = ac.username;
            Addresslbl.Text = ac.Address;
        }
    }
}
