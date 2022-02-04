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
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
            loadSidePanel();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            load_products();
        }

        private void ButtonContainer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Content_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ProductContainer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ProductContainer_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void MainPage_Load(object sender, EventArgs e)
        {
            load_products();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            ProductContainer.Controls.Clear();
            CartControl cart = new CartControl();
            ProductContainer.Controls.Add(cart);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ProductContainer.Controls.Clear();
            wallet walt = new wallet();
            ProductContainer.Controls.Add(walt);
        }

        private void load_products()
        {
            GlobalManager.GetProducts();
            Header header = new Header();
            Header.Controls.Add(header);
            ProductContainer.Controls.Clear();
            var x = GlobalManager.products;
            foreach (Product product in x)
            {
                if (product != null)
                {
                    ProductControl productControl = new ProductControl(product);
                    productControl.Margin = new Padding(5, 5, 5, 5);
                    ProductContainer.Controls.Add(productControl);
                    Console.WriteLine("loop" + product.price);
                }

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Profile profile = new Profile();
            ProductContainer.Controls.Clear();
            ProductContainer.Controls.Add(profile);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void loadSidePanel()
        {
            if (GlobalManager.IsAdmin)
            {
                SidePanelContainer.Controls.Add(new AdminSidebar());
                Content.Controls.Clear();
                Content.Controls.Add(new AdminProducts());
            }
            else
            {
                SidePanelContainer.Controls.Add(new Usersidebar());
                load_products();
            }
        }
    }
}
