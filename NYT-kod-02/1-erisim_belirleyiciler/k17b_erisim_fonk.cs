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
    {
        // Sinif1 den kalitlayan (miras alan)
        // Sinif2 sinifi
        void BosSatir()
        {
            Console.WriteLine();
        }
    }
    class Sinif3:Sinif2
    {
        // Sinif3 den kalitlayan Sinif2 sinifi
        static void Main()
        {
            // kalitlayan sinifin nesnesi
            Sinif3 snf3 = new Sinif3();
            snf3.Fonksiyon1();
        }
    }
}
