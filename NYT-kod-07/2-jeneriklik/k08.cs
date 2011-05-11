using System;
using System.Collections.Generic;

public class Jenerik<T>
{
    T a;

    public Jenerik(T arg)
    {
        a = arg;
    }

    public int Mutlak()
    {
        if (typeof(T) == typeof(string))
        {
            return (a.ToString().Length);
            // "a.Length" yazilamaz cunku a' nin string tipinden olacagi kesin degil.
        }
        else if (typeof(T) == typeof(int))
        {
            if (System.Convert.ToInt32(a.ToString()) < 0)
                return (-1 * System.Convert.ToInt32(a.ToString()));
            else
                return System.Convert.ToInt32(a.ToString());
        }
        else
        {
            Console.WriteLine("Bu jenerik sinif, {0} tipini desteklemiyor.", typeof(T).ToString());
            return -1;
        }
    }
}

public class Sinif2
{
    static void Main()
    {
        Console.WriteLine("nesne1 yaratiliyor...");
        Jenerik<int> nesne1 = new Jenerik<int>(8);
        Console.WriteLine("sonuc : {0}\n\n", nesne1.Mutlak());

        Console.WriteLine("nesne2 yaratiliyor...");
        Jenerik<string> nesne2 = new Jenerik<string>("sekiz");
        Console.WriteLine("sonuc : {0}\n\n", nesne2.Mutlak());

        Console.WriteLine("nesne3 yaratiliyor...");
        Jenerik<double> nesne3 = new Jenerik<double>(8.0);
        Console.WriteLine("sonuc : {0}\n\n", nesne3.Mutlak());

        Console.WriteLine("nesne4 yaratiliyor...");
        Jenerik<char> nesne4 = new Jenerik<char>('s');
        Console.WriteLine("sonuc : {0}\n\n", nesne4.Mutlak());

        Console.ReadLine();

    }
}
