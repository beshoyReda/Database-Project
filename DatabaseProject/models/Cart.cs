using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseProject.models
{
    internal class Cart
    {
        public string ID { get; }
        public Customer Customer { get; set; }
        public List<Product> Products { get; set;}
        public int Total { get; set; }

        public Cart()
        {
            Products = new List<Product>();
            Total = 0;
        }
        public Cart(Customer customer)
        {
            ID = Guid.NewGuid().ToString();
            Customer = customer;
            Products = new List<Product>();
            Total = 0;
        }
        public void AddProduct(Product product)
        {
            try
            {
                Products.Add(product);
                Total += product.price;
            }
            catch (Exception ex)
            {
                Logger.LogException(ex.Message);
            }

        }
        public void DeleteProduct(Product product)
        {
            try
            {
                Products.Remove(product);
                Total -= product.price;
            }
            catch (Exception ex)
            {
                Logger.LogException(ex.Message);
            }
        }
    }
}
