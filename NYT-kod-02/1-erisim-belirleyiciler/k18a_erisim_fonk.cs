using System;

namespace Uzay1
{
    class Sinif1
    {
        protected static void Fonksiyon1()
        { // protected erisimli statik fonksiyon
            Console.WriteLine("Merhaba dunya!");
            Console.ReadLine();
        }
    }
    class Sinif2
    {
        static void Main()
        {
            // Sinif1 sinifinda bulunan protected
            // erisimli statik bir fonksiyon olan
            // Fonksiyon1 cagriliyor
            Sinif1.Fonksiyon1(); // hatali
        }
    }
}
