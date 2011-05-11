using System;
using System.IO;

public class Sinif1
{
    static void ToplaYaz()
    {
        int toplam = 0;

        try
        {
            Console.Write("Lutfen 1. sayiyi giriniz : ");
            toplam += Convert.ToInt32(Console.ReadLine());
            Console.Write("Lutfen 2. sayiyi giriniz : ");
            toplam += Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nTOPLAM : {0}", toplam);
        }
        catch
        {
            Console.WriteLine("Girilen degerler tamsayi formatina uygun olmalidir!");
        }
    }
    static void Main()
    {
        ToplaYaz();
        Console.ReadLine();
    }
}
