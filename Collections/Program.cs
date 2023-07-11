using System;
using System.Collections.Generic;

namespace Collections
{
    class program
    {
        static void Main(string[] args)
        {
            List<string> isimler2 = new List<string> {"Adana","Osmaniye","Bayburt","Çanakkale"};
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[3]);
            isimler2.Add("Aydın");
            Console.WriteLine(isimler2[4]);
            Console.WriteLine(isimler2[0]);   
            

        }

    }

}