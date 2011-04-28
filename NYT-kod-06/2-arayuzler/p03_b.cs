using System;

namespace Uzay1
{
    public interface ISinif1
    {
        int fonksiyon1(int a);
    }
    public interface ISinif2 : ISinif1
    {
        int fonksiyon2(int b);
    }
    public interface ISinif3 : ISinif2
    {
        int fonksiyon3(int c);
    }
    public class Sinif1 : ISinif3
    {
        public int i1 = 0;

        public int fonksiyon1(int x)
        {
            return x;
        }
        public int fonksiyon2(int y)
        {
            return y + 1;
        }
        public int fonksiyon3(int z)
        {
            return z + 2;
        }
    }
    class Sinif2
    {
        static void Main()
        {
            Sinif1 nesne1 = new Sinif1();
            int sonuc = nesne1.fonksiyon1(7);
            Console.WriteLine("1. Sonuc : {0}", nesne1.fonksiyon1(7));
            Console.WriteLine("2. Sonuc : {0}", nesne1.fonksiyon2(7));
            Console.WriteLine("3. Sonuc : {0}", nesne1.fonksiyon3(7));
            Console.ReadLine();
        }
    }
}
