namespace HayvanatBahcesi.Hayvanlar.Atgiller
{
    public class Zebra : Hayvan
    {
        private int cizgiSayisi;
        public Zebra(string turAdi, double agirlik, int yas, int cizgiSayisi) : base(turAdi, agirlik, yas)
        {
            this.cizgiSayisi = cizgiSayisi;
        }

        public int CizgiSayisi 
        { 
            get => cizgiSayisi; 
            set 
            { 
                if(cizgiSayisi>0)
                    cizgiSayisi = value;
                else
                    throw new ArgumentException("Çizgi sayısı 0'dan küçük olamaz!");
            } 
        }

        public override double GetDosage()
        {
            return Agirlik * 0.05;
        }

        public override string GetFeedSchedule()
        {
            return "Sabah 09:00, Öğlen 13:00, Akşam 20:00";
        }
    }
}