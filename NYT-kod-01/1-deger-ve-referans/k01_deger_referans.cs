using System;

namespace Uzay1
{
    public class Sinif1
    {
        // basit turler (public: bu sinifin nesnesini yaratan diger siniflar erisebilir)
        public int sayi = 0;
    }

    public class Test
    {
        static void Main()
        {
            // deger1 adinda yeni bir canta olustur, icerisine 0 koy
            int deger1 = 0;

            // deger2 adinda yeni bir canta olustur ve icerisine deger1
            // cantasindaki degerin aynisindan koy
            int deger2 = deger1;

            // deger2 cantasinin icindeki degeri at, yerine 123 koy
            deger2 = 123;

            // Sinif1 sinifina ait isimsiz bir valiz olustur ve bu valizin yerini
            // yeni olusturacagin referans1 adres defterinde (tutacaginda) tut

            // valizin icinde "sayi" adinda bir canta olusacak ve icinde 0 olacak.
            Sinif1 referans1 = new Sinif1();
            
            // referans2 diye yeni bir tutacak olustur ve icerisine referans1 de
            // tutulan adresin aynisini yaz
            Sinif1 referans2 = referans1;

            // referans2 tutacaginin gosterdigi yerdeki valizin icinde bulunan
            // "sayi" isimli cantanin icerisine 456 koy
            referans2.sayi = 456;

            Console.WriteLine("Degerler    : {0}, {1}", deger1, deger2);
            Console.WriteLine("Referanslar : {0}, {1}", referans1.sayi, referans2.sayi);
            System.Console.Read();
        }
    }
}
