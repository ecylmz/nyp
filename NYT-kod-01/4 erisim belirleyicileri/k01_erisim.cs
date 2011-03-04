using System;

namespace Uzay1
{
    public class Sinif1
    {
        // bu sinifin nesnesi yaratilarak kullanilabilen ve bu sinif da dahil
        // tum siniflardan erisilebilen a degiskeni
        public int a = 3;

        // bu sinifin nesnesi yaratilmadan kullanilabilen ve bu sinif da dahil
        // tum siniflardan erisilebilen b degiskeni
        static int b = 4;

        static void Main()
        {   
            public int c = 5; // hatali : fonksiyon icerisinde erisim belirtici kullanilamaz
            static int d = 6; // hatali : fonksiyon icerisinde erisim belirtici kullanilamaz
            int e = 7;

            Console.WriteLine("a sayisi : {0}", Sinif1.a); // hatali : a ya erismek icin Sinif1 nesnesi gerekli 
            Console.WriteLine("b sayisi : {0}", Sinif1.b);
            Console.WriteLine("e sayisi : {0}", e);
            System.Console.Read();
		}
	}
}