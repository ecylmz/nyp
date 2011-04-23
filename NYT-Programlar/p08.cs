using System;

namespace Uzay1
{
    public struct Yapi1
    { // hata: yapilarda dongusel tanimlama yapilamaz
        public int x;
        public int y;
        public Yapi1 yap; // dongusel tanimlama

        public Yapi1(int arg1, int arg2)
        {
            x = arg1;
            y = arg2;
        }
    }

    public class Sinif1
    {
        static void Main()
        {
            Yapi1 ornek1 = new Yapi1(3, 4);
            Yapi1 ornek2 = new Yapi1(5, 6);
            Yapi1 ornek3 = new Yapi1(7, 8);

            ornek1.yap = ornek2;
            ornek2.yap = ornek3;
            ornek3.yap = ornek1;

            Console.WriteLine("ornek1.x              --> {0}", ornek1.x);
            Console.WriteLine("ornek1.yap.x          --> {0}", ornek1.yap.x);
            Console.WriteLine("ornek1.yap.yap.x      --> {0}", ornek1.yap.yap.x);
            Console.WriteLine("ornek1.yap.yap.yap.x -- > {0}", ornek1.yap.yap.yap.x);

            Console.ReadLine();
        }
    }
}
