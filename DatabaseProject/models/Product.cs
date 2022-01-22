using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseProject.models
{
    internal class Product
    {
        public string id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string ManId { get; set; }
        public string categoryId { get; set; }
        public string subCategory { get; set; }
        public int price { get; set; }
        public string inventoryID { get; set; }
        public int state { get; set; }
        public int newQuantity { get; set; }
        public int reQuantity { get; set; }

        public Product() { }

        public Product(string _id, string _name, string _description, string manid, string _categoryId, string _subCategory, int _price, string _inventoryID, int newS, int usedS)
        {
            id = _id;
            name = _name;
            description = _description;
            ManId = manid;
            categoryId = _categoryId;
            subCategory = _subCategory;
            price = price;
            inventoryID = _inventoryID;
            newQuantity = newS;
            reQuantity = usedS;
        }
    }
}
