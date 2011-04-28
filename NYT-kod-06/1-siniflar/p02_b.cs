using System;

public class Sinif1
{
    public int a;

    public int islemYap()
    {
        return (a * a);
    }
    public Sinif1()
    {
        a = 0;
    }
    public Sinif1(int arg1)
    {
        a = arg1;
    }
}
public class Sinif2 : Sinif1
{
    public int islemYap()
    {
        return (a * a * a);
    }

    public Sinif2(int arg1)
    {
        a = arg1;
    }
}

public class Sinif3
{
    static void Main()
    {
        Sinif2 nesne1 = new Sinif2(3);
        int sonuc = nesne1.islemYap();
        Console.WriteLine("Islem Sonucu : {0}", sonuc);

        Console.ReadLine();
    }
}

