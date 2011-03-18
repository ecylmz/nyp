using System;

namespace Uzay1
{
    class Sinif1
    {
        static void Fonksiyon1()
        { // statik eriþimli fonksiyon
            Console.WriteLine("Merhaba dunya!");
            Console.ReadLine();
        }
        static void Main()
        { 
            // hata : statik eriþimli bir fonksiyona nesne
            // üzerinden eriþim yapýlamaz
            Sinif1 snf1 = new Sinif1();
            snf1.Fonksiyon1();
        }
    }
}
