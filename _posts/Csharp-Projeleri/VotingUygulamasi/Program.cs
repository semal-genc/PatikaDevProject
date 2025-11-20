internal class Program
{
    private static void Main(string[] args)
    {
        VotingProcess voting=new();
        voting.StartVoting();
    }
}

public enum Categories
{
    Film,
    TechStack,
    Spor
}

public class InputService
{
    public string ReadString(string message)
    {
        Console.Write(message);
        return Console.ReadLine() ?? "";
    }

    public string GetUsernameFromUser()
    {
        return ReadString("Lütfen kullanıcı adınızı girin: ");
    }

    public Categories GetCategoryFromUser()
    {
        Console.WriteLine("Mevcut kategoriler:");
        foreach (var cat in Enum.GetNames(typeof(Categories)))
        {
            Console.WriteLine("- " + cat);
        }

        while (true)
        {
            string input = ReadString("Lütfen oy vermek istediğiniz kategoriyi yazın: ");
            if (Enum.TryParse<Categories>(input, ignoreCase: true, out var category))
                return category;
            Console.WriteLine("Geçersiz kategori! Lütfen tekrar deneyin.");
        }
    }
}

public class Users
{
    private static HashSet<string> _usernames = new();
    private string username;

    public Users(string username)
    {
        if (_usernames.Contains(username))
            throw new Exception("Bu kullanıcı adı zaten mevcut!");
        this.username = username;
        _usernames.Add(username);
    }

    public string Username
    {
        get => username;
        set
        {
            if (_usernames.Contains(value))
                throw new Exception("Bu kullanıcı adı zaten mevcut!");
            _usernames.Remove(username);
            username = value;
            _usernames.Add(username);
        }
    }

    public static bool Exists(string username)
    {
        return _usernames.Contains(username);
    }
}

public class VotingProcess
{
    private readonly InputService inputService = new();
    private readonly Dictionary<Categories, int> _votes = new();
    private readonly List<Users> _registeredUsers = new();

    public VotingProcess()
    {
        foreach (Categories category in Enum.GetValues(typeof(Categories)))
        {
            _votes[category] = 0;
        }
    }

    public void StartVoting()
    {
        bool continueVoting = true;

        while (continueVoting)
        {
            string username = inputService.GetUsernameFromUser();

            if (!Users.Exists(username))
            {
                Console.WriteLine("Kullanıcı kayıtlı değil, kaydediliyor...");
                Users newUser = new Users(username);
                _registeredUsers.Add(newUser);
            }
            else
            {
                Console.WriteLine($"Hoş geldiniz {username}");
            }

            Categories category = inputService.GetCategoryFromUser();
            _votes[category]++;
            Console.WriteLine($"{username} kullanıcısı {category} kategorisine oy verdi!\n");

            string more = inputService.ReadString("Başka kullanıcı oy verecek mi? (e/h): ").ToLower();
            if (more != "e") continueVoting = false;
        }
        ShowResults();
    }


    public void ShowResults()
    {
        int totalValues = _votes.Values.Sum();
        Console.WriteLine("\n--- Voting Sonuçları ---");

        foreach (var kvp in _votes)
        {
            double percentage = totalValues == 0 ? 0 : (kvp.Value * 100.0) / totalValues;
            Console.WriteLine($"{kvp.Key}: {kvp.Value} oy ({percentage:F2}%)");
        }
    }
}