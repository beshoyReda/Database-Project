using MySql.Data.MySqlClient;
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
        public List<CartedProduct> Products { get; set;}
        public float Total { get; set; }
        public int installment { get; set; }

        public Cart()
        {
            Products = new List<CartedProduct>();
            Total = 0;
        }
        public Cart(Customer customer)
        {
            ID = Guid.NewGuid().ToString();
            Customer = customer;
            Products = new List<CartedProduct>();
            Total = 0;
        }
        public void AddProduct(CartedProduct product)
        {
            try
            {
                Products.Add(product);
                Total += product.total;
            }
            catch (Exception ex)
            {
                Logger.LogException(ex.Message);
            }

        }
        public void DeleteProduct(CartedProduct product)
        {
            try
            {
                Products.Remove(product);
                Total -= product.total;
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
            string InvoiceID = ID;
            string date = DateTime.Now.ToString("yyyy-MM-dd");
            foreach (var product in Products)
            {
                
                float t = product.total;
                Invoice invoice = new Invoice(InvoiceID, Customer.ID, product.product.id, installment, t, product.Quantity, product.state, date);
                list.Add(invoice); 
            }
            return list;
        }
        public List<Invoice> Checkout(int ins)
        {
            installment = ins;
            List<Invoice> list = GetInvoices();
            try
            {
                DBController dBController = new DBController();
                if (dBController.OpenConnection())
                {
                    foreach(Invoice invoice in list)
                    {
                        string query = string.Format("call Buy_Product('{0}', '{1}','{2}', '{3}', '{4}', {5}, {6}, '{7}', {8})",
                                       invoice.customerID, invoice.id, invoice.productID, invoice.quantity, invoice.date, invoice.state, invoice.type, invoice.state, invoice.amount);
                        MySqlCommand cmd = new MySqlCommand(query, dBController.connection);
                        cmd.ExecuteNonQuery();
                        dBController.CloseConnection();
                    }
                }
            }
            catch (Exception ex) 
            { 
                Logger.LogException(ex.Message);
            }
            return list;
        }
    }
}
