using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class SepetManager
    {
        //nameing convention
        public void Add(Product product)
        {
            Console.WriteLine(product.Name + " Added to cart");

        }
        public void Add2(string productName, string explanation, double price, int stockQuantity)
        {
            Console.WriteLine(productName + " Added to cart");
        }
    }
}
