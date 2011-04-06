using System;

namespace OrnekSiniflar
{
    public class Insan
    {
        // statik olmayan metotlarin bulundugu bir sinif
        // nesnesi yaratilarak kullanilmak uzere tasarlanmis
        public string ad;
        public string soyad;
        public int yas;

        public Insan(string arg_ad, string arg_soyad, int arg_yas)
        {
            ad = arg_ad;
            soyad = arg_soyad;
            yas = arg_yas;
        }

        public void KendiniTanit()
        {
            Console.WriteLine("Merhaba, ben {0} {1}. {2} yasindayim.", ad, soyad, yas);
        }

        public void BirYasBuyu()
        {
            yas++;
        }

    }

    public class Sinif1
    {
        static void Main()
        {
            Insan Tahsin = new Insan("Tahsin", "Ertan", 35);
            Insan Damla = new Insan("Damla", "Kaya", 27);

            Tahsin.KendiniTanit();
            Damla.KendiniTanit();
            Tahsin.BirYasBuyu();
            Tahsin.KendiniTanit();
            Console.ReadLine();
        }
    }
}
