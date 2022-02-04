using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseProject.models
{
    internal static class GlobalManager
    {
        public static Customer ActiveUser { get; set; }
        public static bool IsAdmin = false;
        public static Cart cart;
        public static List<string> imagePath = new List<string>();
        private static string path = @"C:\Users\Omar\source\repos\DatabaseProject\DatabaseProject\Assets\SlideshowImages";
        public static List<Product> products = new List<Product>();
        public static List<Product> favorites = new List<Product>();
        private static List<string> favoriteID = new List<string>();
        public static List<Invoice> UserInvoices = new List<Invoice>();

        public static bool InitializeApp()
        {
            try
            {
                
                DBController dbController = new DBController();
                Logger.Initialize();
                dbController.Initialize();
                imagePath.Add(Path.Combine(path, "Phone.jpeg"));
                imagePath.Add(Path.Combine(path, "Phone.jpeg"));
                imagePath.Add(Path.Combine(path, "Laptop.jpeg"));
                imagePath.Add(Path.Combine(path, "Headphone.jpg"));
                return true;
            }
            catch (Exception ex)
            {
                Logger.LogException(ex.ToString());
                return false;
            }


        }
        public static void SigninUser(Customer customer)
        {
            GetProducts();
            if (customer == null)
            {
                Logger.LogException("SIGN IN NULL USER");
            }
            else
            {
                ActiveUser = customer;
                cart = new Cart(customer);
                GetFavorites();
                GetInvoices();
            }
        }
        public static void SignOutUser()
        {
            if (ActiveUser == null)
            {
                Logger.LogException("SIGN OUT NULL USER");
            }
            else
            {
                ActiveUser = null;
                cart = null;
            }
        }
        public static void GetProducts()
        {
            string id = string.Empty;
            string name = string.Empty;
            string description = string.Empty;
            string Manf = string.Empty;
            string categoryId = string.Empty;
            string subCategory = string.Empty;
            int price;
            string inventoryID = string.Empty;
            int newQuantity;
            int reQuantity;

            DBController dBController = new DBController();

            try
            {
                string query = "call Get_All_Products()";
                if (dBController.OpenConnection())
                {
                    products.Clear();
                    MySqlCommand cmd = new MySqlCommand(query, dBController.connection);
                    MySqlDataReader dataReader = cmd.ExecuteReader();
                    while (dataReader.Read())
                    {

                        id = dataReader.GetString("product_number");
                        name = dataReader.GetString("product_Name");
                        description = dataReader.GetString("product_description");
                        Manf = dataReader.GetString("Manufacturer_Name");
                        categoryId = dataReader.GetString("Categorie_ID");
                        subCategory = dataReader.GetString("sub_categories_ID");
                        price = dataReader.GetInt32("product_Price");
                        inventoryID = dataReader.GetString("inventory_ID");
                        newQuantity = dataReader.GetInt32("New_quantity");
                        reQuantity = dataReader.GetInt32("Refurbished_quantity");
                        Product p = new Product(id, name, description, Manf, categoryId, subCategory, price, inventoryID,
                            newQuantity, reQuantity);
                        products.Add(p);
                        Console.WriteLine("sds" + id + " " + p.price);
                    }
                    dataReader.Close();
                    dBController.CloseConnection();
                }
            }
            catch (Exception e) { 
                Logger.LogException("Get Products" + " " + e.ToString());
            }

        }
        public static void AddToFavorites(Product product)
        {
            favorites.Add(product);
            DBController dBController = new DBController();

            try
            {
                string query = string.Format("call Add_favorite('{0}', '{1}')", ActiveUser.ID, product.id);
                if (dBController.OpenConnection())
                {
                    MySqlCommand cmd = new MySqlCommand(query, dBController.connection);
                    cmd.ExecuteNonQuery();
                    dBController.CloseConnection();
                }
            }
            catch (Exception ex) 
            { 
                Logger.LogException("Add Fav " + ex.ToString());    
            }
        }
        public static void RemoveFromFavorites(Product product)
        {
            for (int i = 0; i < favorites.Count; i++)
            {
                if (favorites[i].id == product.id)
                {
                    favorites.RemoveAt(i);
                }
            }
            DBController dBController = new DBController();

            try
            {
                string query = string.Format("call remove_favorite('{0}', '{1}')", ActiveUser.ID, product.id);
                if (dBController.OpenConnection())
                {
                    MySqlCommand cmd = new MySqlCommand(query, dBController.connection);
                    cmd.ExecuteNonQuery();
                    dBController.CloseConnection();
                }
            }
            catch (Exception ex)
            {
                Logger.LogException("Remove Fav " + ex.ToString());
            }
        }
        public static void GetFavorites()
        {
            DBController dBController = new DBController();
            try
            {
                string query = String.Format("call Get_Favorites({0})", ActiveUser.ID);
                if (dBController.OpenConnection())
                {
                    products.Clear();
                    MySqlCommand cmd = new MySqlCommand(query, dBController.connection);
                    MySqlDataReader dataReader = cmd.ExecuteReader();
                    while (dataReader.Read())
                    {   
                        favoriteID.Add(dataReader.GetString("product_number"));
                    }
                    dataReader.Close();
                    dBController.CloseConnection();
                }
                foreach (Product p in products)
                {
                    if (favoriteID.Contains(p.id))
                    {
                        favorites.Add(p);
                    }
                }
            }
            catch (Exception e)
            {
                Logger.LogException("Get Favorites" + " " + e.ToString());
            }
        }
        public static void GetInvoices()
        {


            DBController dBController = new DBController();

            try
            {
                string id = string.Empty;
                string customerID = string.Empty;
                string productID = string.Empty;
                int type = 0;
                float amount = 0;
                string date = string.Empty;
                int quantity = 0;
                int state = 0;
                string query = string.Format("call GetInv('{0}')", ActiveUser.ID);
                if (dBController.OpenConnection())
                {
                    products.Clear();
                    MySqlCommand cmd = new MySqlCommand(query, dBController.connection);
                    MySqlDataReader dataReader = cmd.ExecuteReader();
                    while (dataReader.Read())
                    {
                        id = dataReader.GetString("Inv_ID");
                        productID = dataReader.GetString("product_number");
                        type = dataReader.GetInt32("type_ID");
                        amount = dataReader.GetInt32("Amount");
                        date = dataReader.GetString("Inv_Date");
                        quantity = dataReader.GetInt32("Quantity");
                        state = dataReader.GetInt32("Return_State");
                        Invoice inv = new Invoice(id, ActiveUser.ID, productID, type, amount,quantity, state, date);
                        UserInvoices.Add(inv);
                    }
                    dataReader.Close();
                    dBController.CloseConnection();
                }
            }
            catch (Exception e)
            {
                Logger.LogException("Get Products" + " " + e.ToString());
            }

        }
    }
}
