namespace HayvanatBahcesi.Hayvanlar.Kemirgenler
{
    public class Sincap : Hayvan
    {
        private int atlamaMesafesi;
        public Sincap(string turAdi, double agirlik, int yas, int atlamaMesafesi) : base(turAdi, agirlik, yas)
        {
            this.atlamaMesafesi = atlamaMesafesi;
        }

        public int AtlamaMesafesi
        {
            get => atlamaMesafesi;
            set
            {
                if (atlamaMesafesi > 0)
                    atlamaMesafesi = value;
                else
                    throw new ArgumentException("Atlama mesafesi 0!dan küçük olamaz!");
            }
        }

        public override double GetDosage()
        {
            return Agirlik * 6;
        }

        public override string GetFeedSchedule()
        {
            return "Sabah 08:00, Akşam 23:00";
        }
    }
}