using System;
using System.IO;

public class Sinif1
{
    static void ToplaYaz()
    {
        int toplam = 0;
        // girilen degerler tamsayiya donusturulebillir degilse
        // calisma ani hatasi ile karsilasilacaktir
        Console.Write("Lutfen 1. sayiyi giriniz : ");
        toplam += Convert.ToInt32(Console.ReadLine());
        Console.Write("Lutfen 2. sayiyi giriniz : ");
        toplam += Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("\nTOPLAM : {0}", toplam);
    }
    static void Main()
    {
        ToplaYaz();
        Console.ReadLine();
    }
}
