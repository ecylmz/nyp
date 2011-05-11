using System;
using System.Collections.Generic;

public class Sinif1
{
    static void Main()
    {
        Dictionary<string, string> TurIng = new Dictionary<string, string>();

        TurIng["kedi"] = "cat";
        TurIng["tavuk"] = "chicken";
        TurIng["ari"] = "bee";
        TurIng["kaplumbaga"] = "turtle";
        TurIng["tilki"] = "fox";
        TurIng["tavuk"] = "hen";

        Console.WriteLine("[TR] tilki\t: [EN] {0}", TurIng["tilki"]);
        Console.WriteLine("[TR] tavuk\t: [EN] {0}", TurIng["tavuk"]);
        Console.WriteLine();


        Dictionary<string, int> MetinSayi = new Dictionary<string, int>();

        MetinSayi["sifir"] = 0;
        MetinSayi["bir"] = 1;
        MetinSayi["iki"] = 2;
        MetinSayi["uc"] = MetinSayi["iki"] + MetinSayi["bir"];

        Console.WriteLine("uc\t:\t{0}", MetinSayi["uc"]);
        Console.WriteLine();


        Dictionary<int, string> SayiMetin = new Dictionary<int, string>();

        SayiMetin[3] = "uc";
        SayiMetin[7] = "yedi";
        SayiMetin[9] = "dokuz";
        SayiMetin[-9] = "eksi_" + SayiMetin[9];
        // dizilerde "negatif indeks" olamaz ancak sozluklerde durum farklidir

        Console.WriteLine("-9\t:\t{0}", SayiMetin[-9]);
        Console.WriteLine();

        Dictionary<short, bool> AsalMi = new Dictionary<short, bool>();

        AsalMi[0] = false;
        AsalMi[2] = true;
        AsalMi[7] = true;
        AsalMi[21] = false;
        AsalMi[83] = true;

        Console.WriteLine("2  --> {0}", AsalMi[2]);
        Console.WriteLine("21 --> {0}", AsalMi[21]);

        Console.ReadLine();

    }
}