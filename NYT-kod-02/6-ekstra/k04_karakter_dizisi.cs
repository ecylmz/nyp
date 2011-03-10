using System;

namespace Uzay1
{
    class Sinif1
    {
        static void Main()
        {
            string sozcuk, s1, s2, s3, s4, s5;
            sozcuk = "abcdeabcde";

            // sozcuk icindeki 'c' karakterlerinin tumunu
            // 'z' olarak degistir
            s1 = sozcuk.Replace('c', 'z');

            // sozcuk icindeki "de" alt dizilerinin tumunu
            // "yz" olarak degistir
            s2 = sozcuk.Replace("de", "yz");

            // sozcuk dizisindeki 2. karakter ve sonrasini at
            s3 = sozcuk.Remove(2);

            // sozcuk dizisindeki tum kucuk harf karakterlerini
            // buyukleriyle yer degistir
            s4 = sozcuk.ToUpper();

            // s4 dizisindeki ilk karakterden baslayarak
            // 2 karakter ilerisine kadar al ve kucult
            s5 = s4.Substring(0, 2).ToLower();


            Console.WriteLine("s1 : {0}", s1);
            Console.WriteLine("s2 : {0}", s2);
            Console.WriteLine("s3 : {0}", s3);
            Console.WriteLine("s4 : {0}", s4);
            Console.WriteLine("s5 : {0}", s5);

            Console.ReadLine();
        }
    }
}
