using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AW1.Vererbung.Model
{
    public class CD: Produkt
    {
        public string Hersteller { get; set; }
        public string Genre { get; set; }
        public double Dauer { get; set; }
        public CD(int id, decimal preis, string desc, string hersteller, string genre, double dauer): base(id,preis, desc)
        {
            Hersteller = hersteller;
            Genre = genre;
            Dauer = dauer;
        }

        public override string ToString()
        {
            return base.ToString() + $"Hersteller: {Hersteller}\nGenre {Genre}\nDauer: {Dauer} Minuten";
        }
    }
}
