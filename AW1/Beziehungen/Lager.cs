using AW1.Beziehungen.Model;
using System;
using System.Text;

namespace AW1.Beziehungen
{
    public static class Lager
    {
        public static void TaskB()
        {
            Verwaltung verwaltung = new Verwaltung();
            FillList(verwaltung);
            PrintVerwaltung(verwaltung);
        }

        private static void FillList(Verwaltung v)
        {
            Artikel a1 = new Artikel(1, "Regal", 20, 199.99m),
                a2 = new Artikel(2, "Sofa", 5, 499.99m),
                a3 = new Artikel(3, "NVIDIA RTX 3080 Ti", 0, 2499.99m),
                a4 = new Artikel(4, "NVIDIA RTX 3070 Ti", 2, 1999.99m),
                a5 = new Artikel(5, "Frischkäse", 200, 1.49m);
            v.Lagerbestand.Add(a1);
            v.Lagerbestand.Add(a2);
            v.Lagerbestand.Add(a3);
            v.Lagerbestand.Add(a4);
            v.Lagerbestand.Add(a5);
        }

        private static void PrintVerwaltung(Verwaltung v)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine("Verwaltung:");
            Console.WriteLine($"Gesamtanzahl:     {v.Gesamtzahl} verschiedene Artikel");
            Console.WriteLine($"Gesamtstückzahl:  {v.Gesamtstückzahl} Stück");
            Console.WriteLine($"Gesamtwert:       {v.Gesamtwert}€");
            Console.WriteLine();
            Console.WriteLine("Aufschlüsselung nach Artikel:");
            foreach (Artikel a in v.Lagerbestand)
            {
                Console.WriteLine($"ID:               {a.ID}");
                Console.WriteLine($"Name:             {a.Name}");
                Console.WriteLine($"Einzelpreis:      {a.Einzelpreis}€");
                Console.WriteLine($"Vorrätige Anzahl: {a.Anzahl} Stück");
                Console.WriteLine($"Gesamtpreis:      {a.Gesamtpreis}€");
                Console.WriteLine();
            }
        }
    }
}
