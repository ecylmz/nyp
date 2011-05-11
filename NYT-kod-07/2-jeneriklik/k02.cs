using System;

public class Dizi<T>
{ // Jenerik dizi (T: herhangi bir tip)
    private int indeks;
    private int boyut;
    public T[] dizi;

    public Dizi(int b)
    { // yapici metot
        indeks = 0;
        boyut = b;
        dizi = new T[boyut];
    }
    public void SonaEkle(T eleman)
    {
        if (indeks < boyut)
        {
            dizi[indeks++] = eleman;
        }
    }
    public T SondanCikar()
    {
        if (indeks > 0)
        {
            return dizi[--indeks];
        }
        else
            return default(T);
        // T tipinin varsayilan degeri (int ise "0", string ise "null")
    }
}

public class Sinif1
{
    public int a, b;
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

public class Sinif2
{
    public string x, y;
    public Sinif2()
    {
        x = "";
        y = "";
    }
    public Sinif2(string arg1, string arg2)
    {
        x = arg1;
        y = arg2;
    }
}

public class Sinif3
{
    static void Main()
    {
        Sinif1 nesne1 = new Sinif1(1, 2);
        Sinif1 nesne2 = new Sinif1(3, 4);
        Sinif1 nesne3 = new Sinif1(5, 6);
        Sinif1 nesne4 = new Sinif1(7, 8);

        Dizi<Sinif1> Sinif1Dizisi = new Dizi<Sinif1>(3); // T = Sinif1
        Sinif1Dizisi.SonaEkle(nesne1);
        Sinif1Dizisi.SonaEkle(nesne2);
        Sinif1Dizisi.SonaEkle(nesne3);
        Sinif1Dizisi.SonaEkle(nesne4);
        Console.WriteLine("a : {0}\t\tb : {1}", Sinif1Dizisi.dizi[2].a, Sinif1Dizisi.dizi[2].b);

        Console.WriteLine("*************************");

        Sinif2 nesne5 = new Sinif2("bir", "iki");
        Sinif2 nesne6 = new Sinif2("uc", "dort");
        Sinif2 nesne7 = new Sinif2("bes", "alti");
        Sinif2 nesne8 = new Sinif2("yedi", "sekiz");

        Dizi<Sinif2> Sinif2Dizisi = new Dizi<Sinif2>(3); // T = Sinif2
        Sinif2Dizisi.SonaEkle(nesne5);
        Sinif2Dizisi.SonaEkle(nesne6);
        Sinif2Dizisi.SonaEkle(nesne7);
        Sinif2Dizisi.SonaEkle(nesne8);
        Console.WriteLine("x : {0}\t\ty : {1}", Sinif2Dizisi.dizi[2].x, Sinif2Dizisi.dizi[2].y);

        Console.ReadLine();
    }
}