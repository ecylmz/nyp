using System;

namespace OrnekSiniflar
{
    public static class KarakterIslemleri
    {
        // sadece statik metotlarin bulundugu bir sinif
        // nesnesinin yaratilmasina luzum yok

        public static string SondanBasaYaz(string str)
        {
            string sonuc = "";
            for (int i = str.Length-1; i >= 0; i--)
                sonuc += str[i];
            return sonuc;
        }

        public static string ZarfaKoy(string str)
        {
            return String.Concat("[", str, "]");
        }

        public static string ZarftanCikar(string str)
        {
            if (str[0] == '[' && str[str.Length - 1] == ']')
                return str.Substring(1, str.Length - 2);
            else
                return str;
        }

    }

    public class Sinif1
    {
        static void Main()
        {
            string s1 = "zarfsiz";
            string s2 = "[zarfli]";

            Console.WriteLine("s1 : {0}\ns2 : {1}\n", s1, s2);
            Console.WriteLine("SondanBasaYaz(s1) --> {0}", KarakterIslemleri.SondanBasaYaz(s1));
            Console.WriteLine("ZarfaKoy(s1)      --> {0}", KarakterIslemleri.ZarfaKoy(s1));
            Console.WriteLine("ZarftanCikar(s2)  --> {0}", KarakterIslemleri.ZarftanCikar(s2));
            Console.ReadLine();
        }
    }
}
