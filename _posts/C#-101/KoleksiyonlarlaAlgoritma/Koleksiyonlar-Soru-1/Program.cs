using System.Collections;

internal class Program
{
    private static void Main(string[] args)
    {
        /*Klavyeden girilen 20 adet pozitif sayının asal ve asal olmayan olarak 2 ayrı listeye atın. (ArrayList sınıfını kullanara yazınız.)
        Negatif ve numeric olmayan girişleri engelleyin.
        Her bir dizinin elemanlarını büyükten küçüğe olacak şekilde ekrana yazdırın.
        Her iki dizinin eleman sayısını ve ortalamasını ekrana yazdırın.*/
        int sum = 0;
        int ortalama = 0;
        ArrayList asalSayilar = new ArrayList();
        ArrayList asalOlmayanlar = new ArrayList();

        Console.WriteLine("20 Adet pozitif sayı giriniz: ");
        for (int i = 0; i < 20; i++)
        {
            Console.Write($"{i + 1}. sayıyı giriniz: ");
            int sayi = Convert.ToInt32(Console.ReadLine());
            if (AsalMi(sayi))
                asalSayilar.Add(sayi);
            else
                asalOlmayanlar.Add(sayi);
        }

        asalSayilar.Sort();
        asalSayilar.Reverse();
        asalOlmayanlar.Sort();
        asalOlmayanlar.Reverse();

        Console.WriteLine("\n--- Asal Sayılar ---");
        foreach (int asal in asalSayilar)
            Console.WriteLine(asal);
        Console.WriteLine("\n--- Asal Olmayan Sayılar ---");
        foreach (int asalO in asalOlmayanlar)
            Console.WriteLine(asalO);

        Console.WriteLine("\n--- Her iki dizinin eleman sayısı ve ortalaması ---");
        asalSayilar.AddRange(asalOlmayanlar);
        Console.WriteLine("Her iki dizinin eleman sayısı: " + asalSayilar.Count);
        foreach (int asal in asalSayilar)
        {
            sum += asal;
        }
        ortalama = sum / asalSayilar.Count;
        Console.WriteLine("Her iki dizinin ortalaması: " + ortalama);
    }
    static bool AsalMi(int sayi)
    {
        if (sayi < 2) return false;
        for (int i = 2; i <= Math.Sqrt(sayi); i++)
        {
            if (sayi % 2 == 0) return false;
        }
        return true;
    }
}