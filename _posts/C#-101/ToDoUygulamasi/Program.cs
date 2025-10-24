internal class Program
{
    private static void Main(string[] args)
    {
        ToDoManager toDoManager = new();
        Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz :");
        Console.WriteLine("******************************************* (1) Board Listelemek (2) Board'a Kart Eklemek (3) Board'dan Kart Silmek (4) Kart Taşımak (5) Kart Güncellemek");
        string islem = Console.ReadLine() ?? "";

        switch (islem)
        {
            case "1":
                toDoManager.KartListeleme();
                break;
            case "2":
                toDoManager.KartEkle();
                break;
            case "3":
                toDoManager.KartSil(out Taslak silinenKart, out List<Taslak> kaynakListe);
                break;
            case "4":
                toDoManager.KartTasi();
                break;
            case "5":
                toDoManager.KartGuncelle();
                break;
            default:
                Console.WriteLine("Hatalı İşlem!");
                break;
        }
    }
}

enum Buyukluk
{
    XS = 1,
    S = 2,
    M = 3,
    L = 4,
    XL = 5
}

class Taslak
{
    private string baslik;
    private string icerik;
    private string atananKisi;
    private Buyukluk buyukluk;

    public Taslak(string baslik, string icerik, string atananKisi, Buyukluk buyukluk)
    {
        this.baslik = baslik;
        this.icerik = icerik;
        this.atananKisi = atananKisi;
        this.buyukluk = buyukluk;
    }

    public string Baslik { get => baslik; set => baslik = value; }
    public string Icerik { get => icerik; set => icerik = value; }
    public string AtananKisi { get => atananKisi; set => atananKisi = value; }
    public Buyukluk Buyukluk { get => buyukluk; set => buyukluk = value; }
}

class ToDoManager
{
    private static Dictionary<int, string> takimUyeleri = new Dictionary<int, string>();
    List<Taslak> todo = new List<Taslak>();
    List<Taslak> inProgress = new List<Taslak>();
    List<Taslak> done = new List<Taslak>();

    public ToDoManager()
    {
        takimUyeleri.Add(1, "Sabiha");
        takimUyeleri.Add(2, "Ayşe");
        takimUyeleri.Add(3, "Veli");
        takimUyeleri.Add(4, "Aliye");
        takimUyeleri.Add(5, "Kazım");
        takimUyeleri.Add(6, "Şemsi");
        takimUyeleri.Add(7, "Latif");

        // TODO Kolonu
        todo.Add(new Taslak("Başlık1", "İçerik1", "Sabiha", Buyukluk.M));
        todo.Add(new Taslak("Başlık2", "İçerik2", "Ayşe", Buyukluk.S));
        todo.Add(new Taslak("Başlık3", "İçerik3", "Latif", Buyukluk.XL));

        // IN PROGRESS Kolonu
        inProgress.Add(new Taslak("Başlık4", "İçerik4", "Veli", Buyukluk.L));
        inProgress.Add(new Taslak("Başlık5", "İçerik5", "Ayşe", Buyukluk.XL));
        inProgress.Add(new Taslak("Başlık6", "İçerik6", "Kazım", Buyukluk.S));
        inProgress.Add(new Taslak("Başlık7", "İçerik7", "Veli", Buyukluk.XS));

        // DONE Kolonu
        done.Add(new Taslak("Başlık8", "İçerik8", "Aliye", Buyukluk.XS));
        done.Add(new Taslak("Başlık9", "İçerik9", "Şemsi", Buyukluk.M));
        done.Add(new Taslak("Başlık10", "İçerik10", "Şemsi", Buyukluk.XL));
    }

