using System;

namespace Uzay1
{
    public abstract class Sinif1
    { // soyut sinif
        public static int deger = 6;

        public static void Fonksiyon1()
        {
            Console.WriteLine("Sinif1 > Fonksiyon1");
        }
    }

    class Sinif2:Sinif1
    { // soyut siniflardan miras alinabilir
        static void Main()
        {
            Fonksiyon1();
            Console.ReadLine();
        }
    }
}
