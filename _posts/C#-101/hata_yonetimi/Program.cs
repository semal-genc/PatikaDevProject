Console.WriteLine("=== Try-Catch-Finally Örneği ===");

try
{
    // Kullanıcıdan iki sayı al
    Console.Write("Birinci sayıyı girin: ");
    int a = int.Parse(Console.ReadLine());

    Console.Write("İkinci sayıyı girin: ");
    int b = int.Parse(Console.ReadLine());

    if (b == 0)
    {
        throw new InvalidOperationException("Bölme işlemi için ikinci sayı 0 olamaz!");
    }
    int toplam = a + b;
    int bolum = a / b;
    Console.WriteLine($"Toplam: {toplam}, Bölüm: {bolum}");
}
catch (FormatException ex)
{
    // Hatalı format girildiğinde çalışır
    Console.WriteLine("Hata: Lütfen bir sayı girin. " + ex.Message);
}
catch(InvalidOperationException ex)
{
    // Mantıksal hata yakalanır
            Console.WriteLine("Mantıksal Hata: " + ex.Message);
}
catch (Exception ex)
{
    // Diğer tüm hatalar için çalışır
    Console.WriteLine("Beklenmeyen bir hata oluştu: " + ex.Message);
}
finally
{
    // Her durumda çalışır
    Console.WriteLine("Program sonlandı.");
}