﻿using System;
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
            MainPage mainPage = new MainPage();
            mainPage.Show();
            this.Parent.Parent.Parent.Dispose();
            
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
