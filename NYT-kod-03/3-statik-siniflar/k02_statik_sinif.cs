using System;

namespace Uzay1
{
    public static class Sinif1
    { // statik sinif
        public static int deger = 6;

        public static void Fonksiyon1()
        {
            Console.WriteLine("Sinif1 > Fonksiyon1");
        }
    }

    class Sinif2
    {
        static void Main()
        {
            Console.WriteLine("Sinif1 > deger : {0}", Sinif1.deger);
            Sinif1.Fonksiyon1();
            Console.ReadLine();
        }
    }
}
