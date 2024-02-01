using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bi3
{
    internal class Products
    {
        public string productname;
        public float productprice;
        public int productquantity;
        public Products(string itemName, float price, int quantity) {
            productname = itemName;
            productprice = price;
            productquantity = quantity;
        }
    }
}
