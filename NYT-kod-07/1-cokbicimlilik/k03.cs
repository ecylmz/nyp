using System;

class TestSinifi
{
    public class Boyutlar
    {
        public const double PI = Math.PI; // sabit
        protected double x, y;

        public Boyutlar()
        { // x ve y' ye varsayilan tamsayi degerleri (0) atanacak
        }
        public Boyutlar(double x, double y)
        { // this.x --> sinifin uyesi olan "x"; x --> arguman olan "x"
            this.x = x;
            this.y = y;
        }
        public virtual double Alan()
        { // sadece dikdortgen icin gecerli bir alan fonksiyonu
            return x * y;
        }
    }

    public class Daire : Boyutlar
    {
        // x ve y mirasla geldi
        public Daire(double r) : base(r, 0)
        {
            // Daire sinifinin tek arguman ("r") alan yapici metodu.
            // temel sinifin 2 arguman alan yapici metodunun aynisini
            // gercekle; ilk argumanina "r" yi ver, ikincisine "0" ver.
            // SONUC: x=r, y=0
        }
        public override double Alan()
        { // Daire sinifi icin ozellesmis bir Alan fonksiyonu
            return PI * x * x;
        }
    }

    class Kure : Boyutlar
    {
        public Kure(double r) : base(r, 0)
        {
        }
        public override double Alan()
        {
            return 4 * PI * x * x;
        }
    }

    class Silindir : Boyutlar
    {
        public Silindir(double r, double h) : base(r, h)
        {
        }
        public override double Alan()
        {
            return 2 * PI * x * x + 2 * PI * x * y;
        }
    }

    static void Main()
    {
        double r = 3.0, h = 5.0;
        Boyutlar d = new Daire(r);
        Boyutlar k = new Kure(r);
        Boyutlar s = new Silindir(r, h);

        Console.WriteLine("Daire alani    = {0:F2}\tbirimkare", d.Alan());
        Console.WriteLine("Kure alani     = {0:F2}\tbirimkare", k.Alan());
        Console.WriteLine("Silindir alani = {0:F2}\tbirimkare", s.Alan());
        Console.ReadLine();
    }
}

// kaynak: http://msdn.microsoft.com/en-us/library/9fkccyh4(v=vs.80).aspx