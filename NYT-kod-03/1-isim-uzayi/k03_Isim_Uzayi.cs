using System;

namespace Tasitlar
{
    class Deniz
    {
        public static void Yazdir()
        {
            Console.WriteLine("Tasitlar > Deniz > Yazdir");
        }
    }
}

namespace Seyahat
{
    class Deniz
    {
        public static void Yazdir()
        {
            Console.WriteLine("Seyahat > Deniz > Yazdir");
        }
    }
}

namespace Genel
{
    class Sinif1
    {
        static void Main()
        {
            Tasitlar.Deniz.Yazdir();
            Seyahat.Deniz.Yazdir();
            Console.WriteLine("Genel > Sinif1 > Main");
            Console.ReadLine();
        }
    }
}
