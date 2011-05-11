using System;

public class Sinif1
{
    static int Bol(int bolunen, int bolen)
    {
        return bolunen / bolen;
    }

    static void Main()
    {
        Console.WriteLine("1. ISLEMIN SONUCU : {0}", Bol(3, 2));
        Console.WriteLine("2. ISLEMIN SONUCU : {0}", Bol(2, 3));
        Console.WriteLine("3. ISLEMIN SONUCU : {0}", Bol(3, 0));
        // 3. islemde calisma ani hatasi olacaktir: sayi/0

        Console.ReadLine();
    }
}
