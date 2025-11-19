internal class Program
{
    private static void Main(string[] args)
    {
        AdditionProcess additionProcess = new();

        Console.WriteLine(string.Join(' ', additionProcess.BinarySumProcess()));
    }
}

public class InputService
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
        int count = ReadInt("Kaç sayı gireceksiniz: ");

        while (count % 2 != 0)
        {
            Console.WriteLine("Lütfen çift sayıda sayı girin (ikili işlem yapılacak).");
            count = ReadInt("Kaç sayı gireceksiniz: ");
        }

        List<int> numbers = new List<int>();
        for (int i = 0; i < count; i++)
        {
            int number;
            while (true)
            {
                Console.Write($"{i + 1}. sayıyı girin: ");
                if (int.TryParse(Console.ReadLine()!, out number))
                    break;
                Console.WriteLine("Hatalı giriş! Lütfen sayı girin.");
            }
            numbers.Add(number);
        }
        return numbers;
    }
}

public class AdditionProcess
{
    public List<int> BinarySumProcess()
    {
        InputService input = new();
        List<int> numbers = input.GetNumbersFromUser();

        List<int> result = new();

        for (int i = 0; i < numbers.Count; i += 2)
        {
            int first = numbers[i];
            int second = numbers[i + 1];

            if (first == second)
                result.Add((first + second) * (first + second));
            else
                result.Add(first + second);
        }
        return result;
    }
}