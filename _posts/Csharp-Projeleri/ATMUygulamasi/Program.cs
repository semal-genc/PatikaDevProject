internal class Program
{
    private static void Main(string[] args)
    {
        AtmManager atm = new AtmManager();
        atm.Start();
    }
}

public enum Islemler
{
    ParaCekme,
    ParaYatirma,
    OdemeYapma
}

public class Users
{
    private static Dictionary<string, Users> _users = new();
    public string Username { get; private set; }
    public int Password { get; private set; }
    public double Balance { get; set; }
    public Users(string username, int password)
    {
        Username = username;
        Password = password;
        Balance = 0;
    }

    public static Users Register(string username, int password)
    {
        if (_users.ContainsKey(username))
            throw new Exception("Bu kullanıcı adı zaten mevcut!");

        Users newUser = new Users(username, password);
        _users.Add(username, newUser);
        return newUser;
    }

    public static Users Login(string username, int password)
    {
        if (_users.TryGetValue(username, out Users? user) && user.Password == password)
            return user;
        return null;
    }

    public static bool Exists(string username) => _users.ContainsKey(username);
}

public class InputService
{
    public string ReadString(string message)
    {
        Console.Write(message);
        return Console.ReadLine() ?? "";
    }

    public int ReadInt(string message)
    {
        while (true)
        {
            Console.Write(message);
            if (int.TryParse(Console.ReadLine(), out int value))
                return value;
            Console.WriteLine("Hatalı giriş! Lütfen sayı girin.");
        }
    }

    public string GetUsername() => ReadString("Lütfen kullanıcı adınızı girin: ");
    public int GetPassword() => ReadInt("Şifrenizi girin (4 haneli): ");
    public double GetAmount() => ReadInt("Tutar girin: ");

    public Islemler GetIslem()
    {
        Console.WriteLine("Mevcut kategoriler: ");
        foreach (var islem in Enum.GetNames(typeof(Islemler)))
        {
            Console.WriteLine("- " + islem);
        }

        while (true)
        {
            string input = ReadString("Lütfen yapmak istediğiniz işlemi seçiniz: ");
            if (Enum.TryParse<Islemler>(input, ignoreCase: true, out var islemler))
                return islemler;
            Console.WriteLine("Geçersiz işlem! Lütfen tekrar deneyin.");
        }
    }
}
public class Transaction
{
    public string? Username { get; set; }
    public string? Operation { get; set; }
    public double Amount { get; set; }
    public DateTime Time { get; set; }
}

public class AtmManager
{
    private InputService inputService = new();
    private Users currentUser;
    private List<Transaction> transactions = new();

    public void Start()
    {
        string username = inputService.GetUsername();
        int password = inputService.GetPassword();

        if (Users.Exists(username))
        {
            currentUser = Users.Login(username, password);
            if (currentUser == null)
            {
                Console.WriteLine("Şifre hatalı. Programdan çıkılıyor.");
                return;
            }
        }
        else
        {
            currentUser = Users.Register(username, password);
            Console.WriteLine("Yeni kullanıcı kaydı oluşturuldu.");
        }
        Menu();
    }

    private void Menu()
    {
        bool exit = false;
        while (!exit)
        {
            Islemler islem = inputService.GetIslem();
            double amount = 0;

            switch (islem)
            {
                case Islemler.ParaCekme:
                    amount = inputService.GetAmount();
                    if (currentUser.Balance < amount)
                    {
                        Console.WriteLine("Yetersiz bakiye!");
                    }
                    else
                    {
                        currentUser.Balance -= amount;
                        transactions.Add(new Transaction { Username = currentUser.Username, Operation = "Para Çekme", Amount = amount, Time = DateTime.Now });
                        Console.WriteLine($"{amount} TL çekildi. Güncel bakiye: {currentUser.Balance}");
                    }
                    break;
                case Islemler.ParaYatirma:
                    amount = inputService.GetAmount();
                    currentUser.Balance += amount;
                    transactions.Add(new Transaction { Username = currentUser.Username, Operation = "Para Yatırma", Amount = amount, Time = DateTime.Now });
                    Console.WriteLine($"{amount} TL yatırıldı. Güncel bakiye: {currentUser.Balance}");
                    break;
                case Islemler.OdemeYapma:
                    amount = inputService.GetAmount();
                    if (currentUser.Balance < amount)
                    {
                        Console.WriteLine("Yetersiz bakiye!");
                    }
                    else
                    {
                        currentUser.Balance -= amount;
                        transactions.Add(new Transaction { Username = currentUser.Username, Operation = "Ödeme Yapma", Amount = amount, Time = DateTime.Now });
                        Console.WriteLine($"{amount} TL ödendi. Güncel bakiye: {currentUser.Balance}");
                    }
                    break;
                default:
                    Console.WriteLine("Hatalı Seçim!");
                    break;
            }
            string cont = inputService.ReadString("Başka işlem yapmak ister misiniz? (e/h): ").ToLower();
            if (cont != "e")
            {
                exit = true;
                EndOfDay();
            }
        }
    }

    private void EndOfDay()
    {
        string date = DateTime.Now.ToString("ddMMyyyy");
        string fileName = $"EOD_{date}.txt";
        using (StreamWriter writer = new StreamWriter(fileName))
        {
            writer.WriteLine("Gün Sonu Transaction Logları:");
            foreach (var t in transactions)
            {
                writer.WriteLine($"{t.Time} - {t.Username} - {t.Operation} - {t.Amount} TL");
            }
        }
        Console.WriteLine($"Gün sonu logu '{fileName}' dosyasına yazıldı.");
    }
}