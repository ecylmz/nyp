using System;

namespace Uzay1
{
    public class Sinif1
    {// Uzay1 isim uzayi icerisinde Sinif1 sinifi

        // bu sinif ve bundan kalitlayan siniflardan erisilebilir
        protected int c = 7;
        
    }
    
    public class Sinif2:Sinif1
    {// Sinif2, Sinif1' den kalitlar yani ondan miras alir
        static void Main()
        {   
            Sinif1 nesne1 = new Sinif1();
            // hatali. Sinif1 deki protected bir degeri Sinif2 de kullanabilmek
            // icin elimizdeki nesne Sinif1' e degil, Sinif1' in mirascisi olan
            // Sinif2' ye ait olmalidir.
            Console.WriteLine(nesne1.c); 
            System.Console.Read();
        }
    }
}
