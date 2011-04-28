using System;
// hata : dongusel bir kalitlama iliskisi kurulamaz
public class Sinif1 : Sinif3
{
    public static int islemYap1(int arg1)
    {
        return (arg1 * arg1);
    }
}

public class Sinif2 : Sinif1
{
    public static int islemYap2(int arg1)
    {
        return (arg1 + arg1);
    }
}

public class Sinif3 : Sinif2
{
}

public class Sinif4
{
    static void Main()
    {
        int sonuc1 = Sinif3.islemYap1(5);
        int sonuc2 = Sinif3.islemYap2(5);
        Console.WriteLine("1. Islem Sonucu : {0}", sonuc1);
        Console.WriteLine("2. Islem Sonucu : {0}", sonuc2);
        Console.ReadLine();
    }
}
