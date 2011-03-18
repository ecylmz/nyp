using System;
using System.IO;

namespace DosyaIslemleri
{
    public class OkumaYazma
    {
        public static string Oku(string DosyaAdresi)
        { // dosyanin icerigini string olarak dondurur
            // DOSYA BULUNAMAZSA: CALISMA ANI HATASI
            string okunan = "";

            // StreamReader sinifi nesnesi yarat
            StreamReader sr = new StreamReader(DosyaAdresi);

            // nesneye mesaj gondererek ReadToEnd fonk. cagir
            okunan = sr.ReadToEnd();

            // okunan dosyayi serbest birakmak icin gerekli
            sr.Close();
            return okunan;
        }

        public static void Yaz(string DosyaAdresi, string metin)
        { // belli bir karakter dizisini dosyaya yazar

            // StreamReader sinifi nesnesi yarat
            StreamWriter sw = new StreamWriter(DosyaAdresi);

            // ilgili dosyaya metin in icerigini yaz
            sw.Write(metin);

            // kaydet ve dosyayi serbest birak
            sw.Close();
        }
    }

    class Program
    {
        static void Main()
        {
            string pascal = "1\n1\t1\n1\t2\t1\n1\t3\t3\t1\n1\t4\t6\t4\t1";

            // WINDOWS: "C:\" altinda "kaynak.txt" dosyasi olmali
            // UNIX : bir metin dosyasi olusturarak adresini giriniz
            // okunan dosyanin icerigi str icerisine aktarildi
            string str = OkumaYazma.Oku("C:/kaynak.txt");

            // WINDOWS : "C:\" altinda "hedef.txt" dosyasi olusturulacak
            // UNIX : istediginiz dizinde istediginiz dosya adini giriniz
            // pascal in icerigi hedef dosyaya yazilacak
            OkumaYazma.Yaz("C:/hedef.txt", pascal);

            // dosyadan okunan metni ekrana yaz
            Console.WriteLine(str);
            Console.ReadLine();
        }
    }
}
