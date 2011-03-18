using System;

namespace Uzay1
{
    public class Sinif1
    {
        class Icsel1
        { // erisim : private
            public static void Fonksiyon1()
            {
                Console.WriteLine("Sinif1.Icsel1 > Fonksiyon1");
            }
        }
    }

    class Sinif2
    {
        static void Main()
        {
            Sinif1.Icsel1.Fonksiyon1(); // hata: erisim yok
            Sinif1 nesne1 = new Sinif1();
            Console.ReadLine();
        }
    }
}
