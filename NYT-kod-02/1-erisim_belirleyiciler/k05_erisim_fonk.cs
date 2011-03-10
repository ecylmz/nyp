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
        static void Main()
        {
            // hata : nesne yaratilmadan cagrilan fonksiyon
            // statik erisimli olmalidir
            Fonksiyon1();
        }
    }
}
