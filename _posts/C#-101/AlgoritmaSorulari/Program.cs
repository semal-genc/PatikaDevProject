namespace AlgoritmaSorulari
{
    class Program
    {
        static void Main(string[] args)
        {
            /*-Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin(n). Sonrasında kullanıcıdan n kelimeAdedi pozitif sayı girmesini isteyin. Kullanıcının girmiş olduğu sayılardan çift olanlar console'a yazdırın.*/
            int sayiAdedi1 = PozitifSayiAl("Pozitif bir sayı giriniz: ");

            int[] sayilar1 = new int[sayiAdedi1];
            Console.WriteLine(sayiAdedi1 + " pozitif sayı giriniz: ");
            for (int i = 0; i < sayiAdedi1; i++)
            {
                int num;
                while (true)
                {
                    Console.Write((i + 1) + ". sayı: ");
                    if (int.TryParse(Console.ReadLine(), out num) && num > 0)
                    {
                        sayilar1[i] = num;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Geçersiz giriş! Lütfen pozitif bir sayı girin.");
                    }
                }

            }
            Console.WriteLine(string.Join(" ", sayilar1.Where(n => n % 2 == 0)));



            /*-Bir konsol uygulamasında kullanıcıdan pozitif iki sayı girmesini isteyin (n, m). Sonrasında kullanıcıdan n kelimeAdedi pozitif sayı girmesini isteyin. Kullanıcının girmiş olduğu sayılardan m'e eşit yada tam bölünenleri console'a yazdırın.*/
            int sayiAdedi2 = PozitifSayiAl("Pozitif bir sayı giriniz: ");
            int bolen = PozitifSayiAl("Pozitif bir sayı giriniz: ");

            int[] sayilar2 = new int[sayiAdedi2];
            Console.WriteLine(sayiAdedi2 + " pozitif sayı giriniz: ");
            for (int i = 0; i < sayiAdedi2; i++)
            {
                int num = PozitifSayiAl((i + 1) + ". sayı: ");
                sayilar2[i] = num;
            }
            Console.WriteLine(string.Join(" ", sayilar2.Where(n => n == bolen || bolen % n == 0)));



            /*-Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin (n). Sonrasında kullanıcıdan n kelimeAdedi kelime girmesi isteyin. Kullanıcının girişini yaptığı kelimeleri sondan başa doğru console'a yazdırın.*/
            int kelimeAdedi = PozitifSayiAl("Pozitif bir sayı giriniz: ");

            string[] kelimeler = new string[kelimeAdedi];
            Console.WriteLine(kelimeAdedi + " tane kelime giriniz:");
            for (int i = 0; i < kelimeAdedi; i++)
            {
                Console.Write((i + 1) + ". kelime: ");
                kelimeler[i] = Console.ReadLine() ?? "";
            }
            kelimeler.Reverse().ToList().ForEach(Console.WriteLine);     
            // Array.Reverse(kelimeler);
            // foreach (string kelime in kelimeler)
            // {
            //     Console.WriteLine(kelime);
            // }



            /*-Bir konsol uygulamasında kullanıcıdan bir cümle yazması isteyin. Cümledeki toplam kelime ve harf sayısını console'a yazdırın.*/
            Console.WriteLine("Bir cümle giriniz: ");
            string cümle = Console.ReadLine() ?? "";
            string[] kelimelerCumle = cümle.Split(' ',StringSplitOptions.RemoveEmptyEntries);

            int harfSayisi = cümle.Count(char.IsLetter);
            for (int i = 0; i < kelimelerCumle.Length; i++)
            {
                Console.WriteLine((i + 1) + ". kelime: " + kelimelerCumle[i]);
            }
            Console.WriteLine("Harf sayısı: " + harfSayisi);
        }

        static int PozitifSayiAl(string mesaj)
        {
            while (true)
            {
                Console.Write(mesaj);
                if (int.TryParse(Console.ReadLine(), out int sayi) && sayi > 0)
                    return sayi;
                Console.WriteLine("Geçersiz giriş! Pozitif sayı giriniz.");
            }
        }
    }
}