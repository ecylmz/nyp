using System;

namespace Uzay1
{ // Uzay1
    namespace Uzay2
    { // Uzay1.Uzay2
        public class Sinif
        { // Uzay1.Uzay2->Sinif
            public static void Fonksiyon()
            { // Uzay1.Uzay2->Sinif.Fonksiyon
                Console.WriteLine("Uzay1.Uzay2 -> Sinif.Fonksiyon");
            }
        }
        namespace Uzay3
        { // Uzay1.Uzay2.Uzay3
            public class Sinif
            { // Uzay1.Uzay2.Uzay3->Sinif
                public static void Fonksiyon()
                { // Uzay1.Uzay2.Uzay3->Sinif.Fonksiyon
                    Console.WriteLine("Uzay1.Uzay2.Uzay3 -> Sinif.Fonksiyon");
                }
            }
        }
    }
    public class Sinif
    { // Uzay1.Sinif
        static void Main()
        { // Uzay1.Sinif->Main
            Uzay1.Uzay2.Sinif.Fonksiyon();
            Uzay1.Uzay2.Uzay3.Sinif.Fonksiyon();
            Uzay4.Sinif.Fonksiyon();
            Console.WriteLine("Uzay1 -> Sinif.Main");
            Console.ReadLine();

            // Uzay2, bulundugumuz sinifla ayni uzay (Uzay1) icinde
            Uzay2.Sinif.Fonksiyon();
            // Uzay3.Sinif.Fonksiyon(); // hata: Uzay3 dogrudan gorulemez
            Console.ReadLine();
        }
    }
}

namespace Uzay4
{ // Uzay4
    public class Sinif
    { // Uzay4->Sinif
        public static void Fonksiyon()
        { // Uzay4->Sinif.Fonksiyon
            Console.WriteLine("Uzay4 -> Sinif.Fonksiyon");
        }
    }
}
