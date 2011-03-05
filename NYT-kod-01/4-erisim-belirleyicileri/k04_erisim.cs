using System;

namespace Uzay1
{
    public class Sinif1
    {// Uzay1 isim uzayi icerisinde Sinif1 sinifi
        public int a = 5;    // diger siniflardan erisilebilir
        private int b = 6;   // sadece bu siniftan erisilebilir

        // bu sinif ve bundan kalitlayan siniflardan erisilebilir
        protected int c = 7;

        // hicbir sey yazilmazsa private gibi islem gorur.
        int d = 8;
    }

    public class Sinif2
    {
        static void Main()
        {
            Sinif1 nesne1 = new Sinif1();
            Console.WriteLine(nesne1.a); // Dogru
            Console.WriteLine(nesne1.b); // hatali: erisim hakki yok 
            Console.WriteLine(nesne1.c); // hatali: erisim hakki yok
            Console.WriteLine(nesne1.d); // hatali: erisim hakki yok
            System.Console.Read();
        }
    }
}
