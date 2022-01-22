using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseProject.models
{
    internal class Invoice
    {
        public string id { get; set; }
        public string customerID { get; set; }
        public string productID { get; set; }
        public int type { get; set; }
        public DateTime created { get; set; }
        public float amount { get; set; }
        public int quantity { get; set; }
        public int state { get; set; }

        public Invoice()
        {

        }
        public Invoice(string id, string cusID, string prodID, int type, DateTime date, float amount, int q, int _state)
        {
            this.id = id;
            this.customerID = cusID;
            this.productID = prodID;
            this.type = type;
            this.created = date;
            this.amount = amount;
            this.quantity = q;
            this.state = _state;
        }
    }
}
