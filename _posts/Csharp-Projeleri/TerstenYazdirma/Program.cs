internal class Program
{
    private static void Main(string[] args)
    {
        ReverseProcess reverseProcess = new ReverseProcess();
        reverseProcess.ReverseString();
    }
}

public class InputService
{
    public string GetInput()
    {
        Console.Write("Lütfen bir metin giriniz: ");
        return Console.ReadLine() ?? "";
    }
}

public class ReverseProcess
{
    public readonly InputService input = new InputService();
    public void ReverseString()
    {
        string word = input.GetInput();
        string[] words = word.Split(' ', StringSplitOptions.RemoveEmptyEntries);

        for (int i = 0; i < words.Length; i++)
        {
            words[i]=new string(words[i].Reverse().ToArray());
        }

        Console.WriteLine(string.Join(' ', words));
    }
}