using System;

namespace Uzay1
{
    public class Sinif1
    {
        private int a = 3; // private, non-static
        static int b = 4;  // private, static

        static void Main()
        {
            Sinif1 nesne = new Sinif1();
            Console.WriteLine(nesne.a);// dogru 
            Console.WriteLine(nesne.b);// yanlis 
            Console.WriteLine(a); // yanlis
            Console.WriteLine(b); // dogru

            System.Console.Read();
        }
    }


}
