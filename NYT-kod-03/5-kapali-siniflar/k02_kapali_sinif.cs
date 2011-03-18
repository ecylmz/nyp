using System;

namespace Uzay1
{
    public sealed class Sinif1
    { // kapali sinif
        public static int deger = 6;

        public static void Fonksiyon1()
        {
            Console.WriteLine("Sinif1 > Fonksiyon1");
        }
    }

    class Sinif2
    { // dogru kullanim
        static void Main()
        {
            Sinif1.Fonksiyon1();
            Console.ReadLine();
        }
    }
}
