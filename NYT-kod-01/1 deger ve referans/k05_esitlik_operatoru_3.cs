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
            // aynisindan koy ve bu yeni cantayi bir nesne kutusuna
            // yerlestir, kutunun adresini de x tutacaginda tut
            object x = i;

            // y isminde bir tutacak olustur ve bu tutacaga x
            // tutacagindaki adresin aynini yaz
            object y = x;

            Console.WriteLine("x == y : {0}", x == y);
			
            // Console.WriteLine("i == y : {0}", i == y); // hatali :
			// int ile object karsilastirilamaz

            System.Console.Read();
        }
    }
}
