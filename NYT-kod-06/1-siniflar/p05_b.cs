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
    {
        return (arg1 + arg1);
    }
    public static void fonk(int arg)
    {
        Console.WriteLine("Islem Sonucu : {0}", islemYap(arg));
    }
}

public class Sinif3 : Sinif2
{
}

public class Sinif4
{
    static void Main()
    {
        Sinif3.fonk(5);
        Console.ReadLine();
    }
}
