using System;

namespace Uzay1
{
    public class Sinif1
    {
        static void Main()
        {
            // deger adinda yeni bir canta olustur, icerisine 7 koy
            int deger = 7;

            // isimsiz bir canta olustur, icerisine deger cantasindaki degerin
            // aynisindan koy ve bu yeni cantayi bir nesne (object) kutusuna
            // yerlestir, kutunun adresini de referans tutacaginda tut
            object referans = deger;

            // deger cantasinin icindeki degeri at, yerine 9 koy
            deger = 9;

            Console.WriteLine("deger    : {0}", deger);
            Console.WriteLine("referans : {0}", referans);
            System.Console.Read();
        }
    }
}
