using System;
using System.IO;

public class Sinif1
{
    static void Main()
    {
        for (int i = 80; i > 0; i--)
        {
            Console.Write("*");
            System.Threading.Thread.Sleep(i * 15);
        }
            Console.ReadLine();
    }
}
