using System;

public class DiziString
{ // karakter katarlari icin tasarlanmis DiziString sinifi
    private int indeks;
    private int boyut;
    private string[] dizi;

    public DiziString(int b)
    { // yapici metot
        indeks = 0;
        boyut = b;
        dizi = new string[boyut];
    }
    public void SonaEkle(string eleman)
    { 
        if (indeks < boyut)
        {
            dizi[indeks++] = eleman;
        }
    }
    public string SondanCikar()
    {
        if (indeks > 0)
        {
            return dizi[--indeks];
        }
        else
            return null;
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
        DiziString KaraterKatariDizisi = new DiziString(5);
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