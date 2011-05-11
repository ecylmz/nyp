using System;
using System.Collections.Generic;

public class Sinif1
{
    static void Main()
    {
        // jenerik Queue sinifinin "int" tipinden eleman kabul eden nesnesi
        Queue<int> q_int = new Queue<int>(6);

        for (int i = 0; i < 10; i++)
            q_int.Enqueue(i*i);

        for (int i = 0; i < 6; i++)
            Console.WriteLine("q_int --> {0}. eleman\t: {1}", i+1, q_int.Dequeue());

        Console.WriteLine("********************************");

        string alfabe = "abcdefghijklmnopqrstuvwxyz";

        // jenerik Queue sinifinin "string" tipinden eleman kabul eden nesnesi
        Queue<string> q_str = new Queue<string>(10);

        for (int i = 0; i < 8; i++)
            q_str.Enqueue(alfabe.Substring(i, 4));

        for (int i = 0; i < 8; i++)
            Console.WriteLine("q_str --> {0}. eleman\t: {1}", i + 1, q_str.Dequeue());

        Console.ReadLine();
    }
}