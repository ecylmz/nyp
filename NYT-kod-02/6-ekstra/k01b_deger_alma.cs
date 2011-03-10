using System;
// kullanicidan deger alma
namespace Uzay1
{
    class Sinif1
    {
        static void Main()
        {
            string girilen;
            int sayi;
            
            //istek mesaji
            Console.Write("Bir tamsayi giriniz (cikis icin: 'e' [ENTER] [ENTER] tuslayiniz) : ");

            // girilen deger
            girilen = Console.ReadLine();

            // alinan deger "e" olmadigi surece && (ve)
            // alinan deger "E" olmadigi surece
            while (girilen != "e" && girilen != "E")
            {
                // alinan degeri tamsayiya cevir
                sayi = Convert.ToInt32(girilen);

                // degerlendirme sonuclari yazilsin
                if (sayi > 5)
                    Console.WriteLine("\nGirdiginiz tamsayi 5 ten buyuktur.");
                else
                    Console.WriteLine("\nGirdiginiz tamsayi 5 ten buyuk degildir.");

                // Bir tusa basilana kadar degerlendirme sonuclari silinmesin
                Console.WriteLine("\n\nDevam etmek icin [ENTER] a basiniz...");
                Console.ReadKey();

                Console.Clear(); //ekrani temizleme fonksiyonu
                Console.Write("Bir tamsayi giriniz (cikis icin: 'e' [ENTER] [ENTER] tuslayiniz) : ");
                girilen = Console.ReadLine();
            }
            Console.ReadLine();
        }
    }
} // ya kullanici "f" girerse ??? : calisma ani hatasi
