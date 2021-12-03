using System;

namespace AW1.Interfaces.UBModel
{
    public abstract class Ware : IRechnungsposition, IInventurposten, IComparable
    {
        public float Preis { get; set; }
        public string Name { get; set; }

        float IInventurposten.GetPreis()
        {
            return Preis;
        }

        float IRechnungsposition.GetPreis()
        {
            return Preis * 1.17f;
        }

        public int CompareTo(Ware obj)
        {
            return Preis.CompareTo(obj.Preis);
        }

        public int CompareTo(object obj)
        {
            if (obj is Ware w)
                return CompareTo(w);
            return 1;
        }

        public Ware(float p, string n)
        {
            Preis = p;
            Name = n;
        }
    }
}
