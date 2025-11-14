using HayvanatBahcesi.Hayvanlar.Atgiller;
using HayvanatBahcesi.Hayvanlar.Kedigiller;
using HayvanatBahcesi.Hayvanlar.Kemirgenler;

namespace HayvanatBahcesi
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            At at1 = new At("Arap Atı", 400, 5, 12);
            At at2 = new At("İngiliz Atı", 450, 6, 6);
            Esek esek1 = new Esek("Anadolu Eşeği", 200, 7, 500.50);
            Zebra zebra1 = new Zebra("Zebra", 300, 4, 370);

            Kaplan kaplan1 = new Kaplan("Bengal Kaplanı", 220, 5, 40);
            Aslan aslan1 = new Aslan("Afrika Aslanı", 190, 7, 60);
            Puma puma1 = new Puma("Puma", 70, 4, 7);

            Sican sican1 = new Sican("Ev Faresi", 0.2, 1, 1.1f);
            Kunduz kunduz1 = new Kunduz("Kunduz", 15, 3, 20);
            Sincap sincap1 = new Sincap("Kırmızı Sincap", 0.5, 2, 14);

            Console.WriteLine("\n************************************************* Atgiller *************************************************\n");

            Console.WriteLine($"{at1.TurAdi} için dozaj: {at1.GetDosage()}, Yem Saati: {at1.GetFeedSchedule()}, Gündüz Aktivitesi: {at1.GunduzAktivitesi} saat");
            Console.WriteLine($"{at2.TurAdi} için dozaj: {at2.GetDosage()}, Yem Saati: {at2.GetFeedSchedule()}, Gündüz Aktivitesi: {at2.GunduzAktivitesi} saat");
            Console.WriteLine($"{esek1.TurAdi} için dozaj: {esek1.GetDosage()}, Yem Saati: {esek1.GetFeedSchedule()}, Yük Taşıma Kapasitesi: {esek1.YukTasimaKapasitesi} kg");
            Console.WriteLine($"{zebra1.TurAdi} için dozaj: {zebra1.GetDosage()}, Yem Saati: {zebra1.GetFeedSchedule()}, Çizgi Sayısı: {zebra1.CizgiSayisi}");

            Console.WriteLine("\n************************************************* Kedigiller *************************************************\n");

            Console.WriteLine($"{kaplan1.TurAdi} için dozaj: {kaplan1.GetDosage()}, Yem Saati: {kaplan1.GetFeedSchedule()}, Avlanma Hızı: {kaplan1.AvlanmaHizi} km/s");
            Console.WriteLine($"{aslan1.TurAdi} için dozaj: {aslan1.GetDosage()}, Yem Saati: {aslan1.GetFeedSchedule()}, Gürültü Şiddeti: {aslan1.GurultuSiddeti} desibel");
            Console.WriteLine($"{puma1.TurAdi} için dozaj: {puma1.GetDosage()}, Yem Saati: {puma1.GetFeedSchedule()}, Zıplama Yüksekliği: {puma1.ZiplamaYuksekligi} m");

            Console.WriteLine("\n************************************************* Kemirgenler *************************************************\n");

            Console.WriteLine($"{sican1.TurAdi} için dozaj: {sican1.GetDosage()}, Yem Saati: {sican1.GetFeedSchedule()}, Kuyruk Uzunluğu: {sican1.KuyrukUzunugu} cm");
            Console.WriteLine($"{kunduz1.TurAdi} için dozaj: {kunduz1.GetDosage()}, Yem Saati: {kunduz1.GetFeedSchedule()}, Ağaç Kesme Kapasitesi: {kunduz1.AgacKesmeKapasitesi} cm/s");
            Console.WriteLine($"{sincap1.TurAdi} için dozaj: {sincap1.GetDosage()}, Yem Saati: {sincap1.GetFeedSchedule()}, Atlama Mesafesi: {sincap1.AtlamaMesafesi} m");
        }
    }
}