    public void KartEkle()
    {
        Console.Write("Başlık Giriniz                                  : ");
        string inputBaslik = Console.ReadLine() ?? "";
        Console.Write("İçerik Giriniz                                  : ");
        string inputIcerik = Console.ReadLine() ?? "";
        Console.Write("Büyüklük Seçiniz -> XS(1),S(2),M(3),L(4),XL(5)  : ");
        string inputBuyukluk = Console.ReadLine() ?? "";
        foreach (var kisi in takimUyeleri)
        {
            Console.WriteLine($"{kisi.Key} - {kisi.Value}");
        }
        Console.WriteLine("Kişi Seçiniz (ID): ");
        int kisiId = int.Parse(Console.ReadLine() ?? "");
        string atananKisi;
        if (takimUyeleri.ContainsKey(kisiId))
            atananKisi = takimUyeleri[kisiId];
        else
        {
            Console.WriteLine("Geçersiz ID! Varsayılan kişi atanıyor: Sabiha");
            atananKisi = "Sabiha";
        }

        Buyukluk buyukluk;
        while (!Enum.TryParse(inputBuyukluk, true, out buyukluk))
        {
            Console.WriteLine("Geçersiz büyüklük girdiniz! Tekrar deneyiniz: ");
            inputBuyukluk = Console.ReadLine() ?? "";
        }


        var yeniKart = new Taslak(inputBaslik, inputIcerik, atananKisi, buyukluk);
        todo.Add(yeniKart);
        Console.WriteLine("Kart başarıyla eklendi!");
    }
    public void KartGuncelle()
    {
        var tumKartlar = todo.Concat(inProgress).Concat(done);
        while (true)
        {
            Console.WriteLine("Öncelikle guncellemek istediğiniz kartı seçmeniz gerekiyor.");
            Console.WriteLine("Lütfen kart başlığını yazınız:  ");
            string baslikInput = Console.ReadLine() ?? "";

            var kartGuncelle = tumKartlar.FirstOrDefault(k => k.Baslik.Equals(baslikInput, StringComparison.OrdinalIgnoreCase));

            if (kartGuncelle != null)
            {
                Console.WriteLine($"Kart bulundu: {kartGuncelle.Baslik} - {kartGuncelle.Icerik}");

                Console.Write("Yeni Başlık Giriniz                                  : ");
                string inputBaslik = Console.ReadLine() ?? "";
                Console.Write("Yeni İçerik Giriniz                                  : ");
                string inputIcerik = Console.ReadLine() ?? "";
                Console.Write("Yeni Büyüklük Seçiniz -> XS(1),S(2),M(3),L(4),XL(5)  : ");
                string inputBuyukluk = Console.ReadLine() ?? "";
                foreach (var kisi in takimUyeleri)
                {
                    Console.WriteLine($"{kisi.Key} - {kisi.Value}");
                }
                Console.WriteLine("Kişi Seçiniz (ID): ");
                int kisiId = int.Parse(Console.ReadLine() ?? "");
                string atananKisi;
                if (takimUyeleri.ContainsKey(kisiId))
                    atananKisi = takimUyeleri[kisiId];
                else
                {
                    Console.WriteLine("Geçersiz ID! Varsayılan kişi atanıyor: Sabiha");
                    atananKisi = "Sabiha";
                }

                Buyukluk buyukluk;
                while (!Enum.TryParse(inputBuyukluk, true, out buyukluk))
                {
                    Console.WriteLine("Geçersiz büyüklük girdiniz! Tekrar deneyiniz: ");
                    inputBuyukluk = Console.ReadLine() ?? "";
                }
                kartGuncelle.Baslik = inputBaslik;
                kartGuncelle.Icerik = inputIcerik;
                kartGuncelle.Buyukluk = buyukluk;
                kartGuncelle.AtananKisi = atananKisi;
                Console.WriteLine("Kart başarıyla güncellendi.");
                break;
            }
            else
            {
                Console.WriteLine("Aradığınız krtiterlere uygun kart board'da bulunamadı. Lütfen bir seçim yapınız.");
                Console.WriteLine("* Güncellemeyi sonlandırmak için : (1)");
                Console.WriteLine("* Yeniden denemek için           : (2)");

                string input = Console.ReadLine() ?? "";
                if (input.Equals("1"))
                    break;
                else if (input.Equals("2"))
                    continue;
                else
                {
                    Console.WriteLine("Hatalı giriş yaptınız! programdan çıkılıyor..");
                    break;
                }
            }
        }
    }
    public bool KartSil(out Taslak silinenkart, out List<Taslak> kaynakListe)
    {
        silinenkart = null;
        kaynakListe = null;
        var tumKartlar = todo.Concat(inProgress).Concat(done);
        while (true)
        {
            Console.WriteLine("Öncelikle silmek istediğiniz kartı seçmeniz gerekiyor.");
            Console.WriteLine("Lütfen kart başlığını yazınız:  ");
            string baslikInput = Console.ReadLine() ?? "";

            var kart = tumKartlar.FirstOrDefault(k => k.Baslik.Equals(baslikInput, StringComparison.OrdinalIgnoreCase));

            if (kart != null)
            {
                Console.WriteLine($"Kart bulundu: {kart.Baslik} - {kart.Icerik}");
                if (todo.Contains(kart))
                    kaynakListe = todo;
                else if (inProgress.Contains(kart))
                    kaynakListe = inProgress;
                else if (done.Contains(kart))
                    kaynakListe = done;

                silinenkart = kart;
                kaynakListe?.Remove(kart);
                Console.WriteLine("Kart başarıyla silindi.");
                return true;
            }
            Console.WriteLine("Aradığınız krtiterlere uygun kart board'da bulunamadı. Lütfen bir seçim yapınız.");
            Console.WriteLine("* Silmeyi sonlandırmak için  : (1)");
            Console.WriteLine("* Yeniden denemek için       : (2)");

            string input = Console.ReadLine() ?? "";
            if (input.Equals("1"))
                return false;
        }
    }
    public void KartTasi()
    {
        if (KartSil(out Taslak silinenkart, out List<Taslak> eskiListe))
        {
            string eskiLine = eskiListe == todo ? "TODO" :
            eskiListe == inProgress ? "IN PROGRESS" :
            "DONE";

            Console.WriteLine("Bulunan Kart Bilgileri:");
            Console.WriteLine("**************************************");
            Console.WriteLine($"Başlık      : {silinenkart.Baslik}");
            Console.WriteLine($"İçerik      : {silinenkart.Icerik}");
            Console.WriteLine($"Atanan Kişi : {silinenkart.AtananKisi}");
            Console.WriteLine($"Büyüklük    : {silinenkart.Buyukluk}");
            Console.WriteLine($"Line        : {eskiLine}");
            Console.WriteLine("Lütfen taşımak istediğiniz Line'ı seçiniz: (1) TODO (2) IN PROGRESS (3) DONE");

            string secim = Console.ReadLine() ?? "";
            switch (secim)
            {
                case "1": todo.Add(silinenkart); break;
                case "2": inProgress.Add(silinenkart); break;
                case "3": done.Add(silinenkart); break;
                default:
                    Console.WriteLine("Hatalı seçim, kart eski yerine geri kondu.");
                    eskiListe.Add(silinenkart);
                    return;
            }
            Console.WriteLine("Kart başarıyla taşındı.");
        }
        else
        {
            Console.WriteLine("Kart taşıma işlemi iptal edildi veya kart bulunamadı.");
        }
    }
    public void KartListeleme()
    {
        Listele("TODO", todo);
        Listele("IN PROGRESS", inProgress);
        Listele("DONE", done);
    }

    private void Listele(string baslik, List<Taslak> liste)
    {
        Console.WriteLine($"{baslik} Line \n************************");
        if (liste.Count == 0)
        {
            Console.WriteLine("~ BOŞ ~");
            return;
        }

        foreach (var k in liste)
        {
            Console.WriteLine(
            $"Başlık      :{k.Baslik} \n" +
            $"İçerik      :{k.Icerik} \n" +
            $"Atanan Kişi :{k.AtananKisi} \n" +
            $"Büyüklük    :{k.Buyukluk}" +
            $"\n-");
        }
    }
}