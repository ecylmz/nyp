using System;

namespace Uzay1
{
    static class Sinif1
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
            Sinif1.Fonksiyon1(); // dogru kullanim
            Console.ReadLine();
        }
    }
}
