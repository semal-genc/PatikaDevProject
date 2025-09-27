Console.Write("Merdiven yüksekliğini girin (1-20 arası): ");
int n = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= n; i++)
{
    if (n > 20)
    {
        Console.WriteLine("Hata: 20'den büyük değerler desteklenmiyor.");
        break;
    }

    if (i <= 0)
    {
        continue;
    }

    for (int j = 1; j <= n - i; j++)
    {
        Console.Write(" ");
    }

    for (int k = 1; k <= i; k++)
    {
        Console.Write("#");
    }

    Console.WriteLine();
}

Console.WriteLine("Merdiven çizimi tamamlandı!");
