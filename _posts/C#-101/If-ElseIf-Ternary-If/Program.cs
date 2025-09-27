Console.Write("Bir sayı girin: ");
int sayi = Convert.ToInt32(Console.ReadLine());

// If-Else ile kontrol
if (sayi % 2 == 0)
{
    Console.WriteLine("Sayı çift");
}
else
{
    Console.WriteLine("Sayı tek");
}

// Ternary operatörü ile kontrol
string sonuc = (sayi % 2 == 0) ? "Sayı çift" : "Sayı tek";
Console.WriteLine("Ternary ile: " + sonuc);

if (sayi > 0)
{
    Console.WriteLine("Sayı pozitif");
}
else if (sayi < 0)
{
    Console.WriteLine("Sayı negatif");
}
else
{
    Console.WriteLine("Sayı sıfır");
}