using System;
using System.Collections; // jenerik olmayan Stack sinifi burada
using System.Collections.Generic; // jenerik Stack sinifi burada

public class Sinif1
{
    static void Main()
    {
        // "jenerik olmayan Stack sinifi" tipinden uyeleri tutmak
        // uzere bir jenerik Stack<> sinifi nesnesi yarat
        Stack<Stack> JenStk = new Stack<Stack>();

        Stack IntStk = new Stack();

        for (int i = 0; i < 10; i++ )
            IntStk.Push((object) (i * i));

        string alfabe = "abcdefghijklmnopqrstuvwxyz";
        Stack StrStk = new Stack();

        for (int i = 0; i < 5; i++)
            StrStk.Push((object) alfabe.Substring(i, 3));

        // JenStk yigitinda IntStk ve StrStk referanslari olacak
        JenStk.Push(IntStk);
        JenStk.Push(StrStk);

        Console.WriteLine("{0}", JenStk.Peek().Pop());
        Console.WriteLine("{0}", JenStk.Peek().Pop());
        Console.WriteLine("{0}", JenStk.Peek().Pop());
        Console.WriteLine("{0}", JenStk.Pop().Peek());
        Console.WriteLine();
        Console.WriteLine("{0}", JenStk.Peek().Pop());
        Console.WriteLine("{0}", JenStk.Peek().Pop());
        Console.WriteLine("{0}", JenStk.Peek().Pop());

        Console.ReadLine();

    }
}