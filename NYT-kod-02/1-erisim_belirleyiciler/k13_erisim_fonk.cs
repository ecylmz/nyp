using System;

namespace Uzay1
{
    class Sinif1
    {
        void Fonksiyon1()
        { // private erisimli fonksiyon
            Console.WriteLine("Merhaba dunya!");
            Console.ReadLine();
        }
    }
    class Sinif2
    {
        static void Main()
        { // hatali : erisim hakki yok
            Sinif1 snf1 = new Sinif1();
            snf1.Fonksiyon1();
        }
    }
}
