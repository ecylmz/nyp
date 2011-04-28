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
    new private static int islemYap(int arg1)
    { // gecersiz kilma soz konusu degil
        return (arg1 + arg1);
    }
}

public class Sinif3 : Sinif2
{
}

public class Sinif4
{
    static void Main()
    {
        int sonuc = Sinif2.islemYap(5);
        Console.WriteLine("Islem Sonucu : {0}", sonuc); // 25
        Console.ReadLine();
    }
}