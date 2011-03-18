using System;

namespace Uzay1
{
    public class Sinif1
    {
        protected class Icsel1
        { // erisim : protected
            public static void Fonksiyon1()
            {
                Console.WriteLine("Sinif1.Icsel1 > Fonksiyon1");
            }
        }
    }

    class Sinif2:Sinif1
    { // Sinif2 Sinif1' den miras alir
        static void Main()
        {
            Sinif1.Icsel1.Fonksiyon1();
            Console.ReadLine();
        }
    }
}



