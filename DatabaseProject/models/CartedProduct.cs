using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseProject.models
{
    internal class CartedProduct
    {
        public Product product { get; set; }
        public string name { get; set; }
        public int Quantity { get; set; }
        public float total { get; set; }
        public int state { get; set; }

        public CartedProduct()
        {

        }
        public CartedProduct(Product product, int Q, int s)
        {
            this.product = product;
            name = product.name;
            Quantity = Q;
            total = (Q * product.price);
            state = s;
        }
    }
}
