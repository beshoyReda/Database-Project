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
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void ButtonContainer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Content_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {
            Header header = new Header();
            Header.Controls.Add(header);
        }

        private void ProductContainer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ProductContainer_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void MainPage_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 30; i++)
            {
                ProductControl productControl = new ProductControl();
                productControl.Margin = new Padding(5, 5, 5, 5);
                ProductContainer.Controls.Add(productControl);
            }
        }
    }
}
