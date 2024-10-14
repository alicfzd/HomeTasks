using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product[] products = new Product[]
            {
            new Product("Nestle", "Coffee", 5.99m),
            new Product("Lipton", "Çay", 1.50m),
            new Product("7days", "Şirniyyat", 5.00m),
            new Product("Lays", "Cips", 3.00m)
            };

            double minPrice = 1.00;
            double maxPrice = 2.00;

            PrintProducts(products, minPrice, maxPrice);
        }

        static void PrintProducts(Product[] products, double minPrice, double maxPrice)
        {
            foreach (var product in products)
            {
                decimal price = product.Price();
                if (price >= (decimal)minPrice && price <= (decimal)maxPrice)
                {
                    Console.WriteLine($"Name: {product.Name()}, Product Name: {product.ProductName()}, Price: {price}");
                }
            }
        }
    }
}

