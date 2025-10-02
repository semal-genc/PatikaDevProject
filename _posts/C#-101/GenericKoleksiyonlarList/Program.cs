internal class Program
{
    private static void Main(string[] args)
    {
        //String listesi
        List<string> renkler = new List<string>();
        renkler.Add("Mavi");
        renkler.Add("Kırmızı");
        renkler.Add("Yeşil");

        Console.WriteLine("Renkler Listesi:");
        renkler.ForEach(renk => Console.WriteLine(renk));
        Console.WriteLine("\n---\n");

        // Int listesi
        List<int> sayilar = new List<int>();
        sayilar.Add(10);
        sayilar.Add(20);
        sayilar.Add(30);

        Console.WriteLine("Sayılar Listesi:");
        sayilar.ForEach(sayi => Console.WriteLine(sayi));
        Console.WriteLine("\n---\n");

        Console.WriteLine("Renkler listesinde kaç eleman var: " + renkler.Count);
        Console.WriteLine("İlk renk: " + renkler[0]);
        Console.WriteLine("Son renk: " + renkler[renkler.Count - 1]);

        // Eleman silme
        renkler.Remove("Kırmızı");
        Console.WriteLine("\nKırmızı silindikten sonra renkler:");
        renkler.ForEach(renk => Console.WriteLine(renk));

        // Eleman arama
        if (renkler.Contains("Yeşil"))
        {
            Console.WriteLine("\nYeşil listede var.");
        }
        else
        {
            Console.WriteLine("\nYeşil listede yok.");
        }
    }
}