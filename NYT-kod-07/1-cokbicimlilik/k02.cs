using System;

abstract class AntiVirus
{
    public virtual void Baslat()
    {
        // gerceklestirimi miras alan siniflar yapsin
    }
    public virtual void TaramayaDevam()
    { // tum miras alan siniflarda ayni
        Console.WriteLine("Tarama devam ediyor...");
    }
    public virtual void Bitti()
    { // tum miras alan siniflarda ayni
        Console.WriteLine("Tarama bitti..");
    }
    public virtual void Sonuc()
    {
        // gerceklestirimi miras alan siniflar yapsin
    }
}
class AntiVirus1 : AntiVirus
{
    public override void Baslat()
    { // temel siniftaki "Baslat" fonksiyonunu gecersiz kil
        Console.WriteLine("AntiVirus1 taramaya basladi.");
    }
    public override void TaramayaDevam()
    { // temel siniftaki "TaramayaDevam" fonksiyonunu kullan
        base.TaramayaDevam();
    }
    public override void Bitti()
    { // temel siniftaki "Bitti" fonksiyonunu kullan
        base.Bitti();
    }
    public override void Sonuc()
    { // temel siniftaki "Sonuc" fonksiyonunu gecersiz kil
        Console.WriteLine("AntiVirus1 bilgisayarinizda guvenlik tehdidi bulamadi.");
    }
}
class AntiVirus2 : AntiVirus
{
    public override void Baslat()
    { // temel siniftaki "Baslat" fonksiyonunu gecersiz kil
        Console.WriteLine("AntiVirus2 taramaya basladi.");
    }
    public override void TaramayaDevam()
    { // temel siniftaki "TaramayaDevam" fonksiyonunu kullan
        base.TaramayaDevam();
    }
    public override void Bitti()
    { // temel siniftaki "Bitti" fonksiyonunu kullan
        base.Bitti();
    }
    public override void Sonuc()
    { // temel siniftaki "Sonuc" fonksiyonunu gecersiz kil
        Console.WriteLine("AntiVirus2 bilgisayarinizda guvenlik tehdidi bulamadi.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        AntiVirus1 av1 = new AntiVirus1();
        AntiVirus2 av2 = new AntiVirus2();
        // AntiVirus av = new AntiVirus(); // hata: soyut siniflarin nesnesi yaratilamaz

        Uygula(av1);
        Console.WriteLine("************************************");
        Uygula(av2);
        Console.ReadLine();
    }

    public static void Uygula(AntiVirus anti)
    {
        // anti: AntiVirus sinifindan kalitlayan herhangi bir sinifin
        // nesnesini temsil edebilecek genel amacli bir referans tutacagi
        // Bu tutacagin tipi calisma aninda belli olacak
        anti.Baslat();
        anti.TaramayaDevam();
        anti.Bitti();
        anti.Sonuc();
    }
}

// kaynak: http://csharp.webtasarimmerkezi.com/MakaleGoster.aspx?ID=4
