using System;

namespace Uzay1
{
    class Sinif1
    {
        protected void Fonksiyon1()
        { // protected erisimli fonksiyon
            Console.WriteLine("Merhaba dunya!");
            Console.ReadLine();
        }
     }
    class Sinif2:Sinif1
    { // Sinif1 den kalitlayan (miras alan) Sinif2 sinifi
        static void Main()
        {
            // hatali : kalitlanan degil kalitlayan
            // sinifin nesnesi uzerinden ulasilmaliydi
            Sinif1 snf1 = new Sinif1();
            snf1.Fonksiyon1();
        }
    }
}
