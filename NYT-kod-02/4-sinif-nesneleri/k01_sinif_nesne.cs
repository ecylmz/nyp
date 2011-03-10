using System;

namespace Uzay1
{
    class Sinif1
    {
        // Sinif1 sinifinin uyeleri
        public int a;
        public int b;

        public Sinif1()
        { // varsayilan yapici metod
            a = -1;
            b = -1;
        }
        public Sinif1(int sayi1, int sayi2)
        { // 2 argumanli yapici metod
            a = sayi1;
            b = sayi2;
        }
        public int Topla1()
        { // sinif ici kullanim amacli Topla fonksiyonu
            return (a + b);
        }
        public static int Topla2(int s1, int s2)
        { // sinif disi kullanim amacli Topla fonksiyonu
            return (s1 + s2);
        }
    }
    class Sinif2
    {
        static void Main()
        {
            // varsayilan yapici metodla nesne yaratma
            Sinif1 nesne1 = new Sinif1();

            // 2 argumanli yapici metodla nesne yaratma
            Sinif1 nesne2 = new Sinif1(4, 7);

            int toplam1 = nesne1.Topla1(); // -2
            int toplam2 = nesne2.Topla1(); // 11

            int toplam3 = Sinif1.Topla2(23, 45); // 68

            Console.WriteLine("toplam1 : {0}", toplam1);
            Console.WriteLine("toplam2 : {0}", toplam2);
            Console.WriteLine("toplam3 : {0}", toplam3);
            Console.ReadLine();
        }
    }
}
