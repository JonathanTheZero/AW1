using AW1.Referenzen.Models;
using System;

namespace AW1.Referenzen
{
    public static class Structs
    {
        public static void TaskB()
        {
            Rechnung r;
            r.Bestelldatum = "15.02.2021";
            r.Kundennummer = 12312;
            r.Nettopreis = 5000;
            r.Rechnungsnummer = 120;
            DruckeRechnung(r);
        }

        public static void TaskC()
        {
            Rechnung[] re = ErzeugeZufallsRechnungen();
            foreach (Rechnung r in re)
            {
                DruckeRechnung(r);
                Console.WriteLine();
            }
        }

        public static void TaskD()
        {
            Rechnung[] re = ErzeugeZufallsRechnungen();
            foreach (Rechnung r in re)
            {
                DruckeRechnung(r);
                Console.WriteLine();
            }
            for (int i = 0; i < re.Length; ++i)
                re[i] = Rabattiere(re[i], .05);

            Console.WriteLine("--------------------");
            Console.WriteLine("Nach Rabattierung:");
            Console.WriteLine("--------------------");

            foreach (Rechnung r in re)
            {
                DruckeRechnung(r);
                Console.WriteLine();
            }
        }

        public static void TaskE()
        {
            Rechnung[] re = ErzeugeZufallsRechnungen();
            for (int i = 0; i < re.Length; ++i)
            {
                DruckeRechnung(re[i]);
                RabattiereInPlace(ref re[i], .05);
                Console.WriteLine();
            }

            Console.WriteLine("--------------------");
            Console.WriteLine("Nach Rabattierung:");
            Console.WriteLine("--------------------");

            foreach (Rechnung r in re)
            {
                DruckeRechnung(r);
                Console.WriteLine();
            }
        }

        private static void DruckeRechnung(Rechnung r)
        {
            Console.WriteLine($"Bestelldatum:       {r.Bestelldatum}");
            Console.WriteLine($"Rechnungsnummer:    {r.Rechnungsnummer}");
            Console.WriteLine($"Kundennummer:       {r.Kundennummer}");
            Console.WriteLine($"Nettopreis:         {r.Nettopreis}");
        }

        private static Rechnung Rabattiere(Rechnung r, double rabatt)
        {
            r.Nettopreis *= (decimal)(1 - rabatt);
            return r;
        }

        private static void RabattiereInPlace(ref Rechnung r, double rabatt)
        {
            r.Nettopreis *= (decimal)(1 - rabatt);
        }

        private static Rechnung[] ErzeugeZufallsRechnungen()
        {
            Rechnung[] re = new Rechnung[10];
            Random rand = new Random();
            for (int i = 0; i < re.Length; ++i)
            {
                Rechnung r;
                r.Bestelldatum = (i != 9 ? "0" + (i + 1) : "10") + ".01.2021";
                r.Kundennummer = rand.Next();
                r.Nettopreis = (decimal)(rand.NextDouble() * 10000);
                r.Rechnungsnummer = rand.Next();
                re[i] = r;
            }
            return re;
        }
    }
}
