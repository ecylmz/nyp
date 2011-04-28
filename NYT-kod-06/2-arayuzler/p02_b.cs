using System;

namespace Uzay1
{
    public interface ISinif1
    { // ISinif1 arayuzu
        int fonksiyon1(int a);
    }
    public interface ISinif2
    { // ISinif2 arayuzu
        int fonksiyon1(long b);
    }
    public interface ISinif3 : ISinif1, ISinif2
    { // ISinif1 ve ISinif2' den miras alan ISinif3 arayuzu
    }
    public class Sinif1 : ISinif3
    { // ISinif3 arayuzunden miras alan sinif
        public int i1 = 6;

        public int fonksiyon1(int x)
        {
            Console.WriteLine("CAGRILAN FONKSIYON : [ int fonksiyon1(int a); ]");
            return (x + 1);
        }
        public int fonksiyon1(long x)
        {
            Console.WriteLine("CAGRILAN FONKSIYON : [ int fonksiyon1(long b); ]");
            return (int) x;
        }
    }
    class Sinif2
    {
        static void Main()
        {
            int int1 = 50;
            long lng1 = 50;
            Sinif1 nesne1 = new Sinif1();
            long sonuc1 = nesne1.fonksiyon1(int1);
            long sonuc2 = nesne1.fonksiyon1(lng1);
            long sonuc3 = nesne1.fonksiyon1(35);
            long sonuc4 = nesne1.fonksiyon1((long)35);

            Console.ReadLine();
        }
    }
}
