using System;

public class Sinif1
{
    protected int a, b;

    public int topla()
    {
        return (a + b);
    }

    public static void argumaniYaz(string arguman)
    {
        Console.WriteLine(arguman);
    }

    public Sinif1()
    {
        a = 0;
        b = 0;
    }
    public Sinif1(int arg1, int arg2)
    {
        a = arg1;
        b = arg2;
    }
}
public class Sinif2 : Sinif1
{
    public Sinif2(int arg1, int arg2)
    {
        a = arg1 + 1;
        b = arg2 + 1;
    }
}

public class Sinif3
{
    static void Main()
    {
        Sinif2 nesne1 = new Sinif2(3, 4);
        int toplam = nesne1.topla();
        Sinif2.argumaniYaz("Sinif3' ten merhaba...");
        Console.WriteLine("Toplam : {0}", toplam);
        Console.WriteLine("nesne1.a : {0}, nesne1.b : {1}", nesne1.a, nesne1.b);

        // Sinif2 nesne2 = new Sinif2();
        // hata: Sinif2' de varsayilan yapici metot tanimlanmamis
        Console.ReadLine();
    }
}
