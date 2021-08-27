namespace AW1.Vererbung.Model
{
    public class Kunde : Person
    {
        private int kundenNr;

        public Kunde(string name, int nummer) : base(name)
        {
            SetKundenNr(nummer);
        }

        public int GetKundenNr() => kundenNr;

        public void SetKundenNr(int nr)
        {
            kundenNr = nr;
        }
    }
}
