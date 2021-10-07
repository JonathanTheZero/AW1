using System.Collections.Generic;
using System.Linq;

namespace AW1.Beziehungen.Model
{
    public class Verwaltung
    {
        public List<Artikel> Lagerbestand { get; private set; } = new List<Artikel>();
        public int Gesamtzahl => Lagerbestand.Count;
        public int Gesamtstückzahl => Lagerbestand.Sum(e => e.Anzahl);
        public decimal Gesamtwert => Lagerbestand.Sum(e => e.Gesamtpreis);
        //public decimal _Gesamtwert
        //{
        //    get
        //    {
        //        decimal result = 0;
        //        foreach (Artikel a in Lagerbestand)
        //        {
        //            result += a.Gesamtpreis;
        //        }
        //        return result;
        //    }
        //}
        public Verwaltung()
        {

        }
    }
}
