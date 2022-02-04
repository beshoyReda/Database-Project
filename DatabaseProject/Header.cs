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
    public partial class Header : UserControl
    {
        int counter = 0;
        public Header()
        {
            InitializeComponent();
        }

        private void SlideShowTimer_Tick(object sender, EventArgs e)
        {
            counter = ((counter + 1) % 4) ;
            SlideShow.BackgroundImage = Image.FromFile(GlobalManager.imagePath[counter]); ;
            SlideShow.BackgroundImageLayout = ImageLayout.Zoom;
            SlideShowTimer.Enabled = true;
        }

        private void Header_Load(object sender, EventArgs e)
        {
        }

        private void SlideShow_Click(object sender, EventArgs e)
        {

        }

        private void NextPic_Click(object sender, EventArgs e)
        {
            counter = ((counter + 1) % 4);
            SlideShow.BackgroundImage = Image.FromFile(GlobalManager.imagePath[counter]); ;
            SlideShow.BackgroundImageLayout = ImageLayout.Zoom;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (counter == 0)
            {
                counter = 3;
            }
            else
            {
                counter = ((counter - 1) % 4);
            }
            SlideShow.BackgroundImage = Image.FromFile(GlobalManager.imagePath[counter]); ;
            SlideShow.BackgroundImageLayout = ImageLayout.Zoom;
        }

        private void LogOut_Click(object sender, EventArgs e)
        {
            LoginPage loginPage = new LoginPage();
            loginPage.Show();
            this.Parent.Parent.Parent.Dispose();
        }

        private void SearchHeader_Click(object sender, EventArgs e)
        {
            Search search = new Search();   
            this.Parent.Parent.Controls[0].Controls.Clear();
            this.Parent.Parent.Controls[0].Controls.Add(search);
        }

        private void FavoritesHeader_Click(object sender, EventArgs e)
        {
            GlobalManager.GetFavorites();
            this.Parent.Parent.Controls[0].Controls.Clear();
            int i = 0;

            foreach (var p in GlobalManager.favorites)
            {
                Console.WriteLine(i++);
                ProductControl product = new ProductControl(p);
                this.Parent.Parent.Controls[0].Controls.Add(product);
            }
        }
    }
}
