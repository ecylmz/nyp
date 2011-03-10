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
        { // dogru kullanim
            Sinif1 snf1 = new Sinif1();
            snf1.Fonksiyon1();
        }
    }
}
