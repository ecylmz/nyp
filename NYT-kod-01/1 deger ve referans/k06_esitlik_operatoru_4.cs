using System;
// referanslarin "==" operatoru ile karsilastirilmasi
namespace Uzay1
{
    public class Sinif1
    {
        static void Main()
        {
            // isimsiz bir cam sandik olustur, icerisine "OMUbi19" koy,
            // sandigi kilitleyip anahtarini yok et ve sandigin yerini,
            // yeni olusturacagin str1 adres tutacagina kaydet
            string str1 = "OMUbi19";
            // neden cam sandik? neden kilitlenip anahtari yok ediliyor?
            // karakter dizileri bellekte sadece okunabilir formda tutulur
            // bunlarin uzerinde sonradan degisiklik yapilamaz, sadece okunabilir

            // ayni seyler str2 icin gecerli
            string str2 = "OMUbi19";


            Console.WriteLine("str1 == str2 : {0}", str1 == str2);
            Console.WriteLine(str1[2]);
            str1[2] = 'E'; // hatali : karakter dizileri degistirilemezler


            System.Console.Read();
        }
    }
}
