using SkiaSharp;
using ZXing;
using ZXing.Common;

internal class Program
{
    private static void Main(string[] args)
    {
        var inputService = new InputService();
        var barcodeManager = new BarcodeManager();

        while (true)
        {
            MenuOption choice = inputService.GetMenuOption();

            switch (choice)
            {
                case MenuOption.CreateBarcode:
                    barcodeManager.CreateBarcode();
                    break;
                case MenuOption.ReadBarcode:
                    barcodeManager.ReadBarcode();
                    break;
                case MenuOption.Exit:
                    return;
                default:
                    Console.WriteLine("Hatalı seçim!");
                    break;
            }
            Console.WriteLine();
        }
    }
}

public class InputService
{
    public long ReadInt(string message)
    {
        while (true)
        {
            Console.Write(message);
            if (long.TryParse(Console.ReadLine() ?? "", out long value))
                return value;
            Console.WriteLine("Hatalı giriş! Lütfen sayı girin.");
        }
    }

    public MenuOption GetMenuOption()
    {
        Console.WriteLine("1. Barkod Oluştur");
        Console.WriteLine("2. Barkod Oku");
        Console.WriteLine("3. Çıkış");

        while (true)
        {
            Console.Write("Seçiminizi yapın: ");
            if (int.TryParse(Console.ReadLine() ?? "", out int choice) && Enum.IsDefined(typeof(MenuOption), choice))
                return (MenuOption)choice;
            Console.WriteLine("Geçersiz seçenek!");
        }
    }
}

public enum MenuOption
{
    CreateBarcode = 1,
    ReadBarcode = 2,
    Exit = 3
}

public class BarcodeManager
{
    private InputService inputService = new();
    private const string FileName = "barkod.png";

    public void CreateBarcode()
    {
        long number = inputService.ReadInt("Barkot numarası giriniz: ");
        string data = number.ToString();

        var writer = new BarcodeWriter<SKBitmap>
        {
            Format = BarcodeFormat.CODE_128,
            Options = new ZXing.Common.EncodingOptions
            {
                Width = 300,
                Height = 100,
                Margin = 2
            },
            Renderer=new ZXing.SkiaSharp.Rendering.SKBitmapRenderer()
        };

        using SKBitmap bitmap = writer.Write(data);
        using var stream = File.OpenWrite(FileName);

        bitmap.Encode(stream, SKEncodedImageFormat.Png, 100);

        Console.WriteLine($"Barkod '{FileName}' olarak kaydedildi.");
    }

    public void ReadBarcode()
    {
        if (!File.Exists(FileName))
        {
            Console.WriteLine("Barkod dosyası bulunamadı!");
            return;
        }

        using var bitmap = SKBitmap.Decode(FileName);

        var reader = new BarcodeReaderGeneric(
            reader: new MultiFormatReader(),
            createBinarizer: ls => new HybridBinarizer(ls),
            createRGBLuminanceSource: (bytes, width, height, format) => new RGBLuminanceSource(bytes, width, height, format)
        )
        {
            Options = new DecodingOptions { TryHarder = true }
        };

        var result = reader.Decode(bitmap);

        if (result != null)
            Console.WriteLine("Barkod verisi: " + result.Text);
        else
            Console.WriteLine("Barkod bulunamadı!");
    }
}