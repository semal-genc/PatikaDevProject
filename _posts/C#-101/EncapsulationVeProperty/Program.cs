internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("************ Öğrenci 1 ************");
        Ogrenci ogrenci1 = new Ogrenci("Semiha", "Kara", 286, 3);
        ogrenci1.SinifDusur();
        ogrenci1.OgrenciBilgileri();

        Console.WriteLine("************ Öğrenci 2 ************");
        Ogrenci ogrenci2 = new Ogrenci("Selçuk", "Arslan", 216, 1);
        ogrenci2.SinifAtla();
        ogrenci2.OgrenciBilgileri();

        Console.WriteLine("************ Öğrenci 3 ************");
        Ogrenci ogrenci3 = new Ogrenci("Songül", "Yılmaz", 256, 1);
        ogrenci3.SinifDusur();
        ogrenci3.OgrenciBilgileri();
    }
}

class Ogrenci
{
    private string? ad;
    private string? soyad;
    private int no;
    private int sinif;

    public Ogrenci(string? Ad, string? Soyad, int No, int Sinif)
    {
        ad = Ad;
        soyad = Soyad;
        no = No;
        sinif = Sinif;
    }

    public string? Ad { get => ad; set => ad = value; }
    public string? Soyad { get => soyad; set => soyad = value; }
    public int No { get => no; set => no = value; }
    public int Sinif
    {
        get => sinif;
        set
        {
            if (value < 1)
                Console.WriteLine("Sınıf 1'den küçük olamaz!");
            else
                sinif = value;
        }
    }

    public void SinifAtla()
    {
        this.Sinif += 1;
    }
    public void SinifDusur()
    {
        this.Sinif -= 1;
    }

    public void OgrenciBilgileri()
    {
        Console.WriteLine($"Öğrenci Ad      :{this.Ad}");
        Console.WriteLine($"Öğrenci Soyad   :{this.Soyad}");
        Console.WriteLine($"Öğrenci No      :{this.No}");
        Console.WriteLine($"Öğrenci Sınıf   :{this.Sinif}");
    }
}