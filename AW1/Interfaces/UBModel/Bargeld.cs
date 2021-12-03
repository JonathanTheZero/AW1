namespace AW1.Interfaces.UBModel
{
    public class Bargeld : IRechnungsposition
    {
        public float Preis { get; set; }

        public float GetPreis()
        {
            return Preis;
        }
    }
}
