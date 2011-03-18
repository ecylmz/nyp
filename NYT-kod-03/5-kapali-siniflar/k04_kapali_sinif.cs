using System;

namespace Uzay1
{
    public class Sinif1
    {
        public static int deger = 6;

        public static void Fonksiyon1()
        {
            Console.WriteLine("Sinif1 > Fonksiyon1");
        }
    }

    sealed class Sinif2:Sinif1
    { // kapali siniflar miras alabilirler
        static void Main()
        {
            Fonksiyon1();
            Console.ReadLine();
        }
    }
}
