using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AW1.Beziehungen.Model
{
    public class Artikel
    {
        public int ID { get; private set; }
        public string Name { get; set; }
        public int Anzahl { get; set; }
        public decimal Einzelpreis { get; set; }
        public decimal Gesamtpreis => Anzahl * Einzelpreis;
        public Artikel(int id, string name, int anzahl, decimal einzelpreis)
        {
            ID = id;
            Name = name;
            Anzahl = anzahl;
            Einzelpreis = einzelpreis;
        }
    }
}
