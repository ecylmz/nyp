using System;

namespace OrnekSiniflar
{
    public enum TasimaYollari
    { // sabit listesi
        Kara,
        Demiryolu,
        Deniz,
        Hava
    }

    public abstract class Tasitlar
    { // miras veren ana sinif
        protected TasimaYollari tasima_yolu;
        protected int yolcu_kapasitesi;
        protected int yolcu_sayisi = 0;
    }

    public class Gemi : Tasitlar
    { // miras alan 1. sinif

        private string gemi_adi;
        private int tonaj;
        private int yuk = 0;

        public Gemi(string arg_ad, int arg_tonaj, int arg_yolcu_k)
        { // yapici metot
            tasima_yolu = TasimaYollari.Deniz;
            gemi_adi = arg_ad;
            tonaj = arg_tonaj;
            yolcu_kapasitesi = arg_yolcu_k;

            // yapici metotta ilkleme disinda islemler de yapilabilir
            Console.WriteLine("{0} isimli geminin tonaji {1} ton ve yolcu kapasitesi {2} kisidir.", gemi_adi, tonaj, yolcu_kapasitesi);
        }

        // ozellikler
        public string GemiAdi
        {
            get { return gemi_adi; }
        }

        public int Tonaj
        {
            get { return tonaj; }
        }

        public int Yuk
        {
            get { return yuk; }
            set { yuk = value; }
        }

        public int YolcuKapasitesi
        {
            get { return yolcu_kapasitesi; }
        }

        public int YolcuSayisi
        {
            get { return yolcu_sayisi; }
            set { yolcu_sayisi = value; }
        }

        // fonksiyonlar
        public void Yukle(int agirlik)
        {
            yuk += agirlik;
            if (yuk > tonaj)
                yuk = tonaj;
        }

        public void YukBosalt(int agirlik)
        {
            yuk -= agirlik;
        }

        public void YolcuAl(int sayi)
        {
            yolcu_sayisi += sayi;
            if (yolcu_sayisi > yolcu_kapasitesi)
                yolcu_sayisi = yolcu_kapasitesi;
        }

        public void YolcuBosalt(int sayi)
        {
            yolcu_sayisi -= sayi;
        }
    }

    public class Otobus : Tasitlar
    { // miras alan 2. sinif

        private string plaka;
        private string marka_model;

        public Otobus(string arg_plaka, string arg_m_model, int arg_yolcu_k)
        {
            tasima_yolu = TasimaYollari.Kara;
            plaka = arg_plaka;
            marka_model = arg_m_model;
            yolcu_kapasitesi = arg_yolcu_k;

            Console.WriteLine("{0} plakalý ve {1} markali otobusun yolcu kapasitesi {2} kisidir.", plaka, marka_model, yolcu_kapasitesi);
        }

        public string Plaka
        {
            get { return plaka; }
        }

        public string MarkaModel
        {
            get { return marka_model; }
        }

        public int YolcuKapasitesi
        {
            get { return yolcu_kapasitesi; }
        }

        public int YolcuSayisi
        {
            get { return yolcu_sayisi; }
            set { yolcu_sayisi = value; }
        }

        public void YolcuAl(int sayi)
        {
            yolcu_sayisi += sayi;
            if (yolcu_sayisi > yolcu_kapasitesi)
                yolcu_sayisi = yolcu_kapasitesi;
        }

        public void YolcuBosalt(int sayi)
        {
            yolcu_sayisi -= sayi;
        }
    }

    public class Sinif1
    {
        static void Main()
        {
            Gemi g1 = new Gemi("PiriReis60", 4500, 240);
            g1.YolcuAl(204);
            g1.YolcuBosalt(14);
            g1.Yukle(1095);
            g1.Yukle(3230);
            g1.YukBosalt(3000);
            Console.WriteLine("An itibari ile bu gemide {0} yolcu ve {1} ton yuk vardir.", g1.YolcuSayisi, g1.Yuk);
            Console.WriteLine();

            Otobus o1 = new Otobus("60TB666", "Mercedes-O403", 50);
            o1.YolcuAl(32);
            o1.YolcuAl(40);
            o1.YolcuBosalt(5);
            Console.WriteLine("An itibari ile bu otobuste {0} yolcu vardir.", o1.YolcuSayisi);

            Console.ReadLine();
        }
    }
}
