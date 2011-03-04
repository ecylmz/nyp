using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace cs_giris
{
    public class Snf
    {
        public int x;
        public int y;

        public Snf()
        {
            x = 0;
            y = 0;
            Console.WriteLine("Varsayilan yapici metod");
        }
        public Snf(int a)
        {
            x = a;
            y = a;
            Console.WriteLine("Tek argumanli yapici metod");
        }
        public Snf(int a, int b)
        {
            x = a;
            y = b;
            Console.WriteLine("Iki argumanli yapici metod");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Snf sn1 = new Snf(4); // sn1 adinda Snf nesnesi, tek arg. yapici metod
            Console.WriteLine("sn1.x : {0}, sn1.y : {1}", sn1.x, sn1.y);
            Snf sn2 = new Snf(7, 9); // sn2 adinda Snf nesnesi, iki arg. yapici metod
            Console.WriteLine("sn2.x : {0}, sn2.y : {1}", sn2.x, sn2.y);
            sn1 = null; // sn1 referansinin bagli oldugu nesne kullanilmiyor, cop olarak toplanacak.

            System.Console.ReadKey();
        }
    }
}
