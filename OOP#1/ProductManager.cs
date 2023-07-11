using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_1
{
     class ProductManager
    {
        //encapsulation
        public void Add(Product product)
        {
            Console.WriteLine(product.ProductName + "Added.");

        }
        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName + "Updated.");

        }


    }
}
