using System;

namespace Uzay1
{
    public class Sinif1
    {
        static void Main()
        {
            // a1 adinda tek boyutlu bir dizi gostericisi (adres tutucu)
            // gostericinin isaret ettigi yer henuz belirsiz
            int[] a1; // a1 in ilan edilmesi

            // bellekte tek boyutlu ve 5 elemanli bir tamsayi dizisi
            // konacak kadar yer acilir ve bu yerin baslangic adresi
            // a1 gostericisinde saklanir
            a1 = new int[5]; // a1 in ilklenmesi

            // dizinin uzunlugunu ekrana yazdirma:
            Console.WriteLine("a1 dizisinin uzunlugu   : {0}", a1.Length);

            // dizinin 2. elemanini yazdirma
            // C#' da tamsayi dizileri ilklendiginde tum indekslerinde bulunan
            // degerler otomatik olarak 0 yapilir
            Console.WriteLine("ilkleme sonrasi a1 dizisinin 2. elemani : {0}", a1[2]);

            // dizinin 2. indeksindeki (2. indeks = bastan 3. indeks) elemanina
            // atama yapilmasi
            a1[2] = 123456;

            Console.WriteLine("atama sonrasi a1 dizisinin 2. elemani   : {0}", a1[2]);
            System.Console.Read();
        }
    }
}
