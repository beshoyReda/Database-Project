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
    public partial class SignUpPopup : Form
    {
        public SignUpPopup()
        {
            InitializeComponent();
        }

        private void SignUpPopup_Load(object sender, EventArgs e)
        {
            Signuppage signuppage = new Signuppage();
            this.Controls.Add(signuppage);
        }
    }
}
