using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTask
{
    public class Product
    {
        public string name;
        public string productName;
        public decimal price;

        public Product(string name, string productName, decimal price)
        {
            this.name = name;
            this.productName = productName;
            this.price = price;
        }
        public string Name()
        {
            return name;
        }
        public string ProductName()
        {
            return productName;
        }
        public decimal Price()
        {
            return price;
        }



    }
}
