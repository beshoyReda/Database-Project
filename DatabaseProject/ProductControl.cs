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
    internal partial class ProductControl : UserControl
    {
        Product product; 
        bool favorited = false;
        public ProductControl()
        {
            InitializeComponent();
        }
        public ProductControl(Product _product)
        {
            if (_product != null)
            {
                product = _product;
                if (GlobalManager.favorites.Contains(product))
                {
                    favorited = true;
                }
                else
                {
                    favorited = false;
                }
                InitializeComponent();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (favorited)
            {
                favorited = !favorited;
                Favorite.BackgroundImage = Image.FromFile(@"C:\Users\Omar\source\repos\Database-Project\DatabaseProject\Assets\heart (3).png");
                GlobalManager.AddToFavorites(product);
            }
            else
            {
                favorited = !favorited;
                Favorite.BackgroundImage = Image.FromFile(@"C:\Users\Omar\source\repos\Database-Project\DatabaseProject\Assets\heart (2).png");
                GlobalManager.RemoveFromFavorites(product);
            }
            
            
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            ProductPopUp productPage = new ProductPopUp(product);
            productPage.Show();
            
            

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void ProductControl_Load(object sender, EventArgs e)
        {
            ProductName.Text = product.name;
            Price.Text = product.price.ToString();
        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            GlobalManager.cart.AddProduct(new CartedProduct(product, 1, 0));
        }
    }
}
