using System;
using System.Collections.Generic;

public class Sinif1
{
    static void Main()
    {
        Stack<string> StrStk = new Stack<string>();
        Queue<string> StrQ = new Queue<string>();

        string alinan;

        Console.WriteLine("Kuyruga karakter dizisi eklemek icin diziyi yazip [ENTER] a basiniz.");
        Console.WriteLine("Her karakter dizisi ekleme islemi icin bunu bir kez tekrar ediniz.");
        Console.WriteLine("Islem bittiginde 2 kez [ENTER] tusuna basiniz.\n");

        alinan = Console.ReadLine();

        while (alinan != "")
        {
            StrQ.Enqueue(alinan);
            alinan = Console.ReadLine();
        }

        Console.Clear();
        Console.WriteLine("Kuyrugu goruntulemek icin [ENTER] a basiniz:");
        Console.ReadLine();

        string temp;
        int elemanSayisi = StrQ.Count;

        Console.WriteLine("  KUYRUK\n---------------");
        for (int i = 0; i < elemanSayisi; i++)
        {
            temp = StrQ.Dequeue();
            StrStk.Push(temp);
            Console.WriteLine("{0}", temp);
        }

        Console.WriteLine("\nDevam etmek icin icin [ENTER] a basiniz:");
        Console.ReadLine();

        Console.Clear();
        Console.WriteLine("Kuyruk yigita aktarildi. Yigiti gormek icin [ENTER] a basiniz:");
        Console.ReadLine();

        elemanSayisi = StrStk.Count;

        Console.WriteLine("  YIGIT\n---------------");
        for (int i = 0; i < elemanSayisi; i++)
        {
            temp = StrStk.Pop();
            StrQ.Enqueue(temp);
            Console.WriteLine("{0}", temp);
        }

        Console.WriteLine("\nDevam etmek icin [ENTER] a basiniz:");
        Console.ReadLine();

        Console.Clear();
        Console.WriteLine("Yigit tekrar kuyruga aktarildi.\nKuyrugun son halini gormek icin [ENTER] a basiniz:");
        Console.ReadLine();

        Console.WriteLine("  KUYRUK\n---------------");

        for (int i = 0; i < elemanSayisi; i++)
        {
            Console.WriteLine("{0}", StrQ.Dequeue());
        }

        Console.WriteLine("\nCikmak icin [ENTER] a basiniz:");
        Console.ReadLine();

    }
}
