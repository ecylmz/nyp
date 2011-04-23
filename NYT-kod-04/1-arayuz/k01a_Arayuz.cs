using System;

namespace Uzay1
{

    public interface ISinif1
    { // arayuz tanimlamasi
        string ozellik1 { get; set; }
        string ozellik2 { get; }
        string ozellik3 { set; }

        int fonksiyon1();
        int fonksiyon2(int arg1);
        void fonksiyon3(int arg2);
        void fonksiyon4();
    }

    public class Sinif1:ISinif1
    { // sinif tanimlamasi
        // Sinif1, ISinif1 arayuzunden miras alir yani bu
        // arayuzdeki tum uyeleri gerceklemek zorundadir
 
        // miras alinan arayuzde bulunmayan ancak miras alan
        // sinifta yer alan uyeler de bulunabilir
        private string degisken1;
        private string degisken2;
        private string degisken3;

        public Sinif1()
        { // yapici metot
            degisken1 = "degisken_1";
            degisken2 = "degisken_2";
            degisken3 = "degisken_3";
        }

        public string ozellik1
        { // ozellik1' in gerceklemesi

            // bu sinifin bir nesnesinin ozellik1 alt alaninin
            // dondurecegi deger burada belirlenir
            get { return degisken1; }

            // bu sinifin bir nesnesinin ozellik1 alt alanina
            // atama yapildiginda atanan degerin nerede tutulacagi
            set { degisken1 = value; }
        }

        public string ozellik2
        { // sadece okunabilir ozellik
            get { return degisken2; }
        }

        public string ozellik3
        { // sadece yazilabilir ozellik
            set { degisken3 = value; }
        }

        // fonksiyonlar da arayuzde prototipleri (imzalari)
        // belirtildigi sekilde tanimlanmalidir
        public int fonksiyon1()
        {
            return 1;
        }

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
            // nesne1.ozellik2 = "yeni_deger"; // hata: sadece okunabilir

            nesne1.ozellik3 = "yeni_deger_2";
            // Console.WriteLine("{0}", nesne1.ozellik3); // hata: sadece deger alabilir

            Console.WriteLine("nesne1.fonksiyon1() --> {0}", nesne1.fonksiyon1());
            Console.WriteLine("nesne1.fonksiyon2(60) --> {0}", nesne1.fonksiyon2(60));
            nesne1.fonksiyon3(35);
            nesne1.fonksiyon4();
            Console.ReadLine();
        }
    }
}



