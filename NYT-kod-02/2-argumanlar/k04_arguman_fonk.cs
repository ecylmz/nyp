using System;

namespace Uzay1
{
    public class Sinif1
    {
        public static void Topla_Ref(ref int toplam, int sayi1, int sayi2)
        {
            toplam = sayi1 + sayi2;
        }
    }

    public class Sinif2
    {
        static void Main()
        {
            int a = 3, b = 4, toplam = 0;
            Console.WriteLine("toplam degiskeninin ilk degeri : {0}", toplam);

            Sinif1.Topla_Ref(ref toplam, a, b);
            Console.WriteLine("toplam degiskeninin son degeri : {0}", toplam);

            System.Console.Read();
        }
    }
}
