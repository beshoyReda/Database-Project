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
    public partial class AdminProducts : UserControl
    {
        public AdminProducts()
        {
            InitializeComponent();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void ControlContainer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AdminProducts_Load(object sender, EventArgs e)
        {
            ProductSearchAdmin productSearchAdmin = new ProductSearchAdmin();
            ControlContainer.Controls.Clear();
            ControlContainer.Controls.Add(productSearchAdmin);
        }

        private void Searchbtn_Click(object sender, EventArgs e)
        {
            ProductSearchAdmin productSearchAdmin = new ProductSearchAdmin();
            ControlContainer.Controls.Clear();
            ControlContainer.Controls.Add(productSearchAdmin);
        }

        private void Addbtn_Click(object sender, EventArgs e)
        {
            ProductManageAdmin productManageAdmin = new ProductManageAdmin();
            ControlContainer.Controls.Clear();
            ControlContainer.Controls.Add(productManageAdmin);
        }
    }
}
