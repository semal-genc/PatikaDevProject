internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Bir cümle giriniz:");
        string cumle = Console.ReadLine() ?? "";
        while (true)
        {
            string islemler = """
            --- String İşlemleri Menüsü ---
            1 - Uzunluğu öğren
            2 - Büyük harfe çevir
            3 - Küçük harfe çevir
            4 - Kelime değiştir
            5 - Başındaki ve sonundaki boşlukları temizle
            6 - Kelimelere ayır ve göster
            7 - Belirli bir kelime içeriyor mu?
            8 - İlk ve son harfi göster
            9 - Başlıyor/bitiyor kontrolü
            10 - Belirli kelimenin index'ini bul
            11 - Son index'ini bul
            12 - Belirli index'e ekle
            13 - Belirli index'ten sil
            14 - Boş mu kontrol et
            0 - Çıkış
            """;
            Console.WriteLine(islemler);
            Console.Write("Seçiminiz: ");

            string secim = Console.ReadLine() ?? "";

            switch (secim)
            {
                case "1":
                    Console.WriteLine("Cümlenin uzunluğu: " + cumle.Length);
                    break;
                case "2":
                    Console.WriteLine("Büyük harflerle: " + cumle.ToUpper());
                    break;
                case "3":
                    Console.WriteLine("Küçük harflerle: " + cumle.ToLower());
                    break;
                case "4":
                    Console.Write("Değiştirmek istediğiniz kelimeyi girin: ");
                    string eski = Console.ReadLine() ?? "";
                    Console.Write("Yeni kelime: ");
                    string yeni = Console.ReadLine() ?? "";
                    cumle = cumle.Replace(eski, yeni);
                    Console.WriteLine("Yeni cümle: " + cumle);
                    break;
                case "5":
                    cumle = cumle.Trim();
                    Console.WriteLine("Trimleşmiş cümle: " + cumle + "'");
                    break;
                case "6":
                    string[] kelimeler = cumle.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                    Console.WriteLine("Kelime sayısı: " + kelimeler.Length);
                    Console.WriteLine("Kelimeler: " + string.Join(", ", kelimeler));
                    break;
                case "7":
                    Console.Write("Aramak istediğiniz kelime: ");
                    string aranan = Console.ReadLine() ?? "";
                    Console.WriteLine("İçeriyor mu? " + cumle.Contains(aranan));
                    break;
                case "8":
                    if (cumle.Length > 0)
                        Console.WriteLine($"İlk harf: {cumle[0]}, Son harf: {cumle[cumle.Length - 1]}");
                    else
                        Console.WriteLine("Cümle boş.");
                    break;
                case "9":
                    Console.Write("Başlıyor mu kontrol edilecek kelime: ");
                    string bas = Console.ReadLine() ?? "";
                    Console.Write("Bitiyor mu kontrol edilecek kelime: ");
                    string son = Console.ReadLine() ?? "";
                    Console.WriteLine("Başlıyor mu?" + cumle.StartsWith(bas));
                    Console.WriteLine("Bitiyor mu? " + cumle.EndsWith(son));
                    break;
                case "10":
                    Console.Write("Index'ini bulmak istediğiniz kelime: ");
                    string kelimeIndex = Console.ReadLine() ?? "";
                    Console.WriteLine("Index: " + cumle.IndexOf(kelimeIndex));
                    break;
                case "11":
                    Console.Write("Son index'ini bulmak istediğiniz kelime: ");
                    string kelimeLast = Console.ReadLine() ?? "";
                    Console.WriteLine("Son index: " + cumle.LastIndexOf(kelimeLast));
                    break;
                case "12":
                    Console.Write("Eklemek istediğiniz metin: ");
                    string ekle = Console.ReadLine() ?? "";
                    Console.Write("Hangi index'e eklemek istersiniz: ");
                    if (int.TryParse(Console.ReadLine(), out int insertIndex))
                    {
                        cumle = cumle.Insert(insertIndex, ekle);
                        Console.WriteLine("Yeni cümle: " + cumle);
                    }
                    else
                        Console.WriteLine("Geçersiz index.");
                    break;
                case "13":
                    Console.Write("Silmek istediğiniz başlangıç index: ");
                    if (int.TryParse(Console.ReadLine(), out int removeIndex))
                    {
                        Console.Write("Kaç karakter silinsin: ");
                        if (int.TryParse(Console.ReadLine(), out int removeCount))
                        {
                            cumle = cumle.Remove(removeIndex, removeCount);
                            Console.WriteLine("Yeni cümle: " + cumle);
                        }
                    }
                    break;
                case "14":
                    Console.WriteLine("Cümle boş mu? " + string.IsNullOrWhiteSpace(cumle));
                    break;
                case "0":
                    Console.WriteLine("Programdan çıkılıyor.");
                    return;
                default:
                    Console.WriteLine("Geçersiz seçim. Tekrar deneyin.");
                    break;
            }
            Console.WriteLine();
        }
    }
}