internal class Program
{
    public int ArttırVeTopla(ref int x, ref int y)
    {
        x += 1;
        y += y;
        return x + y;
    }

    private static void Main(string[] args)
    {
        Program instance = new Program();

        int a = 3;
        int b = 4;

        Console.WriteLine("Metot çağrılmadan önce:");
        Console.WriteLine("a = " + a);
        Console.WriteLine("b = " + b);

        int sonuc = instance.ArttırVeTopla(ref a, ref b);

        Console.WriteLine("\nMetot çağrıldıktan sonra:");
        Console.WriteLine("a = " + a);
        Console.WriteLine("b = " + b);
        Console.WriteLine("Sonuç = " + sonuc);
    }
}