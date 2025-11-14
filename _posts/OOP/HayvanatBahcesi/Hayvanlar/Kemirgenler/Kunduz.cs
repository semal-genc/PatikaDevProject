namespace HayvanatBahcesi.Hayvanlar.Kemirgenler
{
    public class Kunduz : Hayvan
    {
        private int agacKesmeKapasitesi;
        public Kunduz(string turAdi, double agirlik, int yas, int agacKesmeKapasitesi) : base(turAdi, agirlik, yas)
        {
            this.agacKesmeKapasitesi = agacKesmeKapasitesi;
        }

        public int AgacKesmeKapasitesi
        {
            get => agacKesmeKapasitesi;
            set
            {
                if (agacKesmeKapasitesi > 0)
                    agacKesmeKapasitesi = value;
                else
                    throw new ArgumentException("Ağaç kesme kapasitesi 0'da küçük olamaz!");
            }
        }

        public override double GetDosage()
        {
            return Agirlik * 0.4;
        }

        public override string GetFeedSchedule()
        {
            return "Sabah 08:00, Akşam 21:00";
        }
    }
}