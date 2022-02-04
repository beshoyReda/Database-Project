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
        public string Manf { get; set; }
        public string categoryId { get; set; }
        public string subCategory { get; set; }
        public float price { get; set; }
        public string inventoryID { get; set; }
        public int state { get; set; }
        public int newQuantity { get; set; }
        public int reQuantity { get; set; }

        public Product() { }

        public Product(string _id, string _name, string _description, string manid, string _categoryId, string _subCategory, float _price, string _inventoryID, int newS, int usedS)
        {
            id = _id;
            name = _name;
            description = _description;
            Manf = manid;
            categoryId = _categoryId;
            subCategory = _subCategory;
            price = _price;
            inventoryID = _inventoryID;
            newQuantity = newS;
            reQuantity = usedS;
        }
    }
}
