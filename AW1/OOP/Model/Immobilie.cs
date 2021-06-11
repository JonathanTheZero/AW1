namespace AW1.OOP.Model
{
    public class Immobilie
    {
        private string anschrift, heizungsanlage;
        private int baujahr, grundstücksgröße, wohnfläche, kellerfläche;

        public Immobilie(string anschrift, string heizungsanlage, int baujahr, int grundstücksgröße, int wohnfläche, int kellerfläche)
        {
            this.anschrift = anschrift;
            this.heizungsanlage = heizungsanlage;
            this.baujahr = baujahr;
            this.grundstücksgröße = grundstücksgröße;
            this.wohnfläche = wohnfläche;
            this.kellerfläche = kellerfläche;
        }

        public int Gesamtgröße() => wohnfläche + kellerfläche;

        public string GetAnschrift() => anschrift;
        public void SetAnschrift(string anschrift)
        {
            this.anschrift = anschrift;
        }
        public string GetHeizungsanlage() => heizungsanlage;
        public void SetHeizungsanlage(string heizungsanlage)
        {
            this.heizungsanlage = heizungsanlage;
        }
        public int GetBaujahr() => baujahr;
        public void SetBaujahr(int baujahr)
        {
            this.baujahr = baujahr;
        }
        public int GetGrundstücksgröße() => grundstücksgröße;
        public void SetGrundstücksgröße(int grundstücksgröße)
        {
            this.grundstücksgröße = grundstücksgröße;
        }
        public int GetWohnfläche() => wohnfläche;
        public void SetWohnfläche(int wohnfläche)
        {
            this.wohnfläche = wohnfläche;
        }
        public int GetKellerfläche() => kellerfläche;
        public void SetKellerfläche(int kellerfläche)
        {
            this.kellerfläche = kellerfläche;
        }
    }

    public class _Immobilie
    {
        private int grundstücksgröße;

        public string Anschrift { get; set; }
        public string Heizungsanlage { get; set; }
        public int Baujahr { get; set; }
        public int Grundstücksgröße
        {
            get => grundstücksgröße;
            set => grundstücksgröße = value;
        }
        public int Wohnfläche { get; set; }
        public int Kellerfläche { get; set; }
        public int Gesamtfläche => Kellerfläche + Wohnfläche;
        public _Immobilie() { }
    }
}
