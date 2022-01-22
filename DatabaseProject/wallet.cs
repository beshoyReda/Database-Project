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
    public partial class wallet : UserControl
    {
        public wallet()
        {
            InitializeComponent();
        }

        private void wallet_Load(object sender, EventArgs e)
        {
            Purchases purchases = new Purchases();
            PurchasesPanal.Controls.Add(purchases);
            purchases = new Purchases();
            PurchasesPanal.Controls.Add(purchases);
            purchases = new Purchases();
            PurchasesPanal.Controls.Add(purchases);
        }
    }
}
