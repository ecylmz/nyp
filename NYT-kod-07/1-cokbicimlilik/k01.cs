using System;

class Matematik
{
    protected int x;
    protected int y;

    public Matematik(int a, int b)
    {
        x = a;
        y = b;
    }
    public virtual void Hesapla()
    { // virtual: miras alan siniflar bu metodu gecersiz kilabilsin
        Console.WriteLine("Temel Sinif Hesapla Metodu");
    }
}

class Toplama:Matematik
{
    public Toplama(int a, int b):base(a,b)
    {
        // Toplama sinifinin iki arguman ("a" ve "b") alan yapici metodu.
        // temel sinifin 2 arguman alan yapici metodunun aynisini
        // gercekle; ilk argumanina "a" yi ver, ikincisine "b" yi ver.
        // SONUC: x=a, y=b
    }
    public override void Hesapla()
    { // mirasla alinan "Hesapla" metodu gecersiz kilinsin
        Console.WriteLine("Toplama : {0}", x+y);
    }
}

class Cikarma:Matematik
{
    public Cikarma(int a, int b):base(a,b)
    {
    }
    public override void Hesapla()
    { // mirasla alinan "Hesapla" metodu gecersiz kilinsin
        Console.WriteLine("Cikarma : {0}", x-y);
    }
}

class Uygulama
{
    static void IslemYap(Matematik m)
    {
        // m: temel siniftan miras alan herhangi bir sinifin referansini
        // temsil eder. Cokbicimlilik sayesinde bu fonksiyona arguman olarak
        // gerek "Toplama" tipinden, gerekse "Cikarma" tipinden referanslar verilebilir.
        m.Hesapla();
    }
    static void Main(string[] args)
    {
        Toplama t = new Toplama(10, 2);
        Cikarma c = new Cikarma(10, 2);

        IslemYap(t);
        IslemYap(c);
        Console.ReadLine();
    }
}
