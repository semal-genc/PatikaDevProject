// 1. Atama ve İşlemli Atama Operatörleri
        int x = 10;          
        Console.WriteLine("Atama ve İşlemli Atama Operatörleri");
        Console.WriteLine("x = " + x);

        x += 5;
        Console.WriteLine("x += 5 : " + x);

        x -= 3;
        Console.WriteLine("x -= 3 : " + x);

        x *= 2;
        Console.WriteLine("x *= 2 : " + x);

        x /= 4;
        Console.WriteLine("x /= 4 : " + x);

        Console.WriteLine("\n----------------------------\n");

        // 2. Mantıksal Operatörler
        bool a = true;
        bool b = false;

        Console.WriteLine("Mantıksal Operatörler");
        Console.WriteLine("a || b : " + (a || b));
        Console.WriteLine("a && b : " + (a && b));
        Console.WriteLine("!a : " + (!a));

        Console.WriteLine("\n----------------------------\n");

        // 3. İlişkisel Operatörler
        int y = 20;

        Console.WriteLine("İlişkisel Operatörler");
        Console.WriteLine("x == y : " + (x == y));
        Console.WriteLine("x != y : " + (x != y));
        Console.WriteLine("x < y  : " + (x < y));
        Console.WriteLine("x > y  : " + (x > y));
        Console.WriteLine("x >= 10 : " + (x >= 10));
        Console.WriteLine("y <= 15 : " + (y <= 15));

        Console.WriteLine("\n----------------------------\n");

        // 4. Aritmetik Operatörler
        int m = 15, n = 4;

        Console.WriteLine("Aritmetik Operatörler");
        Console.WriteLine("m + n : " + (m + n));
        Console.WriteLine("m - n : " + (m - n));
        Console.WriteLine("m * n : " + (m * n));
        Console.WriteLine("m / n : " + (m / n));
        Console.WriteLine("m % n : " + (m % n));

        int c = 5;
        Console.WriteLine("c++ : " + (c++));
        Console.WriteLine("c (şimdi) : " + c);
        Console.WriteLine("++c : " + (++c));

        int d = 10;
        Console.WriteLine("d-- : " + (d--));
        Console.WriteLine("d (şimdi) : " + d);
        Console.WriteLine("--d : " + (--d));