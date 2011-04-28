using System;

public class Sinif1
{
    public int a;

    public int islemYap1()
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
    public int islemYap2()
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
        int sonuc1 = nesne1.islemYap1();
        int sonuc2 = nesne1.islemYap2();
        Console.WriteLine("1. Islem Sonucu : {0}", sonuc1);
        Console.WriteLine("2. Islem Sonucu : {0}", sonuc2);

        Console.ReadLine();
    }
}
