using System;

public enum Ses : byte
{
    turuncu, // 0
    mor, // 1
    pembe, // 2
    bej = 98, // 98
    bordo // 99
}

class Sinif1
{
    static void Main()
    {
        foreach (byte deger in Enum.GetValues(typeof(Ses)))
        {
            Console.WriteLine("Sabit Degeri : {0}\tSabit Adi : {1}", deger, Enum.GetName(typeof(Ses), deger));
        }
        Console.ReadLine();
    }
}
