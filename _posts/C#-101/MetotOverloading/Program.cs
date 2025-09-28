internal class Program
{
    public void EkranaYazdir(int deger)
    {
        Console.WriteLine("Int: " + deger);
    }

    public void EkranaYazdir(string deger)
    {
        Console.WriteLine("String: " + deger);
    }

    public void EkranaYazdir(string deger1, string deger2)
    {
        Console.WriteLine("String + String: " + deger1 + deger2);
    }

    public int Toplam(int a, int b, out int toplam)
    {
        toplam = a + b;
        return toplam;
    }

    private static void Main(string[] args)
    {
        Program instance = new Program();

        instance.EkranaYazdir(5);
        instance.EkranaYazdir("Merhaba");
        instance.EkranaYazdir("Merhaba", " Dünya");

        Console.WriteLine();

        int sonuc;
        int toplamSonuc = instance.Toplam(4, 8, out sonuc);

        Console.WriteLine("Toplam (out ile): " + sonuc);
        Console.WriteLine("Toplam (return ile): " + toplamSonuc);
    }
}