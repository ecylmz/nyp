using System;
using System.IO;

public class Sinif1
{
    static void Main()
    {
        DateTime basla, bitir;
        TimeSpan sure;

        int sayac, a = 1, b = 2, c = 3, d = 4, e = 5;

        basla = DateTime.Now;
        for (sayac = 0; sayac < 1000000000; sayac++)
        {
            a = b; b = c; c = d; d = e; e = a;
        }
        bitir = DateTime.Now;

        sure = bitir - basla;

        Console.WriteLine("Gecen Sure : {0}", sure);
        Console.ReadLine();
    }
}
