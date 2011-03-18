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
        //void Fonksiyon1() YA DA
        // private void Fonksiyon1()
        // yazilirsa da ayni sinif icinden ulasilabilir
        static void Main()
        { // Sinif1 sinifinin bir nesnesi : snf1
            Sinif1 snf1 = new Sinif1();
            snf1.Fonksiyon1();
        }
    }
}
