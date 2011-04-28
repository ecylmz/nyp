using System;

public class Sinif1
{
    public int a = 7;

    public int islemYap()
    {
        return (a * a);
    }
}
public class Sinif2 : Sinif1
{
    public static int islemYap()
    { // gecersiz kilma soz konusu
        return 500;
    }
}
public class Sinif3 : Sinif2
{
}
public class Sinif4
{
    static void Main()
    {
        Sinif3 nesne1 = new Sinif3();
        Console.WriteLine("1. Islem Sonucu : {0}", nesne1.islemYap()); // hata
        Console.WriteLine("2. Islem Sonucu : {0}", Sinif3.islemYap());
        Console.ReadLine();
    }
}
