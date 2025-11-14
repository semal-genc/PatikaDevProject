namespace HayvanatBahcesi.Hayvanlar.Atgiller
{
    public class Esek : Hayvan
    {
        private double yukTasimaKapasitesi;
        public Esek(string turAdi, double agirlik, int yas, double yukTasimaKapasitesi) : base(turAdi, agirlik, yas)
        {
            this.yukTasimaKapasitesi = yukTasimaKapasitesi;
        }

        public double YukTasimaKapasitesi 
        { 
            get => yukTasimaKapasitesi; 
            set  
            {
                if(yukTasimaKapasitesi>0)
                    yukTasimaKapasitesi = value;
                else
                    throw new ArgumentException("Yük Kapasitesi 0'dan küçük olamaz!");
            } 
        }

        public override double GetDosage()
        {
            return Agirlik * 0.07;
        }

        public override string GetFeedSchedule()
        {
            return "Sabah 07:00, Öğlen 13:30, Akşam 20:00";
        }
    }
}