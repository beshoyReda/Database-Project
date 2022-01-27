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
    public partial class Usersidebar : UserControl
    {
        public Usersidebar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Parent.Parent.Parent.Controls[0].Controls[0].Controls.Clear();
            CartControl cart = new CartControl();
            this.Parent.Parent.Parent.Controls[0].Controls[0].Controls.Add(cart);
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            this.Parent.Parent.Parent.Controls[0].Controls[0].Controls.Clear();
            for (int i = 0; i < 30; i++)
            {
                ProductControl productControl = new ProductControl();
                productControl.Margin = new Padding(5, 5, 5, 5);
                this.Parent.Parent.Parent.Controls[0].Controls[0].Controls.Add(productControl);
            }
        }

        private void Walletbtn_Click(object sender, EventArgs e)
        {
            this.Parent.Parent.Parent.Controls[0].Controls[0].Controls.Clear();
            wallet walt = new wallet();
            this.Parent.Parent.Parent.Controls[0].Controls[0].Controls.Add(walt);
        }

        private void Purchasesbtn_Click(object sender, EventArgs e)
        {
            this.Parent.Parent.Parent.Controls[0].Controls[0].Controls.Clear();
            Purchases purschase = new Purchases();
            this.Parent.Parent.Parent.Controls[0].Controls[0].Controls.Add(purschase);
        }

        private void Profilebtn_Click(object sender, EventArgs e)
        {
            Profile profile = new Profile();
            this.Parent.Parent.Parent.Controls[0].Controls[0].Controls.Clear();
            this.Parent.Parent.Parent.Controls[0].Controls[0].Controls.Add(profile);
        }
    }
}