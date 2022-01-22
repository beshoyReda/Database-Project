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
    public partial class ProductPopUp : Form
    {
        public ProductPopUp()
        {
            InitializeComponent();
        }

        private void ProductPageCon_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ProductPopUp_Load(object sender, EventArgs e)
        {
            ProductPage productPage = new ProductPage();
            ProductPageCon.Controls.Add(productPage);
        }
    }
}
