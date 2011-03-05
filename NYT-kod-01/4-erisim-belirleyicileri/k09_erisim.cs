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
            Sinif2 nesne2 = new Sinif2();
            Console.WriteLine(nesne2.c);// dogru 
            System.Console.Read();
        }
    }
}
