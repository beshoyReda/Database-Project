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
    public partial class purchasesPage : UserControl
    {
        public purchasesPage()
        {
            InitializeComponent();
        }

        private void purchasesPage_Load(object sender, EventArgs e)
        {
            foreach (var x in GlobalManager.UserInvoices)
            {
                inv _inv = new inv(x);
                flowLayoutPanel1.Controls.Add(_inv);
            }
        }
    }
}
