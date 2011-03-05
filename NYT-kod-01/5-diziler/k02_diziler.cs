using System;

namespace Uzay1
{
    public class Sinif1
    {
        static void Main()
        {
            // bellekte 3 elemanli bir tamsayi dizisi icin yer ayir ve bu yerin
            // baslangic adresini a2 tutacagina kaydet
            int[] a2 = new int[3];

            // a2 dizisinin indekslerine atama yap
            a2[0] = 35;
            a2[1] = 55;
            a2[2] = 60;

            // a3 dizisi icin yapilan islemler, a2 icin yapilanlarla birebir ayni:
            int[] a3 = new int[] { 35, 55, 60 };
            // int[] a3 = { 35, 55, 60 }; // ustteki ifadenin kisa yazilisi
            
            Console.WriteLine("a2 dizisinin 0. elemani : {0}", a2[0]);
            Console.WriteLine("a3 dizisinin 0. elemani : {0}", a3[0]);
            System.Console.Read();
        }
    }
}
