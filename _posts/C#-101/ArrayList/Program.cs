using System.Collections;

internal class Program
{
    private static void Main(string[] args)
    {
        ArrayList liste = new ArrayList();
        liste.Add(10);
        liste.Add(5);
        liste.Add(20);

        Console.WriteLine("ArrayList Elemanları:");
        foreach (var item in liste)
            Console.WriteLine(item);

        Console.WriteLine("\n---\n");

        // ---------- SortedList (Binary List Mantığı) ----------
        // Key-Value mantığı ile çalışır, ama biz sadece key kullanacağız
        SortedList<int, string> binaryList = new SortedList<int, string>();
        binaryList.Add(10, "On");
        binaryList.Add(5, "Beş");
        binaryList.Add(20, "Yirmi");

        Console.WriteLine("SortedList (Binary List) Elemanları (Otomatik Sıralı):");
        foreach (var kvp in binaryList)
            Console.WriteLine($"Key: {kvp.Key}. Value: {kvp.Value}");
        // Eleman arama (Binary Search mantığıyla hızlı)
        int aranan = 5;
        if (binaryList.ContainsKey(aranan))
            Console.WriteLine($"\n{aranan} listede bulundu: {binaryList[aranan]}");
        // Eleman silme
        binaryList.Remove(10);
        Console.WriteLine("\n10 silindikten sonra SortedList:");
        foreach (var kvp in binaryList)
        {
            Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}");
        }
    }
}