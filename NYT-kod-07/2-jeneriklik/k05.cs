using System;
using System.Collections.Generic;

public class Sinif1
{
    static void Main()
    {
        List<double> lst = new List<double>();

        for (int i = 0; i < 10; i++)
            lst.Add(0.111 * i);
        Console.WriteLine("1. durumda lst[4] : {0}", lst[4]);

        lst.RemoveAt(4);
        Console.WriteLine("2. durumda lst[4] : {0}", lst[4]);
        
        lst.Insert(1, 0.678);
        Console.WriteLine("3. durumda lst[4] : {0}", lst[4]);

        lst.Sort();
        Console.WriteLine("4. durumda lst[4] : {0}", lst[4]);

        lst.Reverse();
        Console.WriteLine("5. durumda lst[4] : {0}", lst[4]);

        Console.ReadLine();

    }
}