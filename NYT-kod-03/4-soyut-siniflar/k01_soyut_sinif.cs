using System;

namespace Uzay1
{
    public abstract class Sinif1
    { // soyut sinif
        public int deger = 6;

        public void Fonksiyon1()
        {
            Console.WriteLine("Sinif1 > Fonksiyon1");
        }
    }

    class Sinif2
    {
        static void Main()
        { // hata: soyut siniflarin nesnesi yaratilamaz
            Sinif1 nesne1 = new Sinif1();
            nesne1.Fonksiyon1();
            Console.ReadLine();
        }
    }
}
