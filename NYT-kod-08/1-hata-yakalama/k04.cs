using System;
using System.IO;

public class Sinif1
{
    public static void fonksiyon1(int arg1, int arg2)
    {
        int sonuc;
        try
        {
            sonuc = arg1 / arg2;
        }
        catch
        {
            Console.WriteLine("Sinif1.fonksiyon1 icerisinde beklenmedik bir durum olustu!");
        }
    }
    public static void fonksiyon2()
    {
        string temp;
        try
        {
            StreamReader sr = new StreamReader("C:/olmayan.txt");
            temp = sr.ReadToEnd();
        }
        catch
        {
            Console.WriteLine("Sinif1.fonksiyon2 icerisinde beklenmedik bir durum olustu!");
        }
    }
}

public class Sinif2
{
    static void Main()
    {
        Sinif1.fonksiyon1(5, 6);
        Sinif1.fonksiyon2();
        Console.ReadLine();
    }
}
