internal class Program
{
    private static void Main(string[] args)
    {
        InputService inputService = new();
        string sentence = inputService.GetSentence();
        ConsonantChecker checker = new();
        checker.CheckWords(sentence);
    }
}

public class InputService
{
    public string GetSentence()
    {
        Console.Write("Bir metin giriniz: ");
        return Console.ReadLine() ?? "";
    }
}

public class ConsonantChecker
{
    private readonly char[] _consonants = { 'b', 'c', 'ç', 'd', 'f', 'g', 'ğ', 'h', 'j', 'k', 'l', 'm', 'n', 'p', 'r', 's', 'ş', 't', 'v', 'y', 'z' };

    public void CheckWords(string sentence)
    {
        if (string.IsNullOrWhiteSpace(sentence))
        {
            Console.WriteLine("Girdi boş!");
            return;
        }

        string[] words = sentence.ToLower().Split(' ', StringSplitOptions.RemoveEmptyEntries);

        foreach (var word in words)
        {
            Console.Write(IsTwoConsecutiveConsonants(word) + " ");
        }
    }

    private bool IsTwoConsecutiveConsonants(string word)
    {
        for (int i = 0; i < word.Length - 1; i++)
        {
            if (_consonants.Contains(word[i]) && _consonants.Contains(word[i + 1]))
                return true;
        }
        return false;
    }
}