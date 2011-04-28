using System;

namespace Uzay1
{
    public interface ISinif1
    { // ISinif1 arayuzu
        int ozellik1 { get; set; }
        int fonksiyon1();
    }
    public interface ISinif2
    { // ISinif2 arayuzu
        string ozellik2 { get; set; }
        string fonksiyon2();
    }
    public interface ISinif3 : ISinif1, ISinif2
    { // ISinif1 ve ISinif2' den miras alan ISinif3 arayuzu
        string fonksiyon3();
    }
    public class Sinif1 : ISinif3
    { // ISinif3 arayuzunden kalitlayan sinif
        public int i1;
        public string s1;

        public Sinif1()
        {
            i1 = 9;
            s1 = "dokuz";
        }
        public int ozellik1
        {
            get { return i1; }
            set { i1 = value; }
        }
        public string ozellik2
        {
            get { return s1; }
            set { s1 = value; }
        }
        public int fonksiyon1()
        {
            return 5;
        }
        public string fonksiyon2()
        {
            return "bes";
        }
        public string fonksiyon3()
        {
            return "bir";
        }
    }
    class Sinif2
    {
        static void Main()
        {
            Sinif1 nesne1 = new Sinif1();
            Console.WriteLine("{0}", nesne1.ozellik1);
            nesne1.ozellik1 = 77;
            Console.WriteLine("{0}", nesne1.ozellik1);

            Console.WriteLine("{0}", nesne1.ozellik2);
            nesne1.s1 = "yetmisyedi";
            Console.WriteLine("{0}", nesne1.ozellik2);

            Console.WriteLine("nesne1.fonksiyon1() --> {0}", nesne1.fonksiyon1());
            Console.WriteLine("nesne1.fonksiyon2() --> {0}", nesne1.fonksiyon2());
            Console.WriteLine("nesne1.fonksiyon3() --> {0}", nesne1.fonksiyon3());
            Console.ReadLine();
        }
    }
}
