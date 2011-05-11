using System;

public class Dizi<T>
{ // Jenerik dizi (T: herhangi bir tip)
    private int indeks;
    private int boyut;
    private T[] dizi;

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
    public void Yazdir()
    {
        for (int i = 0; i < boyut; i++)
            Console.WriteLine("{0}", dizi[i]);
    }
}

public class Sinif1
{
    static void Main()
    {
        Dizi<int> TamsayiDizisi = new Dizi<int>(3);
        TamsayiDizisi.SonaEkle(7);
        TamsayiDizisi.SonaEkle(12);
        int i1 = TamsayiDizisi.SondanCikar();
        Console.WriteLine("####### i1 : {0}", i1);
        TamsayiDizisi.SonaEkle(24);
        TamsayiDizisi.SonaEkle(25);
        TamsayiDizisi.SonaEkle(26);
        TamsayiDizisi.Yazdir();

        Console.WriteLine("********************");

        Dizi<string> KaraterKatariDizisi = new Dizi<string>(5);
        KaraterKatariDizisi.SonaEkle("yedi");
        KaraterKatariDizisi.SonaEkle("oniki");
        string s1 = KaraterKatariDizisi.SondanCikar();
        Console.WriteLine("####### s1 : {0}", s1);
        KaraterKatariDizisi.SonaEkle("yirmidort");
        KaraterKatariDizisi.SonaEkle("yirmibes");
        KaraterKatariDizisi.SonaEkle("yirmialti");
        KaraterKatariDizisi.Yazdir();

        Console.ReadLine();
    }
}