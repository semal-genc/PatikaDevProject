﻿Console.WriteLine("Bir gün numarası girin (1-Pazartesi, 2-Salı, ..., 7-Pazar):");
int gun = Convert.ToInt32(Console.ReadLine());

switch (gun)
{
    case 1:
        Console.WriteLine("Pazartesi");
        break;
    case 2:
        Console.WriteLine("Salı");
        break;
    case 3:
        Console.WriteLine("Çarşamba");
        break;
    case 4:
        Console.WriteLine("Perşembe");
        break;
    case 5:
        Console.WriteLine("Cuma");
        break;
    case 6:
        Console.WriteLine("Cumartesi");
        break;
    case 7:
        Console.WriteLine("Pazar");
        break;
    default:
        Console.WriteLine("Geçersiz gün numarası!");
        break;
}