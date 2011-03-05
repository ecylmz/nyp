using System;

namespace Uzay1
{
    public class Sinif1
    {
        static void Main()
        {
            // a adinda yeni bir canta olustur, icerisine 6 koy
            int a = 6;

            // b adinda yeni bir canta olustur, icerisine 6 koy
            int b = 6;

            Console.WriteLine("a == b : {0}", a == b);

            // x adinda yeni bir canta olustur, icerisine 8 koy
            int x = 8;

            // y adinda yeni bir canta olustur, icerisine x cantasindaki
            // degerin aynisindan koy
            int y = x;

            Console.WriteLine("x == y : {0}", x == y);

            System.Console.Read();
        }
    }
}
