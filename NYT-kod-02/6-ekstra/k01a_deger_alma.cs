using System;
// kullanicidan deger alma
namespace Uzay1
{
    class Sinif1
    {
        static void Main()
        {
            // ekrana istekte bulunmak icin mesaj yaz
            Console.Write("Bir tamsayi giriniz : ");

            // kullanicinin ekrana yazdiktan sonra "enter" tusuna basarak
            // girdigi degeri 32 bitlik tamsayiya cevir ve "sayi"
            // degiskeninin icerisine at (bu yolla kullanicidan alinan
			// degerler "string" turundendir)
            int sayi = Convert.ToInt32(Console.ReadLine());

            // kullanicinin tamsayiya cevrilemeyecek bir deger girmesi
            // halinde program calisma ani hatasi verecektir. bu durumun
            // onune nasil gecilebilecegi ileriki konularda ele alinacaktir.

            if (sayi > 5)
                Console.WriteLine("\nGirdiginiz tamsayi 5 ten buyuktur.");
            else
                Console.WriteLine("\nGirdiginiz tamsayi 5 ten buyuk degildir.");

            Console.ReadLine();
        }
    }
}
