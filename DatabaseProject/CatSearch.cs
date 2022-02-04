using DatabaseProject.models;
using MySql.Data.MySqlClient;
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
    public partial class CatSearch : UserControl
    {
        private int PickedCategory = 0;
        private int PickedSubCategory = 0;
        private List<string> subCats = new List<string>();
        public CatSearch()
        {
            InitializeComponent();
        }

        private void CatSearch_Load(object sender, EventArgs e)
        {
            LoadCategs();
        }
        private void LoadCategs()
        {
            DBController dBController = new DBController();
            string query = "SELECT * FROM categories order by Categorie_ID ASC";
            if (dBController.OpenConnection())
            {

                MySqlCommand cmd = new MySqlCommand(query, dBController.connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    Console.WriteLine("here");
                    Categ.Items.Add(dataReader.GetString("Categories_Name"));
                }
                dataReader.Close();
                dBController.CloseConnection();
            }
            else throw new Exception("Cannot connect to DB");
            SubCateg.Items.Clear();
            foreach (string cat in subCats)
            {
                SubCateg.Items.Add(cat);
            }


        }
        private void LoadSubCateg()
        {
            int Picked = PickedCategory;
            subCats.Clear();
            DBController dBController = new DBController();
            string query = "SELECT * FROM sub_categories where Categorie_ID = " + Picked.ToString();
            if (dBController.OpenConnection())
            {

                MySqlCommand cmd = new MySqlCommand(query, dBController.connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    subCats.Add(dataReader.GetString("sub_categories_Name"));
                }
                dataReader.Close();
                dBController.CloseConnection();
            }
            else throw new Exception("Cannot connect to DB");
            SubCateg.Items.Clear();
            foreach (string cat in subCats)
            {
                SubCateg.Items.Add(cat);
            }
        }

        private void Categ_SelectedIndexChanged(object sender, EventArgs e)
        {
            PickedCategory = Categ.SelectedIndex + 1;
            LoadSubCateg();
            Console.WriteLine("here");

        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            foreach (var p in GlobalManager.products)
            {
                if (p.categoryId == PickedCategory.ToString() && p.subCategory == (SubCateg.SelectedIndex + 1).ToString())
                {
                    this.Parent.Controls.Add(new ProductControl(p));
                }
            }
        }
    }
}
