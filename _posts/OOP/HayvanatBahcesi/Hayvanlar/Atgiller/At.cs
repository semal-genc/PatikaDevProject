namespace HayvanatBahcesi.Hayvanlar.Atgiller
{
    public class At : Hayvan
    {
        private int gunduzAktivitesi;
        public At(string turAdi, double agirlik, int yas, int gunduzAktivitesi) : base(turAdi, agirlik, yas)
        {
            this.gunduzAktivitesi = gunduzAktivitesi;
        }

        public int GunduzAktivitesi 
        { 
            get => gunduzAktivitesi; 
            set  
            {
                if(gunduzAktivitesi>0)
                    gunduzAktivitesi = value;
                else
                    throw new ArgumentException("Gündüz aktivitesi 0'dan küçük olamaz!");
            } 
        }

        public override double GetDosage()
        {
            return Agirlik * 0.06;
        }

        public override string GetFeedSchedule()
        {
            return "Sabah 08:00, Öğlen 12:00, Akşam 18:00";
        }
    }
}