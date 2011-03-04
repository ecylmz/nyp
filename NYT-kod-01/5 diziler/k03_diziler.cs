using System;

namespace Uzay1
{
    public class Sinif1
    {
        static void Main()
        {
            // bellekte 2x3' luk (6 elemanli) bir tamsayi dizisi icin
            // yer ayir ve bu yerin baslangic adresini b1 tutacagina kaydet
            int[,] b1 = new int[2,3];

            // b1 ile ayni boyutlara sahip b2 dizisini olustur ve
            // deger atamasi yap
            int[,] b2 = new int[,] {{5, 12, 13}, {7, 24, 15}};

            // b2 dizisinin ilk satirini yazdir (tab karakterleri ile susleyerek)
            Console.WriteLine("[\t{0}\t{1}\t{2}\t]", b2[0, 0], b2[0, 1], b2[0, 2]);

            // b2 dizisinin ikinci satirini yazdir (tab karakterleri ile susleyerek)
            Console.WriteLine("[\t{0}\t{1}\t{2}\t]", b2[1, 0], b2[1, 1], b2[1, 2]);
            System.Console.Read();
        }
    }
}
