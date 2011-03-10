using System;

namespace Uzay1
{
    class Sinif1
    {
        protected static void Fonksiyon1()
        { // protected erisimli statik fonksiyon
            Console.WriteLine("Merhaba dunya!");
            Console.ReadLine();
        }
    }
    class Sinif2 : Sinif1
    { // Sinif1 den kalitlayan Sinif2 sinifi
        static void Main()
        {
            Sinif1.Fonksiyon1(); // dogru: Sinif1'e ait
            // alttakiler de dogru, Sinif2' ye aitler
            // Fonksiyon1(); // dogru
            // Sinif2.Fonksiyon1(); // dogru
        }
    }
}
