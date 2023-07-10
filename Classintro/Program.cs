class Program
{

    static void Main(string[] args)
    {
        string adi = "halil";
        int yas = 32;

 

        Kurs kurs1 = new Kurs();
        kurs1.KursAdi = "C#";
        kurs1.Egitmen = "Halil Yildirim";
        kurs1.IzlenmeOrani = 321;

        Kurs kurs2 = new Kurs();
        kurs2.KursAdi = "C++";
        kurs2.Egitmen = "İbrahim Yildirim";
        kurs2.IzlenmeOrani = 22;

        Kurs kurs3 = new Kurs();
        kurs3.KursAdi = "Pyhton";
        kurs3.Egitmen = " Yildirim";
        kurs3.IzlenmeOrani = 33;

        Kurs[] kurslar = new Kurs[] {kurs1,kurs2,kurs3 };

        foreach (var kurs in kurslar)
        {
            Console.WriteLine(kurs.KursAdi + " : " +kurs.Egitmen+ " : "+kurs.IzlenmeOrani);
        }
    }
    class Kurs
    {
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int IzlenmeOrani { get; set; }
    }
}