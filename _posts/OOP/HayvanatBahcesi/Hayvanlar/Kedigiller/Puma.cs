namespace HayvanatBahcesi.Hayvanlar.Kedigiller
{
    public class Puma : Hayvan
    {
        private int ziplamaYuksekligi;
        public Puma(string turAdi, double agirlik, int yas, int ziplamaYuksekligi) : base(turAdi, agirlik, yas)
        {
            this.ziplamaYuksekligi = ziplamaYuksekligi;
        }

        public int ZiplamaYuksekligi
        {
            get => ziplamaYuksekligi;
            set
            {
                if (ziplamaYuksekligi > 0)
                    ziplamaYuksekligi = value;
                else
                    throw new ArgumentException("Zıplama yüksekliği  0'dan küçük olamaz!");
            }
        }

        public override double GetDosage()
        {
            return Agirlik * 0.7;
        }

        public override string GetFeedSchedule()
        {
            return "Öğlen 12:00, Akşam 18:00, Gece 23:00";
        }
    }
}