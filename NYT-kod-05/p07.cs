using System;

namespace OrnekSiniflar
{
    public class Sinif1
    {
        public int x;
        public int y;
        public Sinif1 snf; // dongusel tanimlama

        public Sinif1(int arg1, int arg2)
        {
            x = arg1;
            y = arg2;
        }
    }

    public class Sinif2
    {
        static void Main()
        {
            Sinif1 nesne1 = new Sinif1(3, 4);
            Sinif1 nesne2 = new Sinif1(5, 6);
            Sinif1 nesne3 = new Sinif1(7, 8);

            nesne1.snf = nesne2;
            nesne2.snf = nesne3;
            nesne3.snf = nesne1;

            Console.WriteLine("nesne1.x              --> {0}", nesne1.x);
            Console.WriteLine("nesne1.snf.x          --> {0}", nesne1.snf.x);
            Console.WriteLine("nesne1.snf.snf.x      --> {0}", nesne1.snf.snf.x);
            Console.WriteLine("nesne1.snf.snf.snf.x -- > {0}", nesne1.snf.snf.snf.x);

            Console.ReadLine();
        }
    }
}
