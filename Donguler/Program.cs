class Program
{

    static void Main(string[] args)
    {

        string kurs2 = "java";
        string kurs1 = "c#";
        string kurs3 = "c++";


        string[] kurslar = new string[] {"java", "c#","c++"};

        for (int i = 0; i < kurslar.Length; i++)
        {
            Console.WriteLine(kurslar[i]);       
        }
        Console.WriteLine("for bitti");
        foreach (string kurs in kurslar)
        {
            Console.WriteLine(kurs); 
        }
        Console.WriteLine("sayfa sonu,footer");
    }
}