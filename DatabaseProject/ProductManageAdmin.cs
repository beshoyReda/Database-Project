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
    public partial class ProductManageAdmin : UserControl
    {
        private int PickedCategory = 0;
        private List<string> subCats = new List<string>();
        public ProductManageAdmin()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                DBController dBController = new DBController();
                string id = Guid.NewGuid().ToString();
                string manid = GetManID();
                string query = string.Format("insert into product values('{0}', '{1}','{2}', '{3}', '{4}', {5}, {6}, '{7}')",
                        id, manid, ProductName.Text.ToLower().Trim(), DescBox.Text.ToLower().Trim(), PickedCategory,0,  PriceBox.Text.ToLower().Trim(), SubCateg.SelectedIndex + 1);
                
                if (dBController.OpenConnection())
                {
                    Console.WriteLine("here");
                    MySqlCommand cmd = new MySqlCommand(query, dBController.connection);
                    cmd.ExecuteNonQuery();
                    dBController.CloseConnection();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Logger.LogException(ex.Message);    
            }

        }

        private string GetManID()
        {
            string man = Manu.Text.ToLower().Trim();
            string id = string.Empty;
            DBController dBController = new DBController();
            string query = "SELECT * FROM manufacturer";
            if (dBController.OpenConnection())
            {
                MySqlCommand cmd = new MySqlCommand(query, dBController.connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    if (man == dataReader.GetString("Manufacturer_Name").ToLower().Trim())
                    {
                        id = dataReader.GetString("Manufacturer_ID");
                        dataReader.Close();
                        dBController.CloseConnection();
                        return id;
                    }
                }
                dataReader.Close();
                string mnid = Guid.NewGuid().ToString();
                query = string.Format("INSERT INTO manufacturer (Manufacturer_ID, Manufacturer_Name) VALUES('{0}', '{1}')",mnid, man);
                cmd = new MySqlCommand(query, dBController.connection);
                cmd.ExecuteNonQuery();
                
                dBController.CloseConnection();
                return mnid;

            }
            else throw new Exception("Cannot connect to DB");
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Categ_SelectedIndexChanged(object sender, EventArgs e)
        {
            PickedCategory = Categ.SelectedIndex + 1;
            LoadSubCateg();
            Console.WriteLine("here");
        }
        private void LoadSubCateg()
        {
            int Picked = PickedCategory;
            subCats.Clear();    
            DBController dBController = new DBController();
            string query = "SELECT * FROM sub_categories where Categorie_ID = " + Picked.ToString() ;
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
            foreach ( string cat in subCats)
            {
                SubCateg.Items.Add(cat);
            }
        }

        private void ControlContainer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ProductManageAdmin_Load(object sender, EventArgs e)
        {
            for (var x = 0; x < ControlContainer.Controls.Count; x++)
            {
                ControlContainer.Controls[x].Enabled = true;
                Console.WriteLine("here");
            }
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
    }
}
