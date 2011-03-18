using System;

namespace Uzay1
{
    public static class Sinif1
    { // public erisimli statik sinif

        // hata: statik siniflarin statik olmayan
        // uyeleri ve yapici metodlari bulunamaz
        public int bolunen = 0;
        public int bolen = 0;

        public Sinif1(int s1, int s2)
        {
            bolunen = s1;
            bolen = s2;
        }

        public int Bol()
        {
            return (bolunen / bolen);
        }
    }

    class Sinif2
    {
        static void Main()
        {
            Sinif1 nesne1 = new Sinif1(60, 15);
            int sonuc = nesne1.Bol();
            Console.WriteLine("Sonuc : {0}", sonuc);
            Console.ReadLine();
        }
    }
}
