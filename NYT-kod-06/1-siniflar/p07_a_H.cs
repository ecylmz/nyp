using System;

public class Sinif1
{
    public static int islemYap1(int arg1)
    {
        return (arg1 * arg1);
    }
}

public class Sinif2
{
    public static int islemYap2(int arg1)
    {
        return (arg1 + arg1);
    }
}

public class Sinif3 : Sinif1, Sinif2
{ // hata: birden fazla sayida siniftan miras alinamaz
}

public class Sinif4
{
    static void Main()
    {
        int sonuc1 = Sinif3.islemYap1(5);
        int sonuc2 = Sinif3.islemYap2(5);
        Console.WriteLine("1. Islem Sonucu : {0}", sonuc1);
        Console.WriteLine("2. Islem Sonucu : {0}", sonuc2);
        Console.ReadLine();
    }
}
