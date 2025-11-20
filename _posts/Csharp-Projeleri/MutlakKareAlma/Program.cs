internal class Program
{
    private static void Main(string[] args)
    {
        InputService inputService=new();
        INumberProcess process=new NumbersProcess(inputService);

        var result=process.SquartAndSumProcess();

        Console.WriteLine($"Küçüklerin toplamı: {result.Item1}");
        Console.WriteLine($"Büyüklerin kare toplamı: {result.Item2}");
    }
}

public interface IInputService
{
    int ReadInt(string message);
    List<int> GetNumbersFromUser();
}

public class InputService : IInputService
{
    public int ReadInt(string message)
    {
        while (true)
        {
            Console.Write(message);
            if (int.TryParse(Console.ReadLine()!, out int value))
                return value;
            Console.WriteLine("Hatalı giriş! Lütfen sayı girin.");
        }
    }

    public List<int> GetNumbersFromUser()
    {
        int count = ReadInt("Kaç sayı gireceksiniz:  ");
        List<int> numbers = new();

        for (int i = 0; i < count; i++)
        {
            numbers.Add(ReadInt($"{i + 1}. sayıyı girin: "));
        }
        return numbers;
    }
}

public interface INumberProcess
{
    Tuple<int, int> SquartAndSumProcess();
}

public class NumbersProcess : INumberProcess
{
    private readonly IInputService _input;
    private const int ProcessNumber = 67;

    public NumbersProcess(InputService input)
    {
        _input = input;
    }

    public Tuple<int, int> SquartAndSumProcess()
    {
        List<int> numbers = _input.GetNumbersFromUser();

        int smallTotal = 0;
        int squareTotal = 0;

        foreach (int number in numbers)
        {
            if (number < ProcessNumber)
            {
                smallTotal += ProcessNumber - number;
            }
            else
            {
                int diff = ProcessNumber - number;
                squareTotal += diff * diff;
            }
        }
        return Tuple.Create(smallTotal, squareTotal);
    }
}