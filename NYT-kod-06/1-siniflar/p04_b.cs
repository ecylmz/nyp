using System;

public class Sinif1
{
    public static int islemYap(int arg1)
    {
        return (arg1 * arg1);
    }
}

public class Sinif2 : Sinif1
{
    public static int islemYap(int arg1)
    {
        return (arg1 * arg1 * arg1);
    }
}

public class Sinif3
{
    static void Main()
    {
        int sonuc1 = Sinif1.islemYap(5);
        int sonuc2 = Sinif2.islemYap(5);
        Console.WriteLine("1. Islem Sonucu : {0}", sonuc1);
        Console.WriteLine("2. Islem Sonucu : {0}", sonuc2);
        Console.ReadLine();
    }
}
