internal class Program
{
    private static void Main(string[] args)
    {
        /*Klavyeden girilen cümle içerisindeki sesli harfleri bir dizi içerisinde saklayan ve dizinin elemanlarını sıralayan programı yazınız.*/
        char[] sesliHarfler = { 'a', 'e', 'ı', 'i', 'o', 'ö', 'u', 'ü' };
        Console.WriteLine("Bir cümle giriniz: ");
        string cumle = Console.ReadLine() ?? "";
        var harfler = cumle.Where(char.IsLetter);

        var ortak = harfler.Intersect(sesliHarfler);
        Console.WriteLine($"Cümle içerisindeki sesli harfler: {string.Join(", ", ortak)}");
    }
}