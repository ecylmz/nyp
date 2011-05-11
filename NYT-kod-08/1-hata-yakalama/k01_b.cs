using System;

public class Sinif1
{
    static int Bol(int bolunen, int bolen)
    {
        if (bolen != 0) // Basit bir hata kontrolu
            return bolunen / bolen;
        else
        {
            Console.WriteLine("Bolen sayi sifir olamaz!"); // uyari
            return bolunen / (bolen - 1);
        }
    }

    static void Main()
    {
        Console.WriteLine("1. ISLEMIN SONUCU : {0}", Bol(3, 2));
        Console.WriteLine("2. ISLEMIN SONUCU : {0}", Bol(2, 3));
        Console.WriteLine("3. ISLEMIN SONUCU : {0}", Bol(3, 0));
        Console.ReadLine();
    }
}
