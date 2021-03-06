using System;

namespace Uzay1
{
    public interface ISinif1
    { // ISinif1 arayuzu
        int fonksiyon1(int a);
    }
    public interface ISinif2
    { // ISinif2 arayuzu
        long fonksiyon1(int b);
    }
    public interface ISinif3 : ISinif1, ISinif2
    { // ISinif1 ve ISinif2' den miras alan ISinif3 arayuzu
    }
    public class Sinif1 : ISinif3
    {
        // hata : bir sinif icerisindeismi ve arguman yapisi
        // ayni olan birden fazla fonksiyon tanimlanamaz
        public int i1 = 6;

        public int fonksiyon1(int x)
        {
            return x;
        }
        public long fonksiyon1(int x)
        {
            return (long) x;
        }
    }
    class Sinif2
    {
        static void Main()
        {
            Sinif1 nesne1 = new Sinif1();
            int sonuc = nesne1.fonksiyon1(7);
            Console.WriteLine("Sonuc : {0}", sonuc);
            Console.ReadLine();
        }
    }
}
