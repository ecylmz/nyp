using System;

namespace Uzay1
{
    public class Sinif1
    {
        static void Main()
        {
            // icine 3 tane dolap koymak amaciyla bir oda kirala
            int[][] x1 = new int[3][];

            // 2 cekmecesi olan bir dolap al ve odaya koy (0 no lu dolap)
            x1[0] = new int[] { 1, 2};

            // 4 cekmecesi olan baska bir dolap al ve onu da odaya koy (1 no lu dolap)
            x1[1] = new int[] { 3, 4, 5, 6};

            // 6 cekmecesi olan baska bir dolap daha al ve onu da odaya koy (2 no lu dolap)
            x1[2] = new int[] { 7, 8, 9, 10, 11, 12};

            // 0 no lu dolabin 3 no lu cekmecesine bakmayi dene 
            //Console.WriteLine("0 no lu dolabin 3 no lu cekmecesi : {0}", x1[0][3]);
            // hatali : bu dolapta sadece 0 ve 1 no lu cekmeceler var
            
            // ustteki ifade, calisma ani hatasi verecektir. bu hata, derleme aninda engellenemez
            // cunku indeks degeri 3 yerine kullanicidan program calisirken istenen bir tamsayi da
            // olabilirdi. kullanici etkilesimine musade etmek adina derleme aninda bu kontrol yapilmaz.

            // 1 no lu dolabin 3 no lu cekmecesinde 6 degeri var
            Console.WriteLine("1 no lu dolabin 3 no lu cekmecesi : {0}", x1[1][3]);

            // 2 no lu dolabin 3 no lu cekmecesinde 10 degeri var
            Console.WriteLine("1 no lu dolabin 3 no lu cekmecesi : {0}", x1[2][3]);

            System.Console.Read();
        }
    }
}
