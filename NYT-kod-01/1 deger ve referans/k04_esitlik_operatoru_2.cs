using System;
// referanslarin "==" operatoru ile karsilastirilmasi
namespace Uzay1
{
    public class Sinif1
    {
        static void Main()
        {
            // i adinda yeni bir canta olustur, icerisine 5 koy
            int i = 5;

			// isimsiz bir canta olustur, icerisine i cantasindaki degerin
            // aynisindan koy ve bu yeni cantayi bir nesne (object) kutusuna
            // yerlestir, kutunun adresini de x tutacaginda tut
            object x = i;

			// isimsiz bir canta olustur, icerisine i cantasindaki degerin
            // aynisindan koy ve bu yeni cantayi bir nesne kutusuna
            // yerlestir, kutunun adresini de y tutacaginda tut
            object y = i;

            Console.WriteLine("x == y : {0}", x == y);

            System.Console.Read();
        }
    }
}
