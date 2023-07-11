using OOP_1;
using System;

namespace OOP1
{
    class program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2; //mobilya
            product1.ProductName = "Table";
            product1.UnitPrice = 500;
            product1.UnitStock = 3;

            Product product2 = new Product {Id=2,CategoryId=5,UnitStock=5,
               ProductName="Pencil", UnitPrice=22};

            //PascalCase   //CamelCase   //case sensetive
            ProductManager productManager = new ProductManager();
            productManager.Add(product1);
            //int,double,bool,float... DEĞER TİP
            //diziler,class,abstract class, interface... REFERANS TİP



        }

    }


}
