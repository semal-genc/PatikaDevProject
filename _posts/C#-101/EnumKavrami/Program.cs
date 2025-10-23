internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Bugün Günlerden Ne: ");
        string bugun = Console.ReadLine() ?? "";

        if (Enum.TryParse<Gunler>(bugun, true, out Gunler gun))
        {
            string mesaj = gun switch
            {
                Gunler.Pazartesi => "Kampanyalardan yararlanabilirsiniz",
                Gunler.Salı => "Yeni ürünleri inceleyebilirsiniz",
                Gunler.Çarşamba => "İndirimli ürünlerimiz mevcut",
                Gunler.Perşembe => "Tebrikler! Hediye kart kazandınız",
                Gunler.Cuma => "Stoklarımız tükendi",
                Gunler.Cumartesi => "Kapalıyız...",
                Gunler.Pazar => "Kapalıyız...",

                _ => "Bugün herhangi bir kampanya yok"
            };
            Console.WriteLine(mesaj);
        }

        Console.Write("Hava Kaç Derece: ");
        int derece = int.Parse(Console.ReadLine() ?? "");

        if (derece >= (int)HavaDurumu.Soguk && derece < (int)HavaDurumu.Normal)
            Console.WriteLine("Hava soğuk");
        else if (derece >= (int)HavaDurumu.Normal && derece < (int)HavaDurumu.Sicak)
            Console.WriteLine("Hava Normal");
        else if (derece >= (int)HavaDurumu.Sicak && derece < (int)HavaDurumu.CokSicak)
            Console.WriteLine("Hava Sıcak");
        else if (derece >= (int)HavaDurumu.CokSicak)
            Console.WriteLine("Hava Çok Sıcak");
        else if (derece < (int)HavaDurumu.Soguk)
            Console.WriteLine("Hava Çok Soğuk");
    }
}

enum Gunler
{
    Pazartesi = 1,
    Salı,
    Çarşamba,
    Perşembe,
    Cuma,
    Cumartesi,
    Pazar
}

enum HavaDurumu
{
    Soguk = 5,
    Normal = 20,
    Sicak = 30,
    CokSicak = 40
}