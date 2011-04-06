using System;

namespace OrnekSiniflar
{
    public enum Doviz
    { // sabit listesi
        TL,
        USD,
        EURO
    }

    public class BankaHesabi
    {
        private int hesap_no;
        private string musteri_adi;
        private int bakiye;
        private Doviz doviz_tipi;

        public BankaHesabi(int arg_hno, string arg_ad, int arg_bak, Doviz arg_dov)
        { // yapici metot
            hesap_no = arg_hno;
            musteri_adi = arg_ad;
            bakiye = arg_bak;
            doviz_tipi = arg_dov;

			// yapici metotta ilkleme disinda islemler de yapilabilir
            Console.WriteLine("{0} adina bankamizda {1} numarali {2} hesabi acilmistir.", musteri_adi, hesap_no, Enum.GetName(typeof(Doviz), doviz_tipi));
            Console.WriteLine("Hesap acilirken musteri tarafindan {0} {1} para yatirilmistir.\n", bakiye, Enum.GetName(typeof(Doviz), doviz_tipi));
        }

        // ozellikler
        public int HesapNo
        {
            get { return hesap_no; }
        }

        public string MusteriAdi
        {
            get { return musteri_adi; }
        }

        public int Bakiye
        {
            get { return bakiye; }
        }

        public Doviz DovizTipi
        {
            get { return doviz_tipi; }
        }

        // fonksiyonlar
        public void ParaYatir(int meblag)
        {
            bakiye += meblag;
            Console.WriteLine("Para yatirildi. Guncel bakiye : {0} {1}", bakiye, Enum.GetName(typeof(Doviz), doviz_tipi));
        }

        public void ParaCek(int meblag)
        {
            if (bakiye >= meblag)
            {
                bakiye -= meblag;
                Console.WriteLine("Para cekildi. Guncel bakiye : {0} {1}", bakiye, Enum.GetName(typeof(Doviz), doviz_tipi));
            }
            else
            {
                Console.WriteLine("Yetersiz bakiye.");
            }
        }

        public void HesapBilgileri()
        {
            Console.WriteLine("\n-----HESAP-BILGILERI-----");
            Console.WriteLine("Musteri Adi : {0}", musteri_adi);
            Console.WriteLine("Hesap No    : {0}", hesap_no);
            Console.WriteLine("Bakiye      : {0} {1}", bakiye, Enum.GetName(typeof(Doviz), doviz_tipi));
            Console.WriteLine("---------------------------\n");
        }
    }

    public class Sinif1
    {
        static void Main()
        {
            BankaHesabi hesap1 = new BankaHesabi(6021664, "Sezgin Acar", 0, Doviz.TL);
            hesap1.ParaYatir(75);
            hesap1.ParaCek(100);
            hesap1.ParaCek(50);
            hesap1.HesapBilgileri();

            BankaHesabi hesap2 = new BankaHesabi(6021665, "Mine Semiz", 236, Doviz.EURO);
            hesap2.HesapBilgileri();

            Console.ReadLine();
        }
    }
}
