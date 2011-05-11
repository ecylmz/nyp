using System;

public class Sinif1
{
    static void IslemYap()
    {
        int a = 0, b = 1, c = 2, d = 3;

        Console.WriteLine("[birinci konum] --> c : {0}", c);

        try
        {
            Console.WriteLine("[ikinci konum]  --> c : {0}", c);
            c = 7;
            Console.WriteLine("[ucuncu konum]  --> c : {0}", c);
            d = b / a; // calisma ani hatasi
            Console.WriteLine("[dorduncuuncu konum] --> c : {0}", c);
        }
        catch
        {
            Console.WriteLine("[besinci konum] --> c : {0}", c);
        }
        Console.WriteLine("[altinci konum] --> c : {0}", c);
    }

    static void Main()
    {
        IslemYap();
        Console.ReadLine();
    }
}
