using System;

namespace Uzay1
{
    public class Sinif1
    {
        public class Icsel1
        { // erisim : public
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
            Sinif1.Icsel1.Fonksiyon1();
            Sinif1 nesne1 = new Sinif1();
            Console.ReadLine();
        }
    }
}
