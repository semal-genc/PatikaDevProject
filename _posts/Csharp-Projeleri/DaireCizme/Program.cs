internal class Program
{
    private static void Main(string[] args)
    {
        InputService input = new InputService();
        CircleDrawer drawer = new CircleDrawer();

        drawer.DrawCircle(input.GetRadius());
    }
}

public class InputService
{
    public int GetRadius()
    {
        while (true)
        {
            Console.Write("Yarıçap giriniz: ");
            if (int.TryParse(Console.ReadLine() ?? "", out int radius) && radius > 0)
                return radius;
            Console.WriteLine("Lütfen 0'dan büyük sayı girin!");
        }
    }
}

public class CircleMath
{
    public bool IsOnCircle(int x, int y, int r)
    {
        int pointDistance = x * x + y * y, circleDistance = r * r;
        double tolerans = r * 0.2;

        return Math.Abs(pointDistance - circleDistance) < tolerans;
    }
}

public class CircleDrawer
{
    private readonly CircleMath _math = new CircleMath();

    public void DrawCircle(int r)
    {
        for (int y = -r; y <= r; y++)
        {
            for (int x = -r; x <= r; x++)
            {
                if (_math.IsOnCircle(x, y, r))
                    Console.Write("*");
                else
                    Console.Write(" ");
            }
            Console.WriteLine();
        }
    }
}