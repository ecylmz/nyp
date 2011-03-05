using System;

namespace Uzay1
{
    public class Sinif1
    {
        static void Main()
        {
            // int : 32 bit, long : 64 bit
            // int  turunden bir degiskenin alabilecegi en buyuk deger : 2147483647
            // long turunden bir degiskenin alabilecegi en buyuk deger : 9223372036854775807

            // elimizde 100 kg' lik bir cuval var
            long longDeger = 9223372036854775807;
            

            // yolcu basina 50 kg esya kabul eden bir otobuse biniyoruz :
            // SORUN VAR (bilgi kaybi kacinilmaz, tasma (overflow) meydana gelir)
            int intDeger = (int) longDeger; // bilgi kaybi goze alinarak bir donusum yapildi

            // int intDeger = longDeger; // hatali : acik donusum gerekli

            Console.WriteLine("longDeger : {0}", longDeger);
            Console.WriteLine("intDeger  : {0}", intDeger);

            System.Console.Read();
        }
    }
}
