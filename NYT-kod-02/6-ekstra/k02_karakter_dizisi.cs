using System;

namespace Uzay1
{
    class Sinif1
    {
        static void Main()
        {
            string sozcuk, s1, s2, s3, s4, s5;
            sozcuk = "televizyon";

            // 0. karakterden basla 4 karakter ilerisine kadar al
            s1 = sozcuk.Substring(0, 4);

            // 4. karakterden basla 6 karakter ilerisine kadar al
            s2 = sozcuk.Substring(4, 6);

            // 3. karakterden basla 2 karakter ilerisine kadar al
            s3 = sozcuk.Substring(3, 2);

            // 3. karakterden basla dizi sonuna kadar al
            s4 = sozcuk.Substring(3);

            // 5. karakterden basla dizi sonuna kadar al: hatali
            // s5 = sozcuk.Substring(5, 7);

            Console.WriteLine("s1 : {0}", s1);
            Console.WriteLine("s2 : {0}", s2);
            Console.WriteLine("s3 : {0}", s3);
            Console.WriteLine("s4 : {0}", s4);

            Console.ReadLine();
        }
    }
}
