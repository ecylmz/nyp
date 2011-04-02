using System;

// sabit listesinin ilan edilmesi
public enum Ses : byte
{
    Dusuk = 1,
    Orta, // 2
    Yuksek // 3
}

class Sinif1
{
    static void Main()
    {
        Sinif1 nesne1 = new Sinif1();

        // Acik donusum: int --> Ses
        nesne1.KullanicidanSabitListesiAl();

        // Ses listesinde ada gore gez
        nesne1.ListeUyeleriniAdaGoreSirala();

        // Ses listesinde degere gore gez
        nesne1.ListeUyeleriniDegereGoreSirala();

        Console.ReadLine();
    }

    public void KullanicidanSabitListesiAl()
    {
        Console.WriteLine("\n----------------");
        Console.WriteLine("Ses Ayarlari:");
        Console.WriteLine("----------------\n");

        Console.Write(@"
1 - Dusuk
2 - Orta
3 - Yuksek

Lutfen secim yapiniz (1, 2, ya da 3): ");

        string sesString = Console.ReadLine();
        int sesInt = Int32.Parse(sesString);

        // Acik donusum: int --> Ses
        Ses sesDegeri = (Ses)sesInt;

        Console.WriteLine();

        // Karar ver:
        switch (sesDegeri)
        {
            case Ses.Dusuk:
                Console.WriteLine("Ses kisildi.");
                break;
            case Ses.Orta:
                Console.WriteLine("Ses orta seviyede.");
                break;
            case Ses.Yuksek:
                Console.WriteLine("Ses acildi.");
                break;
        }

        Console.WriteLine();
    }

    // Ses listesinde ada gore gez
    public void ListeUyeleriniAdaGoreSirala()
    {
        Console.WriteLine("\n---------------------------- ");
        Console.WriteLine("Ada gore liste uyeleri:");
        Console.WriteLine("----------------------------\n");

        // Ses listesinden uye adlarinin bir listesini al
        // sayisal degerleri elde et ve goster
        foreach (string ses in Enum.GetNames(typeof(Ses)))
        {
            Console.WriteLine("Ses Uyesi: {0}\n Deger: {1}",
                ses, (byte)Enum.Parse(typeof(Ses), ses));
        }
    }

    // Ses listesinde degere gore gez
    public void ListeUyeleriniDegereGoreSirala()
    {
        Console.WriteLine("\n----------------------------- ");
        Console.WriteLine("Degere gore liste uyeleri:");
        Console.WriteLine("-----------------------------\n");

        // Ses listesindeki tum sayisal degerleri al,
        // uye adlarini elde et ve goster
        foreach (byte deger in Enum.GetValues(typeof(Ses)))
        {
            Console.WriteLine("Ses Degeri: {0}\n Uye: {1}",
                deger, Enum.GetName(typeof(Ses), deger));
        }
    }
}