using System;

namespace GitProjekt2B
{
    class Program
    {
        static void Main(string[] args)
        {
            Osoba o = new Osoba();
            o.Jmeno = "Zděněk";
            o.Prijmeni = "Jendřejčík";
            o.DatumNarozeni = DateTime.Parse("01.01.2022");
            Console.WriteLine(o.GetVek());
            Console.ReadKey();
        }
    }
}
