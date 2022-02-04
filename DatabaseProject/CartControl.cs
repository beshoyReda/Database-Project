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
    public partial class CartControl : UserControl
    {
        public CartControl()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Cart_Load(object sender, EventArgs e)
        {
            ProdCon.Controls.Clear();
            float t = 0;

            foreach (var p in GlobalManager.cart.Products)
            {
                CartProduct product = new CartProduct(p);
                ProdCon.Controls.Add(product);
                t += p.total;
            }
            TotalCash.Text = t.ToString();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
