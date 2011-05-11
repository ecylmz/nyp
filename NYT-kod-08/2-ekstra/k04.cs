using System;
using System.IO;
using System.Diagnostics;

public class Sinif1
{
    static bool IslemOldur(string islemAdi)
    {
        foreach (Process proc in Process.GetProcesses())
        {
            if (proc.ProcessName.StartsWith(islemAdi))
            {
                proc.Kill();
                return true;
            }
        }
        return false;
        // Kaynak : http://www.dreamincode.net/code/snippet1543.htm
    }

    static void Main()
    {
        Console.WriteLine("[notepad++.exe] uygulamasi baslatiliyor...");
        System.Diagnostics.Process.Start("C:/Program Files/Notepad++/notepad++.exe");
        Console.WriteLine("[notepad++.exe] uygulamasi 10 saniye calisacak...");
        System.Threading.Thread.Sleep(10000);
        Console.WriteLine("[notepad++.exe] uygulamasi 10 saniye calisti, sonlandirilacak...");
        bool sonuc = IslemOldur("notepad++"); // ".exe" uzantisini yazmiyoruz

        if (sonuc)
            Console.WriteLine("[notepad++.exe] uygulamasi sonlandirildi!");
        else
            Console.WriteLine("[notepad++.exe] uygulamasi sonlandirilamadi!");

        Console.ReadLine();
    }
}
