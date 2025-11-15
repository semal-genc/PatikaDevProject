internal class Program
{
    private static void Main(string[] args)
    {
        var inputReader = new InputReader();
        var fibonacciGenerator = new FibonacciGenerator();
        var averageCalculator = new AverageCalculator();

        int depth = inputReader.InputDepth();
        List<int> fibonacci = fibonacciGenerator.Generate(depth);

        Console.WriteLine("\nFibonacci Serisi:");
        Console.WriteLine(string.Join(", ", fibonacci));

        double average = averageCalculator.Calculate(fibonacci);
        Console.WriteLine($"\nOrtalama = {average}");
    }
}

public class InputReader
{
    public int InputDepth()
    {
        Console.Write("Fibonacci derinliğini girin: ");
        return int.Parse(Console.ReadLine() ?? "");
    }
}


public class FibonacciGenerator
{
    public List<int> Generate(int depth)
    {
        List<int> fibonacci = new List<int>();

        if (depth <= 0) return fibonacci;

        fibonacci.Add(0);

        if (depth == 1) return fibonacci;

        fibonacci.Add(1);

        for (int i = 2; i < depth; i++)
        {
            int next = fibonacci[i - 1] + fibonacci[i - 2];
            fibonacci.Add(next);
        }
        return fibonacci;
    }
}

public class AverageCalculator
{
    public double Calculate(IEnumerable<int> numbers)
    {
        double sum = 0;
        int count = 0;

        foreach (var num in numbers)
        {
            sum += num;
            count++;
        }
        return count == 0 ? 0 : sum / count;
    }
}