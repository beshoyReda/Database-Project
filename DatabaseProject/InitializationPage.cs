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
    public partial class InitializationPage : Form
    {
        public InitializationPage()
        {
            InitializeComponent();



        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void InitializationPage_load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox1.Enabled = false;
            pictureBox1.Hide();
            LoginPage loginPage = new LoginPage();
            this.Hide();
            loginPage.Show();
            timer1.Enabled = false;
            
            
        }

        private void InitializationPage_Load_1(object sender, EventArgs e)
        {
            GlobalManager.InitializeApp();
        }
    }
}
