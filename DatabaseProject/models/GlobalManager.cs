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
        public static Cart cart { get; set; }
        public static List<string> imagePath = new List<string>();
        private static string path = @"C:\Users\Omar\source\repos\DatabaseProject\DatabaseProject\Assets\SlideshowImages";

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
            if (customer == null)
            {
                Logger.LogException("SIGN IN NULL USER");
            }
            else
            {
                ActiveUser = customer;
                cart = new Cart();
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
                cart = new Cart();
            }
        }
    }
}
