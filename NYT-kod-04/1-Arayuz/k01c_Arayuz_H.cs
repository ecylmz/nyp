using System;

namespace Uzay1
{

    public interface ISinif1
    {
        string ozellik1 { get; set; }
        string ozellik2 { get; }
        string ozellik3 { set; }

        int fonksiyon1();
        int fonksiyon2(int arg1);
        void fonksiyon3(int arg2);
        void fonksiyon4();
    }

    public class Sinif1 : ISinif1
    {
        private string degisken1;
        private string degisken2;
        private string degisken3;

        public Sinif1()
        {
            degisken1 = "degisken_1";
            degisken2 = "degisken_2";
            degisken3 = "degisken_3";
        }

        public string ozellik1
        {
            get { return degisken1; }
            set { degisken1 = value; }
        }

        public string ozellik2
        {
            get { return degisken2; }
        }

        public string ozellik3
        {
            set { degisken3 = value; }
        }

        // hata: fonksiyon1 gerceklenmemis

        public int fonksiyon2(int arg1)
        {
            return arg1;
        }

        public void fonksiyon3(int arg2)
        {
            Console.WriteLine(arg2.ToString());
        }

        public void fonksiyon4()
        {
            Console.WriteLine("fonksiyon_4");
        }
    }

    class Sinif2
    {
        static void Main()
        {
            Sinif1 nesne1 = new Sinif1();
            Console.WriteLine("{0}", nesne1.ozellik1);
            nesne1.ozellik1 = "yeni_deger_1";
            Console.WriteLine("{0}", nesne1.ozellik1);

            Console.WriteLine("{0}", nesne1.ozellik2);
            nesne1.ozellik3 = "yeni_deger_2";

            Console.WriteLine("nesne1.fonksiyon2(60) --> {0}", nesne1.fonksiyon2(60));
            nesne1.fonksiyon3(35);
            nesne1.fonksiyon4();
            Console.ReadLine();
        }
    }
}
