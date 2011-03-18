using System;

namespace Uzay1
{
    class Sinif1
    {
        public static int deger = 6;

        public static void Fonksiyon1()
        {
            Console.WriteLine("Sinif1 > Fonksiyon1");
        }
    }

    class Sinif2
    { // erisim: internal
        static void Main()
        {
            Console.WriteLine("Sinif1 > deger", Sinif1.deger);
            Sinif1.Fonksiyon1();
            Console.ReadLine();
        }
    }
}
