namespace AW1.Referenzen.Models
{
    public struct Rechnung
    {
        public int Rechnungsnummer;
        public int Kundennummer => Kunde.Kundennummer;
        public Kunde Kunde;
        public string Bestelldatum;
        public decimal Nettopreis;
    }
}
