using System;

namespace Uzay1
{
    public class Sinif1
    {
        public static void DiziSifirla(ref int[] dizi)
        {
            int uzunluk = dizi.Length;
            for (int i = 0; i < uzunluk; i++)
            {
                dizi[i] = 0;
            }
        }
    }

    public class Sinif2
    {
        static void Main()
        {
            int[] fib = { 1, 1, 2, 3, 5, 8, 11};

            Console.WriteLine("ONCE  : fib[2], fib[5] : {0}, {1}", fib[2], fib[5]);

            Sinif1.DiziSifirla(ref fib);
            Console.WriteLine("SONRA : fib[2], fib[5] : {0}, {1}", fib[2], fib[5]);

            System.Console.Read();
        }
    }
}
