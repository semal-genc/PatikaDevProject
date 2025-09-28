int sayac = 1;
int toplamWhile = 0;

while (sayac <= 10)
{
    toplamWhile += sayac;
    sayac++;
}
Console.WriteLine("1'den 10'a kadar sayıların toplamı (while): " + toplamWhile);

int[] sayilar = { 5, 10, 15, 20, 25 };
int toplamForeach = 0;

foreach (int sayi in sayilar)
{
    toplamForeach += sayi;
}

double ortalama = (double)toplamForeach / sayilar.Length;
Console.WriteLine("Dizideki sayıların ortalaması (foreach): " + ortalama);