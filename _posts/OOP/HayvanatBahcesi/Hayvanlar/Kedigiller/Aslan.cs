namespace HayvanatBahcesi.Hayvanlar.Kedigiller
{
    public class Aslan : Hayvan
    {
        private int gurultuSiddeti;
        public Aslan(string turAdi, double agirlik, int yas, int gurultuSiddeti) : base(turAdi, agirlik, yas)
        {
            this.gurultuSiddeti = gurultuSiddeti;
        }

        public int GurultuSiddeti 
        { 
            get => gurultuSiddeti; 
            set 
            { 
                if(gurultuSiddeti>0)
                    gurultuSiddeti = value;
                else 
                    throw new ArgumentException("Gürültü şiddeti 0'dan küçük olamaz!");
            } 
        }

        public override double GetDosage()
        {
            return Agirlik * 0.1;
        }

        public override string GetFeedSchedule()
        {
            return "Sabah 08:00, Öğlen 12:00, Akşam 18:00, Gece 23:00";
        }
    }
}