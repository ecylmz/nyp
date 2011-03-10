using System;

namespace Uzay1
{
    class Sinif1
    {
        static int ToplaYazdirDondur(int a, int b)
        { // arguman alir, deger dondurur
            int sonuc = a + b;
            Console.WriteLine("Toplam : {0}", sonuc);
            return sonuc;
        }

        static void Main()
        {
            ToplaYazdirDondur(60, 35);
            Console.ReadLine();
        }
    }
}
