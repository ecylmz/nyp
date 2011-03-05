using System;

namespace Uzay1
{
    public class Sinif1
    {// Uzay1 isim uzayi icerisinde Sinif1 sinifi
        public int a = 5;    // diger siniflardan erisilebilir
        private int b = 6;   // sadece bu siniftan erisilebilir
 
        // bu sinif ve bundan kalitlayan siniflardan erisilebilir
        protected int c = 7;
        
        
        // public yazilmazsa private static gibi islem gorur
        static int d = 8;
        
         // bu sinifin nesnesi uzerinden erisilmeli
         public static int e = 9;
    }
    
    public class Sinif2
    {
        static void Main()
        {   
            // Burada sinifin bir nesnesi olusturulmamis.
            // Direkt sinifin ismini vererek alt alanlarina erisilmek isteniyor.
            Console.WriteLine(Sinif1.a); // hatali: erisim hakki yok
            Console.WriteLine(Sinif1.b); // hatali: erisim hakki yok 
            Console.WriteLine(Sinif1.c); // hatali: erisim hakki yok
            Console.WriteLine(Sinif1.d); // hatali: erisim hakki yok
            Console.WriteLine(Sinif1.e); // Dogru
            System.Console.Read();
        }
    }
}
