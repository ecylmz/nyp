using System;

public class Sinif1
{
    static int IslemYap(int sayi1, int sayi2)
    {
        int a, b, c, d;

        a = sayi1 + sayi2;
        b = sayi1 - sayi2;
        c = a + b - 2;
        d = a - c - b;
        b = c / d;
        a = (b + 4) / (c - 4);
        c = d / (sayi1 - a);

        return c;
    }

    static void Main()
    {
        Console.WriteLine("1. ISLEMIN SONUCU : {0}", IslemYap(7, 5));
        Console.WriteLine("2. ISLEMIN SONUCU : {0}", IslemYap(2, 6));
        Console.WriteLine("3. ISLEMIN SONUCU : {0}", IslemYap(4, 3));
        // 3. islemde calisma ani hatasi olacaktir: sayi/0
        Console.ReadLine();
    }
}
