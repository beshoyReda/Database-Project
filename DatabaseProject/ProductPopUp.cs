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
    internal partial class ProductPopUp : Form
    {
        Product product; 
        public ProductPopUp()
        {
            InitializeComponent();
        }
        public ProductPopUp(Product _product)
        {
            product = _product;
            InitializeComponent();
        }

        private void ProductPageCon_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ProductPopUp_Load(object sender, EventArgs e)
        {
            ProductPage productPage = new ProductPage(product);
            ProductPageCon.Controls.Add(productPage);
        }
    }
}
