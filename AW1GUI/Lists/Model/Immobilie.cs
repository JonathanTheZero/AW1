namespace AW1GUI.Lists.Model
{
    public class Immobilie
    {
        public string Straße { get; set; }
        public int Hausnummer { get; set; }
        public int PLZ { get; set; }
        public string Stadt { get; set; }
        public int Baujahr { get; set; }
        public double Grundstücksgröße { get; set; }
        public double Wohnfläche { get; set; }
        public double Kellerfläche { get; set; }
        public string Heizungsanlage { get; set; }
        public double Gesamtwohnfläche => Wohnfläche + Kellerfläche;

        public override string ToString()
        {
            return $"{PLZ} - {Stadt}: {Wohnfläche} m²";
        }

        public string String => ToString();
    }
}
