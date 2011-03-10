using System;

namespace Uzay1
{
    class Sinif1
    {
        public void Fonksiyon1()
        { // statik olmayan fonksiyon
            Console.WriteLine("Merhaba dunya!");
            Console.ReadLine();
        }
    }
    class Sinif2
    {
        static void Main()
        {
            // hata : Fonksiyon1 bulundu ancak cagirabilmek
            // icin Sinif1 sinifinin nesnesini yaratmak gerekiyor
            Sinif1.Fonksiyon1();
        }
    }
}
