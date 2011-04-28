using System;

namespace OrnekSiniflar
{
    public class RasgeleFoksiyonlar
    {
        // sinif disariyla iliskili oldugundan tum metotlari
        // statiktir. sinifin kendini statik olarak tanimlamak
        // da yanlis bir tercih olmaz.
        // bu sinifin nesneyle bir iliskisi yoktur.
        public static string Elbiseler(string[] elb)
        {
            int uzunluk, rasgele;
            uzunluk = elb.Length;
            Random rnd = new Random();
            rasgele = rnd.Next(uzunluk - 1);
            return elb[rasgele];
        }

        public static string Renkler(string[] rn)
        {
            int uzunluk, rasgele;
            uzunluk = rn.Length;
            Random rnd = new Random();
            rasgele = rnd.Next(uzunluk - 1);
            return rn[rasgele];
        }

        public static string KarisikRenkler(string[] rn)
        {
            string renk1 = Renkler(rn);
            string renk2 = renk1;
            while (renk2 == renk1)
                renk2 = Renkler(rn);
            string KarisikRenk = String.Concat(renk1, "-", renk2);

            Random rnd = new Random();
            int rasgele = rnd.Next(2);
            if (rasgele == 0)
                return KarisikRenk;
            else if (rasgele == 1)
                return renk1;
            else
                return renk2;

        }

        public static string Yarismacilar(string[] yrs)
        {
            int uzunluk, rasgele;
            uzunluk = yrs.Length;
            Random rnd = new Random();
            rasgele = rnd.Next(uzunluk - 1);
            return yrs[rasgele];
        }

        public static void Cekilis(string[] elb, string[] rn, string[] yrs)
        {
            Console.WriteLine("{0} isimli yarismaci bir adet {1} {2} kazanmistir.", Yarismacilar(yrs), KarisikRenkler(rn), Elbiseler(elb));
        }
    }

    public class Sinif1
    {
        static void Main()
        {
            string[] elbiseler = { "pantolon", "gomlek", "mont", "ceket", "kazak", "tisort", "hirka", "suveter", "sapka", "atki", "yagmurluk" };
            string[] renkler = { "beyaz", "sari", "mavi", "yesil", "kirmizi", "siyah", "gri", "mor", "bordo", "bej", "turuncu", "kahverengi" };
            string[] yarismacilar = { "Mursel", "Nuran", "Sahin", "Sule", "Kaya", "Filiz", "Sezai", "Neriman", "Cevdet", "Pelin" };

            RasgeleFoksiyonlar.Cekilis(elbiseler, renkler, yarismacilar);

            Console.ReadLine();
        }
    }
}
