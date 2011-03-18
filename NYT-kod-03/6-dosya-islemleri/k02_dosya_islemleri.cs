using System;
using System.IO;

namespace DosyaIslemleri
{
    class OkumaYazma
    { // internal erisimli sinif
        protected static string Oku(string DosyaAdresi)
        { // sadece mirasla aktarilsin
            string okunan = "";
            StreamReader sr = new StreamReader(DosyaAdresi);
            okunan = sr.ReadToEnd();
            sr.Close();
            return okunan;
        }

        protected static void Yaz(string DosyaAdresi, string metin)
        { // sadece mirasla aktarilsin
            StreamWriter sw = new StreamWriter(DosyaAdresi);
            sw.Write(metin);
            sw.Close();
        }
    }

    class KullaniciEtkilesim : OkumaYazma
    { // OkumaYazma sinifindan miras alinsin
        // sinifin public uyesi
        public string adres;

        public KullaniciEtkilesim(string DosyaAdresi)
        { // tek arg. alan yapici metot
            adres = DosyaAdresi;
        }

        private string MetinAl()
        {
            // erisim: private. Neden?
            // Bu fonksiyonun ne yaptigi sadece bu sinifi
            // ilgilendiriyor. Bu sinifin nesnesini yaratan diger siniflarin,
            // GERCEKLESTIRIM AYRINTISINI gormesini istemiyoruz.
            // Yani, bu sinifin nesnesi yaratildiginda yanlislikla
            // bu fonksiyonun cagrilmasini istemiyoruz.
            string metin = "", temp;
            while (true)
            { // sonsuza kadar devam et:
                temp = Console.ReadLine();
                // kullanici karakter girmeden [ENTER] a basarsa
                // temp == "" sarti saglanacaktir
                if (temp == "")
                    break;
                // ReadLine ile alinan her dizinin sonuna yeni satir
                // karakteri ekle
                metin = metin + temp + "\n";
            }
            return metin;
        }
        public void EkrandanDosyayaAktar()
        { // disaridan erisilebilir fonksiyon
            Console.WriteLine("Metin yazmaya baslamak icin [ENTER] a basiniz.");
            Console.WriteLine("Yazma islemini sonlandirmak icin 2 kez [ENTER] a basiniz.");
            Console.ReadLine();
            Console.Clear();
            string yazilacak = MetinAl();
            Console.Clear();
            Console.WriteLine("Kullanicidan metin alindi. Dosyaya yazmak icin : [ENTER]");
            Console.ReadLine();
            // Yaz fonksiyonu, bu sinifa miras yolu ile gelmisti.
            Yaz(adres, yazilacak);
            Console.WriteLine("Metin dosyaya yazildi. Cikmak icin : [ENTER]");
            Console.ReadLine();
        }
    }


    class Program
    {
        static void Main()
        {
            KullaniciEtkilesim ke = new KullaniciEtkilesim("C:/EkranaYazilanlar.txt");
            ke.EkrandanDosyayaAktar();
        }
    }
}
