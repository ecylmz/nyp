using System;

namespace Uzay1
{
    class Sinif1
    {
        public static void Fonksiyon1()
        { // statik eriþimli fonksiyon
            Console.WriteLine("Merhaba dunya!");
            Console.ReadLine();
        }
    }
    class Sinif2
    {
        static void Main()
        { // dogru kullanim
            Sinif1.Fonksiyon1();
        }
    }
}
