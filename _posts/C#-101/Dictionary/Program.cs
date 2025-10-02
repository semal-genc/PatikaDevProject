internal class Program
{
    private static void Main(string[] args)
    {
        Dictionary<int, string> ogrenciler = new Dictionary<int, string>();

        // Eleman ekleme
        ogrenciler.Add(101, "Ahmet");
        ogrenciler.Add(102, "Mehmet");
        ogrenciler.Add(103, "Ayşe");

        // Eleman ekrana yazdırma
        Console.WriteLine("Öğrenciler Dictionary:");
        foreach (KeyValuePair<int, string> kvp in ogrenciler)
            Console.WriteLine($"ID: {kvp.Key}, İsim: {kvp.Value}");

        Console.WriteLine("\n---\n");

        // Eleman arama
        int arananID = 102;
        if (ogrenciler.ContainsKey(arananID))
            Console.WriteLine($"{arananID} ID'li öğrenci bulundu: {ogrenciler[arananID]}");

        // Eleman güncelleme
        ogrenciler[103] = "Ayşe Yılmaz";
        Console.WriteLine("\nGüncelleme sonrası:");
        foreach (var kvp in ogrenciler)
        {
            Console.WriteLine($"ID: {kvp.Key}, İsim: {kvp.Value}");
        }

        // Eleman silme
        ogrenciler.Remove(101);
        Console.WriteLine("\n101 ID'li öğrenci silindikten sonra:");
        foreach (var kvp in ogrenciler)
        {
            Console.WriteLine($"ID: {kvp.Key}, İsim: {kvp.Value}");
        }

         // Eleman sayısı
        Console.WriteLine($"\nDictionary eleman sayısı: {ogrenciler.Count}");

        // Key ve Value koleksiyonları
        Console.WriteLine("\nTüm ID'ler:");
        foreach (var key in ogrenciler.Keys)
            Console.WriteLine(key);

        Console.WriteLine("\nTüm İsimler:");
        foreach (var value in ogrenciler.Values)
            Console.WriteLine(value);

        // Clear ile temizleme
        ogrenciler.Clear();
        Console.WriteLine($"\nTemizlendikten sonra eleman sayısı: {ogrenciler.Count}");
    }
}