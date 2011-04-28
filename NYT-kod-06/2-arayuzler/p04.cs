using System;

namespace Uzay1
{
    public interface IArayuz1
    {
        int fonksiyon1(int a);
    }
    public class Sinif1
    {
        public int a = 84;

        public int fonksiyon2()
        {
            return a * a;
        }
    }
    public class Sinif2 : Sinif1, IArayuz1
    { // hem siniftan hem arayuzden miras
        public int fonksiyon1(int i)
        {
            return i + i;
        }
    }
    public class Sinif3
    {
        static void Main()
        {
            Sinif2 nesne = new Sinif2();
            int sonuc1 = nesne.fonksiyon1(7);
            int sonuc2 = nesne.fonksiyon2();
            Console.WriteLine("1. Sonuc : {0}", sonuc1);
            Console.WriteLine("2. Sonuc : {0}", sonuc2);
            Console.ReadLine();
        }
    }
}
