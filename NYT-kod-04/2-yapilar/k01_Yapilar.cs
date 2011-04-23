using System;

namespace Uzay1
{
    struct Dikdortgen
    {
        // en bilgisini sunda saklayalim:
        private int gizli_en;

        public int en
        { // en bilglisne erisim saglayan kopru
            get { return gizli_en; }
            set { gizli_en = value; }
        }

        // boy bilgisini sunda saklayalim:
        private int gizli_boy;

        public int boy
        { // boy bilglisne erisim saglayan kopru
            get { return gizli_boy; }
            set { gizli_boy = value; }
        }

        public Dikdortgen(int arg_en, int arg_boy)
        { // 2 argumanli yapici metot
            gizli_en = arg_en;
            gizli_boy = arg_boy;
        }

        public Dikdortgen Buyut(Dikdortgen dd)
        { // sinifin ornekleri uzerinde kullanilabilir
            Dikdortgen dikdortgen1 = new Dikdortgen();
            // ornegin "en" alt alanina, Buyut fonksiyonunu
            // cagirmis olan ornegin en degeri ile Buyut
            // fonksiyonuna arguman olarak verilen ornegin en
            // degerinin toplamini ata
            dikdortgen1.en = en + dd.en;
            dikdortgen1.boy = boy + dd.boy;
            return dikdortgen1;
        }
    }

    class Sinif1
    {
        static void Main()
        {
            // Dikdortgen yapisinin bir ornegini olustur
            Dikdortgen d1 = new Dikdortgen();
            d1.en = 2;
            d1.boy = 7;
            Console.WriteLine("d1:  {0}:{1}", d1.en, d1.boy);

            Dikdortgen d2 = new Dikdortgen(5, 6);
            Console.WriteLine("d2:  {0}:{1}", d2.en, d2.boy);

            Dikdortgen d3 = d1.Buyut(d2);
            Console.WriteLine("d3:  {0}:{1}", d3.en, d3.boy);

            // paylasma YOK, kopyalama VAR
            Dikdortgen d4 = d3;
            d4.en = 789; // d3 ile d4 iki ayri ornek
            Console.WriteLine("\nd3.en:  {0}", d3.en);
            Console.WriteLine("d4.en:  {0}", d4.en);

            Console.ReadLine();
        }
    }
}
