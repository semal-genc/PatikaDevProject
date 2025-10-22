internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("***********Öğrenci 1***********");
        Ogrenci ogrenci1 = new Ogrenci("sahih", "özden", 214);
        ogrenci1.OgrenciBilgileri();

        Console.WriteLine("***********Öğrenci 2***********");
        Ogrenci ogrenci2 = new Ogrenci();
        ogrenci2.ad = "saliha";
        ogrenci2.soyad = "gökçen";
        ogrenci2.ogrNo = 664;
        ogrenci2.OgrenciBilgileri();

        Console.WriteLine("***********Öğrenci 3***********");
        Ogrenci ogrenci3 = new Ogrenci("rüştü", "sönmez");
        ogrenci3.OgrenciBilgileri();
    }
}

class Ogrenci
{
    public string? ad; //başlangıçta null olabilir anlamını taşır.
    public string? soyad; //başlangıçta null olabilir anlamını taşır.
    public int ogrNo;

    public Ogrenci(string ad, string soyad, int ogrNo)
    {
        this.ad = ad;
        this.soyad = soyad;
        this.ogrNo = ogrNo;
    }

    public Ogrenci() { }


    public Ogrenci(string ad, string soyad)
    {
        this.ad = ad;
        this.soyad = soyad;
    }

    public void OgrenciBilgileri()
    {
        Console.WriteLine($"Öğrenci Adı: {ad}");
        Console.WriteLine($"Öğrenci Soyadı: {soyad}");
        Console.WriteLine($"Öğrenci Numarası: {ogrNo}");
    }
}