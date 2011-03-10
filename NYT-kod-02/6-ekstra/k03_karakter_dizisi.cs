using System;

namespace Uzay1
{
    class Sinif1
    {
        static void Main()
        {
            string gunler = "pzt,sal,car,per,cum,cts,paz";
            // Split fonksiyonu, String sinifinda yer alan ve statik
            // olmayan bir fonksiyondur. Bu sinifin bir nesnesi olan
            // (string temel turune sahip) bir nesneye mesaj gondermek
            // yolu ile cagirilabilir. alabilecegi arguman sayisi ve
            // cesidi degismekle birlikte, arguman olarak aldigi
            // karakteri ayirici olarak kullanir ve ilgili nesneyi
            // parcalayarak bir 'string' dizisine yerlestirir, bu
            // dizinin baslangic adresini dondurur.

            string[] str2 = gunler.Split(',');
            // str2 dizisinin icerigi su sekilde olacaktir:
            // {"pzt", "sal", "car", "per", "cum", "cts", "paz"}

            Console.WriteLine("Haftanin 1. gunu : {0}", str2[0]);
            Console.WriteLine("Haftanin 4. gunu : {0}", str2[3]);
            Console.ReadLine();
        }
    }
}