internal class Program
{
    private static void Main(string[] args)
    {
        Kisi kisi1 = new Kisi("Ahmet", 25, "İstanbul", "Öğretmen");
        kisi1.BilgiYazdir();
        kisi1.DogumGunuKutla();

        Console.WriteLine("--------------------");

        Calisan calisan1 = new Calisan("Elif", 30, "Ankara", "Mühendis");
        calisan1.BilgiYazdir();
        calisan1.MeslekYazdir();

        // Dışarıdan erişim örnekleri
        Console.WriteLine($"Ad: {kisi1.Ad}");        // public = erişilebilir
        Console.WriteLine($"Sehir: {kisi1.Sehir}");  // internal = erişilebilir (aynı proje)
        // Console.WriteLine(kisi1.Yas);            // private = erişilemez (hata verir)
        // Console.WriteLine(kisi1.Meslek);         // protected = erişilemez (hata verir)

    }
}

class Kisi
{
    // ---------- FIELD (Özellikler) ----------
    public string Ad;
    internal string Sehir;
    private int Yas;
    protected string Meslek;

    // ---------- CONSTRUCTOR ----------
    public Kisi(string ad, int yas, string sehir, string meslek)
    {
        Ad = ad;
        Yas = yas;
        Sehir = sehir;
        Meslek = meslek;
    }

    // ---------- METOTLAR ----------

    // Public metot = dışarıdan erişilebilir
    public void BilgiYazdir()
    {
        Console.WriteLine($"Ad: {Ad}, Sehir: {Sehir}");
        Console.WriteLine($"(Yas bilgisi private olduğu için sadece bu sınıf içinden yazdırılabilir: {Yas})");
        Console.WriteLine($"(Meslek protected olduğu için sadece bu sınıf ve türevlerinden erişilebilir: {Meslek})");
    }

    // Private metot = sadece bu sınıfta çalışır
    private void YasArttir()
    {
        Yas++;
    }

    // Public metot = dışarıdan çağırıldığında private metodu kullanır
    public void DogumGunuKutla()
    {
        YasArttir();
        Console.WriteLine($"{Ad} bir yaş daha büyüdü! Yeni yaş: {Yas}");
    }
}

class Calisan : Kisi
{
    public Calisan(string ad, int yas, string sehir, string meslek)
    : base(ad, yas, sehir, meslek) { }

    public void MeslekYazdir()
    {
        // Burada Meslek alanına erişebiliriz (protected olduğu için)
        Console.WriteLine($"Çalışanın mesleği: {Meslek}");
    }
}