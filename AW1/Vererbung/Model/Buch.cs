using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AW1.Vererbung.Model
{
    public class Buch: Produkt
    {
        public string ISBN { get; set; }
        public string Verlag { get; set; }
        public int Seitenzahl { get; set; }
        public Buch(int id, decimal preis, string desc, string isbn, string verlag, int seitenzahl): base(id, preis, desc)
        {
            ISBN = isbn;
            Verlag = verlag;
            Seitenzahl = seitenzahl;
        }
        public override string ToString()
        {
            return base.ToString() + $"ISBN: {ISBN}\nVerlag: {Verlag}\nSeitenzahl: {Seitenzahl} Seiten";
        }
    }
}
