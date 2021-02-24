using AW1.Referenzen.Models;
using System;

namespace AW1.Referenzen
{
    public static class Structs
    {
        public static void TaskB()
        {
            Rechnung r = new Rechnung();
            r.Bestelldatum = "15.02.2021";
            r.Kunde.Kundennummer = 12312;
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

        public static void TaskF()
        {
            Rechnung r;
            r.Kunde.Kundennummer = 10;
            r.Kunde.Nachname = "Schmidt";
            r.Kunde.Vorname = "Peter";
            r.Kunde.Adresse.Hausnummer = 10;
            r.Kunde.Adresse.Plz = 45123;
            r.Kunde.Adresse.Stadt = "Essen";
            r.Kunde.Adresse.Straße = "Hauptstraße";
            r.Nettopreis = 5200;
            r.Rechnungsnummer = 17;
            r.Bestelldatum = "17.02.2021";
            Console.WriteLine($"Bestelldatum:       {r.Bestelldatum}");
            Console.WriteLine($"Rechnungsnummer:    {r.Rechnungsnummer}");
            Console.WriteLine($"Nettopreis:         {r.Nettopreis}");
            Console.WriteLine($"Kunde:");
            Console.WriteLine($"    Vorname:        {r.Kunde.Vorname}");
            Console.WriteLine($"    Nachname:       {r.Kunde.Nachname}");
            Console.WriteLine($"    Kundennummer:   {r.Kunde.Kundennummer}");
            Console.WriteLine($"    Adresse:");
            Console.WriteLine($"        Straße:     {r.Kunde.Adresse.Straße}");
            Console.WriteLine($"        Hausnummer: {r.Kunde.Adresse.Hausnummer}");
            Console.WriteLine($"        PLZ:        {r.Kunde.Adresse.Plz}");
            Console.WriteLine($"        Stadt:      {r.Kunde.Adresse.Stadt}");
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
                Rechnung r = new Rechnung();
                r.Bestelldatum = (i != 9 ? "0" + (i + 1) : "10") + ".01.2021";
                r.Kunde.Kundennummer = rand.Next();
                r.Nettopreis = (decimal)(rand.NextDouble() * 10000);
                r.Rechnungsnummer = rand.Next();
                re[i] = r;
            }
            return re;
        }
    }
}
