internal class Program
{
    private static void Main(string[] args)
    {
        RehberManager rehberManager = new();

        Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz :");
        Console.WriteLine("******************************************* (1) Yeni Numara Kaydetmek (2) Varolan Numarayı Silmek (3) Varolan Numarayı Güncelleme (4) Rehberi Listelemek (5) Rehberde Arama Yapmak");
        string islem = Console.ReadLine() ?? "";

        switch (islem)
        {
            case "1":
                rehberManager.YeniNumaraEkle();
                break;
            case "2":
                rehberManager.NumaraSil();
                break;
            case "3":
                rehberManager.NumaraGuncelle();
                break;
            case "4":
                rehberManager.RehberiListele();
                break;
            case "5":
                rehberManager.RehberiAra();
                break;
            default:
                Console.WriteLine("Hatalı işlem!");
                break;
        }
    }
}

class Rehber
{
    private string isim;
    private string soyisim;
    private long no;

    public string Isim { get => isim; set => isim = value; }

    public string Soyisim { get => soyisim; set => soyisim = value; }
    public long No { get => no; set => no = value; }

    public Rehber(string isim, string soyisim, long no)
    {
        this.isim = isim;
        this.soyisim = soyisim;
        this.no = no;
    }
}

class RehberManager
{
    List<Rehber> rehberListesi = new()
    {
        new Rehber("Abidin", "Sönmez", 05554355525),
        new Rehber("Saliha", "Yılmaz", 04444355525),
        new Rehber("Canan", "Kamış", 03334355525),
        new Rehber("Aliye", "Kamış", 02224355525),
        new Rehber("Abidin", "Kurucu", 02224355525)
    };

    public void YeniNumaraEkle()
    {
        Console.Write("Lütfen isim giriniz             :");
        string yeniIsim = Console.ReadLine() ?? "";
        Console.Write("Lütfen soyisim giriniz          :");
        string yeniSoyisim = Console.ReadLine() ?? "";
        Console.Write("Lütfen telefon numarası giriniz :");
        long yeniNo = long.Parse(Console.ReadLine() ?? "");

        var yeniKisi = new Rehber(yeniIsim, yeniSoyisim, yeniNo);
        rehberListesi.Add(yeniKisi);
        Console.WriteLine("Yeni kişi eklendi.");
    }

    public void NumaraSil()
    {
        while (true)
        {
            Console.WriteLine("Lütfen numarasını silmek istediğiniz kişinin adını ya da soyadını giriniz:");
            string silinecekKisi = Console.ReadLine() ?? "";
            var kisi = rehberListesi.FirstOrDefault(r => r.Isim.Equals(silinecekKisi, StringComparison.OrdinalIgnoreCase) || r.Soyisim.Equals(silinecekKisi,StringComparison.OrdinalIgnoreCase));
            if (kisi != null)
            {
                Console.WriteLine($"{kisi.Isim} {kisi.Soyisim} kişi rehberden silinmek üzere, onaylıyor musunuz ?(y/n)");
                string kisiInput = Console.ReadLine() ?? "";

                if (kisiInput.Equals("y", StringComparison.OrdinalIgnoreCase))
                {
                    rehberListesi.Remove(kisi);
                    Console.WriteLine("Kişi silindi.");
                    break;
                }
                else
                {
                    Console.WriteLine("Silme işlemi iptal edildi.");
                    break;
                }
            }
            else
            {
                Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
                Console.WriteLine("* Silmeyi sonlandırmak için : (1)");
                Console.WriteLine("* Yeniden denemek için      : (2)");
                string islemInput = Console.ReadLine() ?? "";
                if (islemInput.Equals("1"))
                    break;
                else if (islemInput.Equals("2"))
                    continue;

            } 
        }
    }

    public void NumaraGuncelle()
    {
        while (true)
        {
            Console.WriteLine("Lütfen numarasını güncellemek istediğiniz kişinin adını ya da soyadını giriniz:");
            string silinecekKisi = Console.ReadLine() ?? "";
            var kisi = rehberListesi.FirstOrDefault(r => r.Isim.Equals(silinecekKisi, StringComparison.OrdinalIgnoreCase) || r.Soyisim.Equals(silinecekKisi,StringComparison.OrdinalIgnoreCase));
            if (kisi != null)
            {
                Console.WriteLine($"{kisi.Isim} {kisi.Soyisim} kişinin numarası güncellenmek üzere, onaylıyor musunuz ?(y/n)");
                string kisiInput = Console.ReadLine() ?? "";

                if (kisiInput.Equals("y", StringComparison.OrdinalIgnoreCase))
                {
                    Console.Write("Yeni telefon numarasını giriniz: ");
                    long yeniNo = long.Parse(Console.ReadLine() ?? "");
                    kisi.No = yeniNo;
                    Console.WriteLine("Numara güncellendi.");
                    break;
                }
                else
                {
                    Console.WriteLine("Güncelleme işlemi iptal edildi.");
                    break;
                }
            }
            else
            {
                Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
                Console.WriteLine("* Güncellemeyi sonlandırmak için : (1)");
                Console.WriteLine("* Yeniden denemek için           : (2)");
                string islemInput = Console.ReadLine() ?? "";
                if (islemInput.Equals("1"))
                    break;
                else if (islemInput.Equals("2"))
                    continue;

            } 
        }
    }

    public void RehberiListele()
    {
        Console.WriteLine("Telefon Rehberi");
        Console.WriteLine(string.Join("\n", rehberListesi.Select(r => $"isim: {r.Isim} Soyisim: {r.Soyisim} Telefon Numarası: {r.No} -")));
    }

    public void RehberiAra()
    {
        Console.WriteLine("Arama yapmak istediğiniz tipi seçiniz.");
        Console.WriteLine("* İsim veya soyisime göre arama yapmak için: (1)");
        Console.WriteLine("* Telefon numarasına göre arama yapmak için: (2)");

        string islemInput = Console.ReadLine() ?? "";

        if (islemInput.Equals("1"))
        {
            string arananKisi = Console.ReadLine() ?? "";
            var eslesenKisiler = rehberListesi.Where(r => r.Isim.Equals(arananKisi, StringComparison.OrdinalIgnoreCase) || r.Soyisim.Equals(arananKisi, StringComparison.OrdinalIgnoreCase)).ToList();
            foreach (var kisi in eslesenKisiler)
            {
                Console.WriteLine($"isim: {kisi.Isim}, Soyisim: {kisi.Soyisim}, No: {kisi.No}");
            }
        }
        else if (islemInput.Equals("2"))
        {
            long arananNo = long.Parse(Console.ReadLine() ?? "");
            var eslesenNo = rehberListesi.Where(r => r.No.Equals(arananNo)).ToList();
            foreach (var kisi in eslesenNo)
            {
                Console.WriteLine($"isim: {kisi.Isim}, Soyisim: {kisi.Soyisim}, No: {kisi.No}");
            }
        }
    }
}