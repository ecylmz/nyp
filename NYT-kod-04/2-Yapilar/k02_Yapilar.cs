using System;

namespace Uzay1
{
    struct Dikdortgen
    {
        private int gizli_en;

        public int en
        {
            get { return gizli_en; }
            set { gizli_en = value; }
        }

        private int gizli_boy;
      
        public int boy
        {
            get { return gizli_boy; }
            set { gizli_boy = value; }
        }

        public Dikdortgen(int arg_en, int arg_boy)
        {
            gizli_en = arg_en;
            gizli_boy = arg_boy;
        }

        public Dikdortgen Buyut(Dikdortgen dd)
        {
            Dikdortgen dikdortgen1 = new Dikdortgen();
            dikdortgen1.en = en + dd.en;
            dikdortgen1.boy = boy + dd.boy;
            return dikdortgen1;
        }

        public static int Alan(Dikdortgen dd)
        { // yapilarda statik fonksiyonlar da bulunabilir
            return dd.en * dd.boy;
        }
    }

    class Sinif1
    {
        static void Main()
        {
            Dikdortgen d1 = new Dikdortgen();
            d1.en = 2;
            d1.boy = 7;
            Console.WriteLine("En: {0}\tBoy:{1}\tAlan:{2}", d1.en, d1.boy, Dikdortgen.Alan(d1));

            Console.ReadLine();
        }
    }
 }
