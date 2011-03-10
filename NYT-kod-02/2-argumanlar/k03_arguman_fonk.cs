using System;

namespace Uzay1
{
    public class Sinif1
    {
        public static void Takas_Deger(int s1, int s2)
        { // arguman olarak deger alan fonksiyon
            // hata: takas gerceklesmez
            int temp = s1;
            s1 = s2;
            s2 = temp;
        }
        public static void Takas_Referans(ref int s1, ref int s2)
        { // arguman olarak referans alan fonksiyon
            // takas gerceklesir
            int temp = s1;
            s1 = s2;
            s2 = temp;
        }
    }

    public class Sinif2
    {
        static void Main()
        {
            int a = 3, b = 5;
            Console.WriteLine("En Basta             --> a = {0}, b = {1}\n", a, b);

            Sinif1.Takas_Deger(a, b);
            Console.WriteLine("Takas_Deger(a, b)    --> a = {0}, b = {1}\n", a, b);

            Sinif1.Takas_Referans(ref a, ref b);
            // Sinif1.Takas_Referans(a, b); // hatali
            // Sinif1.Takas_Referans(ref a, ref 25); // hatali
            Console.WriteLine("Takas_Referans(a, b) --> a = {0}, b = {1}\n", a, b);

            System.Console.Read();
        }
    }
}
