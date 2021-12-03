namespace AW1.Interfaces.UBModel
{
    public class Einkaufswagen : IInventurposten
    {
        public float Preis { get; set; }

        public float GetPreis()
        {
            return Preis;
        }
    }
}
