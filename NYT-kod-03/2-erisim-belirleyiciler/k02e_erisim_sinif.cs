using System;

namespace Uzay1
{
    public class Sinif1
    {
        internal class Icsel1
        { // erisim : internal
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
            Console.ReadLine();
        }
    }
}
