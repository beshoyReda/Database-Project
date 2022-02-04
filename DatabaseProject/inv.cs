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
    internal partial class inv : UserControl
    {
        public Invoice invoice;
        public inv()
        {
            InitializeComponent();
        }
        public inv(Invoice invoice)
        {
            this.invoice = invoice;
            InitializeComponent();
        }

        private void inv_Load(object sender, EventArgs e)
        {
            if (invoice != null)
            {
                Item.Text = invoice.id;
                Date.Text = invoice.date;
                Total.Text = invoice.amount.ToString();
            }
        }
    }
}
