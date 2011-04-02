using System;

namespace Uzay1
{
    public struct Yapi
    {
        public int a;
        public int b;

        public Yapi(int arg1, int arg2)
        {
            a = arg1;
            b = arg2;
        }
    }

    public class Sinif
    {
        public int a;
        public int b;

        public Sinif(int arg1, int arg2)
        {
            a = arg1;
            b = arg2;
        }
    }

    public class Test
    {
        static void Main()
        {
            Yapi ornek1 = new Yapi(5, 9);
            Sinif nesne1 = new Sinif(5, 9);

            Console.WriteLine("1. ADIM:");
            Console.WriteLine("(ornek1.a, ornek1.b) = ({0}, {1})", ornek1.a, ornek1.b);
            Console.WriteLine("(nesne1.a, nesne1.b) = ({0}, {1})", nesne1.a, nesne1.b);

            Yapi ornek2 = ornek1;
            Sinif nesne2 = nesne1;

            ornek2.b = 789;
            nesne2.b = 789;

            Console.WriteLine("2. ADIM:");
            Console.WriteLine("(ornek1.a, ornek1.b) = ({0}, {1})", ornek1.a, ornek1.b);
            Console.WriteLine("(nesne1.a, nesne1.b) = ({0}, {1})", nesne1.a, nesne1.b);

            Console.ReadLine();
        }
    }
}
