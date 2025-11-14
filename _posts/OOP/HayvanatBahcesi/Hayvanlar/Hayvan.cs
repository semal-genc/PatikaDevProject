namespace HayvanatBahcesi.Hayvanlar
{
    public abstract class Hayvan
    {
        private string turAdi;
        private double agirlik;
        private int yas;
        public abstract double GetDosage();
        public abstract string GetFeedSchedule();

        public Hayvan(string turAdi, double agirlik, int yas)
        {
            this.turAdi = turAdi;
            this.agirlik = agirlik;
            this.yas = yas;
        }

        public string TurAdi { get => turAdi; set => turAdi = value; }
        public double Agirlik 
        { 
            get => agirlik; 
            set 
            {
                if (agirlik > 0)
                    agirlik = value;
                else
                    throw new ArgumentException("Ağırlık 0 ve 0'dan küçük olamaz!");
            } 
        }
        public int Yas 
        { 
            get => yas; 
            set 
            { 
                if (yas > 0)
                    yas = value;
                else
                    throw new ArgumentException("Yaş 0'dan küçük olamaz");
            } 
        }
    }
}