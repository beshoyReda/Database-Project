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
    internal partial class CartProduct : UserControl
    {
        CartedProduct product;
        int Q;
        float total;
        public CartProduct()
        {
            InitializeComponent();
        }
        public CartProduct(CartedProduct product)
        {
            Q = product.Quantity;
            total = product.total;
            this.product = product;
            InitializeComponent();
        }


        private void CardProduct_Load(object sender, EventArgs e)
        {
            ProdName.Text = product.name;
            ProdQ.Text = Q.ToString();
            Total.Text = total.ToString();  
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GlobalManager.cart.DeleteProduct(product);
            
            this.Dispose();
        }
    }
}
