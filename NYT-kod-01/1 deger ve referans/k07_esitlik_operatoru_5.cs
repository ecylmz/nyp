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

            // isimsiz bir cam sandik olustur,
            // System.String sinifindaki Copy fonksiyonuna str1 referansini
            // ver. bu fonksiyon ilgili referansi takip ederek bulacagi
            // degerin bir kopyasini dondurecektir. bu donus degerini
            // olusturdugun cam sandiga koy, sandigi kitle, anahtarini
            // yok et ve sandigin yerini str2 tutacaginda tut
            string str2 = string.Copy(str1);

            // cam sandiklarin iclerinde ayni seyler mi var? EVET
            Console.WriteLine("STRING : str1 == str2 : {0}", str1 == str2);

            // cam sandiklari iki ayri valize koy ve referanslari kaydet.
            // her 2 referansin gosterdigi valiz ayni valiz mi? HAYIR
            Console.WriteLine("OBJECT : str1 == str2 : {0}", (object)str1 == (object)str2);

            // == operatoru ile cam sandiklar karsilastirilirken sandiklarin icine bakilir : DEGER
            // == operatoru ile valiz referanslari karsilastirilirken ayni valizi gosterip-
            // gostermediklerine bakilir : REFERANS

            System.Console.Read();
        }
    }
}
