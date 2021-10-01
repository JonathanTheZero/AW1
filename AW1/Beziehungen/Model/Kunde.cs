using System.Collections.Generic;

namespace AW1.Beziehungen.Model
{
    public class Kunde
    {
        public string Name { get; set; }
        public string Anschrift { get; set; }
        public Girokonto Girokonto { get; private set; }
        public Kunde(string name, string anschrift, Girokonto konto)
        {
            Name = name;
            Anschrift = anschrift;
            Girokonto = konto;
        }
    }

    public class Kunde2
    {
        public string Name { get; set; }
        public string Anschrift { get; set; }
        public List<Girokonto> Girokonten { get; private set; } = new List<Girokonto>();
        public Kunde2(string name, string anschrift, params Girokonto[] konten)
        {
            Name = name;
            Anschrift = anschrift;
            Girokonten.AddRange(konten);
        }
    }
}
