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
            GlobalManager.GetProducts();
            this.Parent.Parent.Parent.Controls[0].Controls[0].Controls.Clear();
            var x = GlobalManager.products;
            foreach (Product product in x)
            {

                ProductControl productControl = new ProductControl(product);
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
            purchasesPage purschase = new purchasesPage();
            this.Parent.Parent.Parent.Controls[0].Controls[0].Controls.Add(purschase);
        }

        private void Profilebtn_Click(object sender, EventArgs e)
        {
            Profile profile = new Profile();
            this.Parent.Parent.Parent.Controls[0].Controls[0].Controls.Clear();
            this.Parent.Parent.Parent.Controls[0].Controls[0].Controls.Add(profile);
        }

        private void ButtonContainer_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
