using System;

namespace Uzay1
{
    public class Sinif1
    {
        static void Main()
        {
            // bellekte 10x20x30' luk (6000 elemanli) bir tamsayi dizisi icin
            // yer ayir ve bu yerin baslangic adresini b1 tutacagina kaydet
            int[,,] a3 = new int[10, 20, 30];

            // a3 dizisinin uzunlugu (3 boyutlu gibi gorunen dizi aslinda
            // ip gibi acilmis bicimde dusunulebilir) : 6000
            Console.WriteLine("a3 dizisinin uzunlugu : {0}", a3.Length);

            System.Console.Read();
        }
    }
}
