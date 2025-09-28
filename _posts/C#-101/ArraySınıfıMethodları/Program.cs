int[] sayiDizisi = { 1, 3, 4, 9, 8, 7 };

Console.WriteLine("Başlangıç Dizisi:");
foreach (var sayi in sayiDizisi)
Console.Write(sayi + " ");
Console.WriteLine("\n");

Array.Sort(sayiDizisi);
Console.WriteLine("Sort ile sıralandı:");
foreach (var sayi in sayiDizisi)
Console.Write(sayi + " ");
Console.WriteLine("\n");

Array.Clear(sayiDizisi, 2, 2);
Console.WriteLine("Clear(2,2) sonrası:");
foreach (var sayi in sayiDizisi)
Console.Write(sayi + " ");
Console.WriteLine("\n");

Array.Reverse(sayiDizisi);
Console.WriteLine("Reverse sonrası:");
foreach (var sayi in sayiDizisi)
Console.Write(sayi + " ");
Console.WriteLine("\n");

int index = Array.IndexOf(sayiDizisi, 9);
Console.WriteLine("9 sayısının indexi: " + index);
index = Array.IndexOf(sayiDizisi, 99);
Console.WriteLine("99 sayısının indexi (yok): " + index + "\n");

Array.Resize<int>(ref sayiDizisi, 10);
sayiDizisi[6] = 10;
Console.WriteLine("Resize(10) sonrası:");
foreach (var sayi in sayiDizisi)
Console.Write(sayi + " ");
Console.WriteLine("\n");

Array.Resize<int>(ref sayiDizisi, 3);
Console.WriteLine("Resize(3) sonrası:");
foreach (var sayi in sayiDizisi)
Console.Write(sayi + " ");
Console.WriteLine();