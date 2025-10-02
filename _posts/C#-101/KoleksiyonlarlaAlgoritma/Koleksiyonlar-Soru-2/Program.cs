using System.Collections;

internal class Program
{
    private static void Main(string[] args)
    {
        /*Klavyeden girilen 20 adet sayının en büyük 3 tanesi ve en küçük 3 tanesi bulan, her iki grubun kendi içerisinde ortalamalarını alan ve bu ortalamaları ve ortalama toplamlarını console'a yazdıran programı yazınız. (Array sınıfını kullanarak yazınız.)*/
        ArrayList enBuyuk = new ArrayList();
        ArrayList enKucuk = new ArrayList();
        ArrayList sayilar = new ArrayList();
        int kucukOrt = 0, sumK = 0;
        int buyukOrt = 0, sumB = 0;

        Console.WriteLine("20 Adet pozitif sayı giriniz: ");
        for (int i = 0; i < 20; i++)
        {
            Console.Write($"{i + 1}. sayıyı giriniz: ");
            int sayi = Convert.ToInt32(Console.ReadLine());
            sayilar.Add(sayi);
        }

        sayilar.Sort();
        for (int i = 0; i < 3 && i < sayilar.Count; i++)
        {
            enKucuk.Add(sayilar[i]);
        }

        sayilar.Reverse();
        for (int i = 0; i < 3 && i < sayilar.Count; i++)
        {
            enBuyuk.Add(sayilar[i]);
        }

        foreach (int enK in enKucuk)
            sumK += enK;
        foreach (int enB in enBuyuk)
            sumB += enB;

        kucukOrt = sumK / enKucuk.Count;
        buyukOrt = sumB / enBuyuk.Count;
        Console.WriteLine($"En küçük üç sayı: {string.Join(", ", enKucuk.ToArray())}");
        Console.WriteLine($"En büyük üç sayının ortalaması: {string.Join(", ", enBuyuk.ToArray())}");
        Console.WriteLine("En küçük üç sayının ortalaması: " + kucukOrt);
        Console.WriteLine("En büyük üç sayının ortalaması: " + buyukOrt);
        Console.WriteLine("En küçük ve en büyük üç sayının ortalamasının toplamı: " + (kucukOrt + buyukOrt));
    }
}