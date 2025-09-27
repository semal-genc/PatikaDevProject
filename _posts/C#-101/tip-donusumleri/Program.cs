Console.WriteLine("=== Implicit Conversion Örnekleri ===");
        
        // Implicit: küçük tipten büyük tipe geçiş (otomatik)
        int intSayi = 42;
        float floatSayi = intSayi;   // int -> float
        Console.WriteLine($"intSayi = {intSayi}, floatSayi (implicit) = {floatSayi}");

        short shortSayi = 10;
        int intSayi2 = shortSayi;     // short -> int
        Console.WriteLine($"shortSayi = {shortSayi}, intSayi2 (implicit) = {intSayi2}");

        Console.WriteLine("\n=== Explicit Conversion Örnekleri ===");
        
        // Explicit: veri kaybı olabilir, developer cast yapmalı
        double pi = 3.14159;
        int tamSayi = (int)pi;        // double -> int
        Console.WriteLine($"pi = {pi}, tamSayi (explicit) = {tamSayi}");

        long buyukSayi = 100000;
        int kucukSayi = (int)buyukSayi; // long -> int
        Console.WriteLine($"buyukSayi = {buyukSayi}, kucukSayi (explicit) = {kucukSayi}");

        // string -> sayısal tip dönüşümü explicit, Parse veya Convert ile yapılır
        string sayiStr = "123";
        int sayiInt = int.Parse(sayiStr);
        Console.WriteLine($"sayiStr = {sayiStr}, sayiInt (explicit Parse) = {sayiInt}");
        
        double sayiDouble = Convert.ToDouble(sayiStr);
        Console.WriteLine($"sayiStr = {sayiStr}, sayiDouble (explicit Convert) = {sayiDouble}");