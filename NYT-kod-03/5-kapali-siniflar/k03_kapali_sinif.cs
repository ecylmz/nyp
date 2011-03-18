using System;

namespace Uzay1
{
    public sealed class Sinif1
    { // kapali sinif
        public int deger = 6;

        public void Fonksiyon1()
        {
            Console.WriteLine("Sinif1 > Fonksiyon1");
        }
    }

    class Sinif2
    { // dogru kullanim
        static void Main()
        { // kapali siniflarin nesnesi yaratilabilir
            Sinif1 nesne1 = new Sinif1();
            nesne1.Fonksiyon1();
            Console.ReadLine();
        }
    }
}

