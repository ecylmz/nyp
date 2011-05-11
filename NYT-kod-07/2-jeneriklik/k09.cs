using System;

public class Sinif1
{ // jenerik olmayan sinif

    object a;

    public Sinif1()
    {
        a = null;
    }
    public Sinif1(object arg)
    {
        a = arg;
    }

    public object Yaz()
    {
        string tipBilgisi = a.ToString().Substring(0, 5);

        if (tipBilgisi == "[str]")
        {
            Console.WriteLine("Yaratilan nesnenin 'a' alt alanina [string] tipinde veri saklanmis.");
            string deger = a.ToString().Substring(5, a.ToString().Length - 5);
            Console.WriteLine("Deger : {0}\n", deger);
            return (object)deger;
        }
        else if (tipBilgisi == "[int]")
        {
            Console.WriteLine("Yaratilan nesnenin 'a' alt alanina [int] tipinde veri saklanmis.");
            int deger = System.Convert.ToInt32(a.ToString().Substring(5, a.ToString().Length - 5));
            Console.WriteLine("Deger : {0}\n", deger);
            return (object)deger;
        }
        else if (tipBilgisi == "[dbl]")
        {
            Console.WriteLine("Yaratilan nesnenin 'a' alt alanina [double] tipinde veri saklanmis.");
            double deger = System.Convert.ToDouble(a.ToString().Substring(5, a.ToString().Length - 5));
            Console.WriteLine("Deger : {0}\n", deger);
            return (object)deger;
        }
        else
        {
            Console.WriteLine("Yaratilan nesnenin 'a' alt alanina saklanan verinin tipi bilinmiyor.");
            return null;
        }
    }
}

public class Sinif2
{
    static void Main()
    {
        string s1 = "bilgisayar";
        int i1 = 71;
        double d1 = 49.94;

        Console.WriteLine("1. ASAMA:");
        Console.WriteLine("[s1] --> tip : {0}, deger : {1}", typeof(string), s1);
        Console.WriteLine("[i1] --> tip : {0}, deger : {1}", typeof(int), i1);
        Console.WriteLine("[d1] --> tip : {0}, deger : {1}", typeof(double), d1);

        string s1_str = "[str]" + s1;
        string i1_str = "[int]" + i1.ToString();
        string d1_str = "[dbl]" + d1.ToString();

        Console.WriteLine("\n2. ASAMA:");
        Console.WriteLine("[s1_str] --> tip : {0}, deger : {1}", typeof(string), s1_str);
        Console.WriteLine("[i1_str] --> tip : {0}, deger : {1}", typeof(string), i1_str);
        Console.WriteLine("[d1_str] --> tip : {0}, deger : {1}", typeof(string), d1_str);

        object s1_obj = (object)s1_str;
        object i1_obj = (object)i1_str;
        object d1_obj = (object)d1_str;

        Console.WriteLine("\n3. ASAMA:");
        Console.WriteLine("[s1_obj] --> tip : {0}, deger : {1}", typeof(object), s1_obj);
        Console.WriteLine("[i1_obj] --> tip : {0}, deger : {1}", typeof(object), i1_obj);
        Console.WriteLine("[d1_obj] --> tip : {0}, deger : {1}", typeof(object), d1_obj);

        Console.WriteLine("\n4. ASAMA:");

        Sinif1 s1_Sinif1 = new Sinif1(s1_obj);
        Sinif1 i1_Sinif1 = new Sinif1(i1_obj);
        Sinif1 d1_Sinif1 = new Sinif1(d1_obj);

        s1_Sinif1.Yaz();
        i1_Sinif1.Yaz();
        d1_Sinif1.Yaz();

        Console.ReadLine();
    }
}
