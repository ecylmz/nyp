using System;

namespace Uzay1
{
    class Sinif1
    {
        static void Fonksiyon1()
        { // statik eri�imli fonksiyon
            Console.WriteLine("Merhaba dunya!");
            Console.ReadLine();
        }
        static void Main()
        { 
            // hata : statik eri�imli bir fonksiyona nesne
            // �zerinden eri�im yap�lamaz
            Sinif1 snf1 = new Sinif1();
            snf1.Fonksiyon1();
        }
    }
}
