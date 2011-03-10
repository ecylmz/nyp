using System;

namespace Uzay1
{
    class Sinif1
    {
        static void Main()
        {
            int x = 3, y = 4, z = 9, a, b, c, d, e;

            a = x + y; // toplama
            b = x - y; // cikarma
            c = x * y; // carpma
            d = z / x; // bolme
            e = z % y; // mod alma

            Console.WriteLine("1. adim:\n-------");
            Console.WriteLine("x\ty\tz\ta\tb\tc\td\te");
            Console.WriteLine();
            Console.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}\t{5}\t{6}\t{7}", x, y, z, a, b, c, d, e);

            a *= x;  // a = a * x;
            b += 10; // b = b + 10;
            c /= 2;  // c = c / 2;
            d -= y;  // d = d - y;
            z %= x;  // z = z % x;

            Console.WriteLine("\n2. adim:\n-------");
            Console.WriteLine("x\ty\tz\ta\tb\tc\td\te");
            Console.WriteLine();
            Console.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}\t{5}\t{6}\t{7}", x, y, z, a, b, c, d, e);

            Console.ReadLine();
        }
    }
}
