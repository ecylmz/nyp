using System;
using System.Collections.Generic;

public class Sinif1
{
    static void Main()
    {
        Stack<int> stk = new Stack<int>();

        for (int i = 0; i < 10; i++ )
            stk.Push(i * i);

        for (int i = 0; i < 5; i++)
            stk.Pop();

        Console.WriteLine("Tepedeki eleman\t:\t{0}", stk.Peek());

        Console.ReadLine();

    }
}