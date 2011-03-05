using System;

namespace Uzay1
{
    public class Sinif1
    {
        public int sayi = 0;
    }
    public class Sinif2
    {
        public string sozcuk = "bilgisayar";
    }

    public class Test
    {
        static void Main()
        {
            // Deger Turlerinde Tip Guvenligi
            // degiskenler 1 kez tanimlanip defalarca kullanilabilirler
            // (kullanma : atama yapma). bu surecte, tanimlandiklarinda
            // turleri ne ise program boyunca sadece o deger turunden
            // veriyi saklayabilirler.
            int deger1; // tanimlama
            deger1 = 3; // 1. atama
            deger1 = 5; // 2. atama
            deger1 = "KarakterDizisi"; // 3. atama: hatali

            // Referans Turlerinde Tip Guvenligi
            // referanslar da bir nesnenin adresini tutan adres
            // defterleridir. her referans, tanimlandiginda hangi
            // turden bir nesnenin adresini tutacagi belirlenir ve
            // bu referansla baska sinifa ait bir nesne adresi tutulamaz
            Sinif1 referans1a, referans1b; // Sinif1 referanslari
            Sinif2 referans2; // Sinif2 referansi

            referans1a = new Sinif1(); // Nesneyi referansa baglama
            referans1a.sayi = 7; // refere edilen nesnenin elemanini degistirme
            referans1b = referans1a; // refere edilen nesneyi paylasma
            referans2 = referans1a; // refere edilen nesneyi paylasma: hatali

            System.Console.Read();
        }
    }
}
