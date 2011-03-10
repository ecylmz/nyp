// ++ operatoru
using System;

namespace Uzay1
{
    class Sinif1
    {
        static void Main()
        {
            int i = 0, j = 0;

            while (i < 5)
                Console.Write(" {0} ", i++);
                // once yaz, sonra i yi artir

            Console.WriteLine();

            while (j < 5)
                Console.Write(" {0} ", ++j);
                // once j yi artir, sonra yaz

            Console.ReadLine();
        }
    }
}
