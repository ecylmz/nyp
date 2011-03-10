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
    }
    class Sinif2
    {
        static void Main()
        { // hata : Fonksiyon1 bulundu ama erisim izni yok
            Sinif1.Fonksiyon1();
        }
    }
}
