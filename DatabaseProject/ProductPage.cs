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
    public partial class ProductPage : UserControl
    {
        public ProductPage()
        {
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
                int price = int.Parse(Pricelbl.Text.Trim());
                Qnumber.Text = Q.ToString();
                TotalAmount.Text = (Q * price).ToString();

            }
            catch (Exception ex)
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
                    int price = int.Parse(Pricelbl.Text.Trim());
                    Qnumber.Text = Q.ToString();
                    TotalAmount.Text = (Q * price).ToString();
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Incorrect Value");
            }

        }
    }
}
