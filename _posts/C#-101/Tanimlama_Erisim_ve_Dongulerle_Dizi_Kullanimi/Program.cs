int[] sayilar = new int[5];
sayilar[0] = 10;
sayilar[1] = 20;
sayilar[2] = 30;
sayilar[3] = 40;
sayilar[4] = 50;

Console.WriteLine("=== Dizi Elemanları (Index ile erişim) ===");
Console.WriteLine("1. eleman: " + sayilar[0]);
Console.WriteLine("3. eleman: " + sayilar[2]);
Console.WriteLine("Son eleman: " + sayilar[sayilar.Length - 1]);

string[] renkler = { "Mavi", "Kırmızı", "Sarı", "Yeşil" };
Console.WriteLine("\n=== Renk Dizisi ===");
Console.WriteLine("2. eleman: " + renkler[1]);

Console.WriteLine("\n=== For Döngüsüyle Sayı Dizisi ===");
int[] sayiDizisi = new int[3];
int toplam = 0;
for (int i = 0; i < sayiDizisi.Length; i++)
{
    Console.Write("Lütfen {0}. sayıyı giriniz: ", i + 1);
    sayiDizisi[i] = Convert.ToInt32(Console.ReadLine());
    toplam += sayiDizisi[i];
}
double ortalama = (double)toplam / sayiDizisi.Length;
Console.WriteLine("Girilen sayıların ortalaması: " + ortalama);

Console.WriteLine("\n=== Foreach Döngüsüyle Renkler ===");
foreach (string renk in renkler)
{
    Console.WriteLine("Renk: " + renk);
}