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
    internal partial class ProductPage : UserControl
    {
        Product product;
        bool New = true;
        float originalPrice;
        public ProductPage()
        {
            InitializeComponent();
        }
        public ProductPage(Product _product)
        {

            product = _product;
            originalPrice = product.price;
            InitializeComponent();
        }
        private void State_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Parent.Parent.Dispose();
        }

        private void Addbtn_Click(object sender, EventArgs e)
        {
            try
            {
                int Q = int.Parse(Qnumber.Text.Trim());
                Q = (Q + 1);
                if ((Q <= product.newQuantity && comboBox1.SelectedIndex == 0) || (Q <= product.reQuantity && comboBox1.SelectedIndex == 1))
                {
                    float price = product.price;
                    Qnumber.Text = Q.ToString();
                    TotalAmount.Text = (Q * price).ToString();
                }
                

            }
            catch (Exception)
            {
                MessageBox.Show("Incorrect Value");
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int Q = int.Parse(Qnumber.Text.Trim());
                if (Q > 1)
                {
                    Q = (Q - 1);
                    float price = float.Parse(Pricelbl.Text.Trim());
                    Qnumber.Text = Q.ToString();
                    TotalAmount.Text = (Q * price).ToString();
                }


            }
            catch (Exception)
            {
                MessageBox.Show("Incorrect Value");
            }

        }

        private void ProductPage_Load(object sender, EventArgs e)
        {

            ProductName.Text = product.name;
            Pricelbl.Text = product.price.ToString();
            TotalAmount.Text = product.price.ToString();
            Description.Text += product.description;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0 && !New)
            {
                product.price = originalPrice;
                TotalAmount.Text = product.price.ToString();
                New = true;
            }
            else if (comboBox1.SelectedIndex == 1 && New)
            {
                product.price = (float)(product.price * 0.85);
                TotalAmount.Text = product.price.ToString();
                New = false;
            }
        }

        private void Qnumber_TextChanged(object sender, EventArgs e)
        {
            int Q = 0;
            Q = int.Parse(Qnumber.Text.Trim());
            if (Q >= product.newQuantity && comboBox1.SelectedIndex == 0)
            {
                Qnumber.Text = product.newQuantity.ToString();
                Q = int.Parse(Qnumber.Text.Trim());
                TotalAmount.Text = (Q * product.price).ToString();
            }
            else if (Q >= product.reQuantity && comboBox1.SelectedIndex == 1)
            {
                Qnumber.Text = product.reQuantity.ToString();
                Q = int.Parse(Qnumber.Text.Trim());
                TotalAmount.Text = (Q * product.price).ToString();
            } 
            else if (Q <= product.newQuantity && comboBox1.SelectedIndex == 0)
            {
                TotalAmount.Text = (Q * product.price).ToString();
            }
            else if (Q <= product.reQuantity && comboBox1.SelectedIndex == 1)
            {
                TotalAmount.Text = (Q * product.price).ToString();
            }
        }

        private void AddToCart_Click(object sender, EventArgs e)
        {
            int Q = int.Parse(Qnumber.Text.Trim());
            GlobalManager.cart.AddProduct(new CartedProduct(product, Q, comboBox1.SelectedIndex));
        }
    }
}
