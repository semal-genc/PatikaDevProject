namespace HayvanatBahcesi.Hayvanlar.Kemirgenler
{
    public class Sican : Hayvan
    {
        private float kuyrukUzunugu;
        public Sican(string turAdi, double agirlik, int yas, float kuyrukUzunugu) : base(turAdi, agirlik, yas)
        {
            this.kuyrukUzunugu = kuyrukUzunugu;
        }

        public float KuyrukUzunugu
        {
            get => kuyrukUzunugu;
            set
            {
                if (kuyrukUzunugu > 0)
                    kuyrukUzunugu = value;
                else
                    throw new ArgumentException("Kuyruk uzunluğu 0'dan küçük olamaz!");
            }
        }

        public override double GetDosage()
        {
            return Agirlik * 5.5;
        }

        public override string GetFeedSchedule()
        {
            return "Sabah 08:00,Akşam 23:00";
        }
    }
}