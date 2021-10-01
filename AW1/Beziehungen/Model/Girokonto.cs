namespace AW1.Beziehungen.Model
{
    public class Girokonto
    {
        public string IBAN { get; private set; }
        public decimal Saldo { get; set; }
        public Girokonto(string iban, decimal saldo)
        {
            IBAN = iban;
            Saldo = saldo;
        }
    }
}
