using System;

namespace Uzay1
{
    public class Sinif1
    {
        public delegate int Temsilci1(int s1, int s2);
        // arguman olarak 2 tamsayi alan tum fonksiyonlari
        // temsil edebilecek bir temsilci

        public static int Fonksiyon1(int sayi1, int sayi2)
        { // Sinif1 e ait, toplama yapan  Fonksiyon1 fonk. (statik)
            return (sayi1 + sayi2);
        }

        public static int Fonksiyon2(int sayi1, int sayi2)
        { // Sinif1 e ait, carpma yapan  Fonksiyon2 fonk. (statik)
            return (sayi1 * sayi2);
        }
    }

    public class Sinif2
    {
        static void Main()
        {
            int sonuc1 = 0, sonuc2 = 0;

            // Sinif1' deki Temsilci1 tipinde 'topla' isminde bir temsilci
            // olustur ve bununla Sinif1' deki Fonksiyon1' i temsil et
            Sinif1.Temsilci1 topla = new Sinif1.Temsilci1(Sinif1.Fonksiyon1);
            // temsilciyi fonksiyon gibi kullan
            sonuc1 = topla(7, 9);
            Console.WriteLine("7 ile 9 un toplami : {0}\n", sonuc1);

            Sinif1.Temsilci1 carp = new Sinif1.Temsilci1(Sinif1.Fonksiyon2);
            sonuc2 = carp(7, 9);
            Console.WriteLine("7 ile 9 un carpimi : {0}", sonuc2);

            System.Console.Read();
        }
    }
}

