namespace AW1.Vererbung.Model
{
    public abstract class Produkt
    {
        public int ID { get; set; }
        public decimal Preis { get; set; }
        public string Beschreibung { get; set; }
        public Produkt(int id, decimal preis, string desc)
        {
            ID = id;
            Preis = preis;
            Beschreibung = desc;
        }

        public override string ToString()
        {
            return $"ID: {ID}\nPreis: {Preis}€\nBeschreibung: {Beschreibung}\n";
        }
    }
}
