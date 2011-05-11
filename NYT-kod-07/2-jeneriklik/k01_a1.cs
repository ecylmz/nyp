using System;

public class DiziInt
{ // 32 bit tamsayilar icin tasarlanmis DiziInt sinifi
    private int indeks;
    private int boyut;
    private int[] dizi;

    public DiziInt(int b)
    { // yapici metot
        indeks = 0;
        boyut = b;
        dizi = new int[boyut];
    }
    public void SonaEkle(int eleman)
    { 
        if (indeks < boyut)
        {
            dizi[indeks++] = eleman;
        }
    }
    public int SondanCikar()
    {
        if (indeks > 0)
        {
            return dizi[--indeks];
        }
        else
            return 0;
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
        DiziInt TamsayiDizisi = new DiziInt(3);
        TamsayiDizisi.SonaEkle(7);
        TamsayiDizisi.SonaEkle(12);
        int i1 = TamsayiDizisi.SondanCikar();
        Console.WriteLine("####### i1 : {0}", i1);
        TamsayiDizisi.SonaEkle(24);
        TamsayiDizisi.SonaEkle(25);
        TamsayiDizisi.SonaEkle(26);
        TamsayiDizisi.Yazdir();

        Console.ReadLine();
    }
}