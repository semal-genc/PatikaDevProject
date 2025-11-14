namespace HayvanatBahcesi.Hayvanlar.Kedigiller
{
    public class Kaplan : Hayvan
    {
        private int avlanmaHizi;
        public Kaplan(string turAdi, double agirlik, int yas, int avlanmaHizi) : base(turAdi, agirlik, yas)
        {
            this.avlanmaHizi = avlanmaHizi;
        }

        public int AvlanmaHizi
        {
            get => avlanmaHizi;
            set
            {
                if (avlanmaHizi > 0)
                    avlanmaHizi = value;
                else
                    throw new ArgumentException("Avlanmaz hızı 0'dan küçük olamaz!");
            }
        }

        public override double GetDosage()
        {
            return Agirlik * 0.09;
        }

        public override string GetFeedSchedule()
        {
            return "Sabah 09:00, Öğlen 13:00, Akşam 19:00, Gece 23:00";
        }
    }
}