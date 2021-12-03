using AW1.Interfaces.UBModel;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AW1.Interfaces
{
    public static class UBInterfaces
    {
        public static void TaskC()
        {
            List<IRechnungsposition> r = new List<IRechnungsposition>()
            {
                new Lebensmittel(10, "Apfel"),
                new Lebensmittel(12, "Schokolade"),
                new Spielwaren(100, "Lego"),
                new Spielwaren(75, "Spiel")
            };
            List<IInventurposten> i = new List<IInventurposten>()
            {
                new Lebensmittel(10, "Apfel"),
                new Lebensmittel(12, "Schokolade"),
                new Spielwaren(100, "Lego"),
                new Spielwaren(75, "Spiel")
            };
            Console.WriteLine($"IRechnungsposition Summe: {r.Sum(e => e.GetPreis())}");
            Console.WriteLine($"IInventurposten Summe: {i.Sum(e => e.GetPreis())}");
        }

        public static void TaskD()
        {
            List<Ware> w = new List<Ware>()
            {
                new Lebensmittel(10, "Apfel"),
                new Lebensmittel(12, "Schokolade"),
                new Spielwaren(100, "Lego"),
                new Spielwaren(75, "Spiel")
            };
            w.Sort();

            for (int i = 0; i < w.Count; ++i)
            {
                Console.WriteLine($"[{i}]: {w[i].Name} - {w[i].Preis}");
            }
        }
    }
}
