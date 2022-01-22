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
        public int installment { get; set; }

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
        public List<Invoice> GetInvoices()
        {
            if (Products == null)
            {
                Logger.LogException("Null product list");
                return null;
            }
            List<Invoice> list = new List<Invoice>();
            DateTime date = DateTime.Now;
            string InvoiceID = Guid.NewGuid().ToString();
            foreach (Product product in Products)
            {
                int quantity = Products.FindAll(delegate(Product p){ return p.id == product.id && p.state == product.state;}).Count();
                Products.RemoveAll(delegate (Product p) { return p.id == product.id && p.state == product.state; });
                int t = product.price * quantity;
                Invoice invoice = new Invoice(InvoiceID, Customer.ID, product.id, installment, date, t, quantity, product.state);
                list.Add(invoice); 
            }
            return list;
        }
        public List<Invoice> Checkout(int ins)
        {
            installment = ins;
            List<Invoice> list = GetInvoices();
            return list;
        }
    }
}
