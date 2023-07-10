using Methods;
using System;

namespace Methods
{
    class Program
    {

        static void Main(string[] args)
        {
            string productName = "Apple";
            double price = 23;
            string productExp = "Amasya's apple";

            string[] fruits = new string[] { "Apple,Watermelon" };

            Product product1 = new Product();
            product1.Name = "Apple";
            product1.Price = 23;
            product1.Explanation = "Amasya's apple";

            Product product2 = new Product();
            product2.Name = "Watermelon";
            product2.Price = 13;
            product2.Explanation = "diyarbekir's Watermelon";

            Product[] products = new Product[] { product1, product2 };

            foreach (var product in products)
            {
                Console.WriteLine(product.Name);
                Console.WriteLine(product.Price);
                Console.WriteLine(product.Explanation);
                Console.WriteLine("-----------------------");
            }
            Console.WriteLine("---------------METHODS----------");
            //instance example
            //encapsulation
            SepetManager sepetManager = new SepetManager();
            sepetManager.Add(product1);
            sepetManager.Add(product2);

            sepetManager.Add2("Pear", "Green Pear", 14,2);
            sepetManager.Add2("Watermelon", "diyarbekir's Watermelon", 13,3);
            sepetManager.Add2("Apple", "Amasya's apple", 23,5);
        }
    }

}
