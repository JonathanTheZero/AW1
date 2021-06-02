namespace AW1.Models
{
    public struct Rechnung
    {
        public int Rechnungsnummer;
        public int Kundennummer => Kunde.Kundennummer;
        public Kunde Kunde;
        public string Bestelldatum;
        public decimal Nettopreis;
    }

    public struct _Rechnung
    {
        public int Rechnungsnummer;
        public int Kundennummer;
        public string Bestelldatum;
        public decimal Nettopreis;
    }
}
