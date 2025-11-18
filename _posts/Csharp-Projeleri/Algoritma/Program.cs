internal class Program
{
    private static void Main(string[] args)
    {
       RemovalProcess removal=new RemovalProcess();
       removal.RemoveCharacter();
    }
}

public class InputService
{
    public Tuple<string, int> GetInput()
    {
        Console.Write("Cümle ve cümleden çıkarılacak harfin index numarasını giriniz (örn: Algoritma,3): ");
        string input = Console.ReadLine() ?? "";

        string[] inputs = input.Split(',', StringSplitOptions.TrimEntries);
        if (inputs.Length != 2)
            throw new Exception("Lütfen formatı doğru girin: string,sayı");

        string sentence = inputs[0];
        bool parsed = int.TryParse(inputs[1], out int index);
        if (!parsed)
            throw new Exception("Index bir sayı olmalı");
        return Tuple.Create(sentence, index);
    }
}

public class RemovalProcess
{
    private readonly InputService inputService = new InputService();
    public void RemoveCharacter()
    {
        var (sentence, index) = inputService.GetInput();

        if (index < 0 || index >= sentence.Length)
        {
            Console.WriteLine(sentence);
            return;
        }

        string result = sentence.Remove(index, 1);
        Console.WriteLine(result);
    }
}