internal class Program
{
    private static void Main(string[] args)
    {
        SentenceProcess sentenceProcess=new();
        string[] sentence=sentenceProcess.ChangeSentence();
        Console.WriteLine(string.Join(' ', sentence));
    }
}

public class InputService
{
    public string ReadString()
    {
        Console.Write("Bir metin giriniz: ");
        return Console.ReadLine() ?? "";
    }
}

public class SentenceProcess
{
    InputService inputService = new();

    public static string SwapFirstLast(string word)
    {
        if (word.Length < 2)
            return word;
        return word[^1] + word.Substring(1, word.Length - 2) + word[0];
    }

    public string[] ChangeSentence()
    {
        string sentence = inputService.ReadString();

        string[] words = sentence.Split(' ', StringSplitOptions.RemoveEmptyEntries);

        for (int i = 0; i < words.Length; i++)
        {
            words[i] = SwapFirstLast(words[i]);
        }
        return words;
    }
}