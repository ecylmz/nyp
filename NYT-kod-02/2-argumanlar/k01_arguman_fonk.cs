using System;

namespace Uzay1
{
    class Sinif1
    {
        static void Merhaba()
        { // arguman almaz, deger dondurmez
            Console.WriteLine("Merhaba !");
        }

        static void ToplaYaz(int a, int b)
        { // arguman alir, deger dondurmez
            int sonuc = a + b;
            Console.WriteLine("Toplam : {0}", sonuc);
        }

        static int ToplaDondur(int a, int b)
        { // arguman alir, deger dondurur
            int sonuc = a + b;
            return sonuc;
        }

        static int TurkiyeYuzolcumu()
        { // arguman almaz, deger dondurur
            int yuzolcum = 814578;
            return yuzolcum;
        }

        static void Main()
        {
            Merhaba();
            ToplaYaz(60, 35);
            
            int td = ToplaDondur(25, 19);
            Console.WriteLine("ToplaDondur fonk. sonucu : {0}", td);
            
            int ty = TurkiyeYuzolcumu();
            Console.WriteLine("TurkiyeYuzolcumu fonk. sonucu : {0}", ty);
            Console.ReadLine();
        }
    }
}
