internal class Program
{
    private static void Main(string[] args)
    {
        int size = InputHandler.ReadSize();

        TriangleDrawer drawer = new TriangleDrawer();
        drawer.Draw(size);

    }
}

class InputHandler
{
    public static int ReadSize()
    {
        while (true)
        {
            Console.WriteLine("Boyut (min 2): ");
            if (int.TryParse(Console.ReadLine(), out int value) && value > 1)
                return value;
            Console.WriteLine("Lütfen 1'den büyük sayı girin!");
        }
    }
}

class TriangleDrawer
{
    public void Draw(int size)
    {
        for (int row = 0; row < size; row++)
        {
            string spaces = new string(' ', size - row - 1);

            if (row == size - 1)
            {
                string underscores = new string('_', size * 2 - 2);
                Console.WriteLine("/" + underscores + "\\");
            }
            else
            {
                string middle = new string(' ', row * 2);
                Console.WriteLine(spaces + "/" + middle + "\\");
            }
        }
    }
}