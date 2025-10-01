namespace Alistirma
{
    class Program
    {
        private static void Main(string[] args)
        {
            static int Faktoriyel(int n)
            {
                if (n == 0)
                    return 1;
                else
                    return n * Faktoriyel(n - 1);

            }

            int[] sayilar = { 3, 7, 2, 9, 4 };
            int toplam = 0;

            foreach (int sayi in sayilar)
            {
                if (sayi % 2 == 0)
                {
                    toplam += sayi;
                }
                Console.WriteLine(sayi + "! : " + Faktoriyel(sayi));
            }
            if (toplam > 10)
            {
                Console.WriteLine(toplam + " -> 10'dan büyük");
            }
            else
            {
                Console.WriteLine(toplam + " -> 10'dan küçük");
            }

            string name = "Şemal Genç";
            Console.WriteLine(name.MakeUpperCase());
            Console.WriteLine(name.RemoveWhiteSpaces());
            Console.WriteLine(name.GetFirstCharacter());
        }
    }

    //Extension metotlar 
    public static class Deneme
    {
        public static string MakeUpperCase(this string name)
        {
            return name.ToUpper();
        }
        public static string RemoveWhiteSpaces(this string name)
        {
            string[] spaces = name.Split(" ");
            return string.Join("-", spaces);
        }
        public static string GetFirstCharacter(this string name)
        {
            return name.Substring(6, 3);
        }
    }
}