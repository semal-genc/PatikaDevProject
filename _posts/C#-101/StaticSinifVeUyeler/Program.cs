internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Çalışan Sayısı: {0}", Calisan.CalisanSayisi);

        Calisan calisan = new Calisan("Haydar", "Dervan", "Depo");
        Calisan calisan1 = new Calisan("Ali", "Sönmez", "IK");
        Calisan calisan2 = new Calisan("Keriman", "Alıç", "Muhasebe");
        calisan.CalisanBilgileri();
        Console.WriteLine("***************************");
        calisan1.CalisanBilgileri();
        Console.WriteLine("***************************");
        calisan2.CalisanBilgileri();
        Console.WriteLine("***************************");
        Console.WriteLine("Çalışan Sayısı: {0}", Calisan.CalisanSayisi);
    }
}

class Calisan
{
    private static int calisanSayisi;
    public static int CalisanSayisi { get => calisanSayisi; }

    private string isim;
    private string soyisim;
    private string departman;

    static Calisan()
    {
        calisanSayisi = 0;
    }

    public Calisan(string isim, string soyisim, string departman)
    {
        this.isim = isim;
        this.soyisim = soyisim;
        this.departman = departman;
        calisanSayisi++;
    }

    public void CalisanBilgileri()
    {
        Console.WriteLine($"İsim        :{isim}");
        Console.WriteLine($"Soysim      :{soyisim}");
        Console.WriteLine($"Departman   :{departman}");
    }
}