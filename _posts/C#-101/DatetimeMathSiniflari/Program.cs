internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("=== DateTime Sınıfı Örnekleri ===");

        DateTime now = DateTime.Now;
        Console.WriteLine("Şu an (24 saat formatı): " + now);

        Console.WriteLine("Bugün: " + DateTime.Today);
        Console.WriteLine("UTC Zamanı: " + DateTime.UtcNow);

        Console.WriteLine("Kısa Tarih: " + now.ToShortDateString());
        Console.WriteLine("Uzun Tarih: " + now.ToLongDateString());
        Console.WriteLine("Kısa Saat: " + now.ToShortTimeString());
        Console.WriteLine("Uzun Saat: " + now.ToLongTimeString());

        Console.WriteLine("Yıl: " + now.Year);
        Console.WriteLine("Ay: " + now.Month);
        Console.WriteLine("Gün: " + now.Day);
        Console.WriteLine("Haftanın Günü: " + now.DayOfWeek);
        Console.WriteLine("Yılın Kaçıncı Günü: " + now.DayOfYear);

        Console.WriteLine("5 gün sonrası: " + now.AddDays(5));
        Console.WriteLine("2 ay öncesi: " + now.AddMonths(-2));
        Console.WriteLine("3 saat sonrası: " + now.AddHours(3));
        Console.WriteLine("1 yıl sonrası: " + now.AddYears(1));

        Console.WriteLine("Tarih Karşılaştırma: " + DateTime.Compare(DateTime.Now, DateTime.UtcNow));

        // --- AM/PM formatı ---
        Console.WriteLine("\n=== AM/PM Gösterimi ===");
        Console.WriteLine("12 saat formatı (AM/PM): " + now.ToString("hh:mm:ss tt"));
        Console.WriteLine("Sadece AM/PM: " + now.ToString("tt"));

        Console.WriteLine("\n=== Math Sınıfı Örnekleri ===");

        Console.WriteLine("Mutlak Değer (Abs): " + Math.Abs(-42));
        Console.WriteLine("Üs Alma (Pow): " + Math.Pow(3, 5));
        Console.WriteLine("Karekök (Sqrt): " + Math.Sqrt(16));
        Console.WriteLine("Üçüncü Kök (Cbrt benzeri): " + Math.Pow(27, 1.0 / 3.0));

        Console.WriteLine("Yuvarlama (Ceiling): " + Math.Ceiling(4.3));
        Console.WriteLine("Yuvarlama (Floor): " + Math.Floor(4.9));
        Console.WriteLine("Yuvarlama (Round): " + Math.Round(4.5));
        Console.WriteLine("Min: " + Math.Min(10, 20));
        Console.WriteLine("Max: " + Math.Max(10, 20));

        Console.WriteLine("E Sayısı (Math.E): " + Math.E);
        Console.WriteLine("Pi Sayısı (Math.PI): " + Math.PI);

        Console.WriteLine("Sin(30°): " + Math.Sin(Math.PI / 6));
        Console.WriteLine("Cos(60°): " + Math.Cos(Math.PI / 3));
        Console.WriteLine("Tan(45°): " + Math.Tan(Math.PI / 4));
        Console.WriteLine("ArcTan(1): " + Math.Atan(1));
        Console.WriteLine("Logaritma (e tabanlı): " + Math.Log(10));
        Console.WriteLine("Logaritma (10 tabanlı): " + Math.Log10(1000));
        Console.WriteLine("Üs Alma (Exp): " + Math.Exp(1));
    }
}