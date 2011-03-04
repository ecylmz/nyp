using System;

namespace Uzay1
{
    public class Sinif1
    {
        static void Main()
        {
            // int : 32 bit, long : 64 bit

            // elimizde 50 kg' lik bir cuval var
            int intDeger = 123;

            // yolcu basina 100 kg esya kabul eden bir otobuse biniyoruz :
            // SORUN YOK (bilgi kaybi yok)
            long longDeger = intDeger;

            // long longDeger = (long) intDeger; // uzun gosterim

            Console.WriteLine("intDeger  : {0}", intDeger);
            Console.WriteLine("longDeger : {0}", longDeger);

            System.Console.Read();
        }
    }
}
