using AW1.Vererbung.Model;
using System;

namespace AW1.Vererbung
{
    public static class PersonenVerwaltung
    {
        public static void TaskA()
        {
            Kunde a = new Kunde("Peter", 1),
                b = new Kunde("Tina", 2);
            Mitarbeiter c = new Mitarbeiter("Hans", "Sales & Marketing"),
                d = new Mitarbeiter("Julia", "Customer Service");
            PrintKunde(a);
            PrintKunde(b);
            PrintMitarbeiter(c);
            PrintMitarbeiter(d);
            a.SetKundenNr(15);
            Console.WriteLine("\nKundennummer geändert\n");
            PrintKunde(a);
        }

        private static void PrintKunde(Kunde k)
        {
            Console.WriteLine("Kunde:");
            Console.WriteLine("---------------");
            Console.WriteLine($"Name: {k.GetName()}");
            Console.WriteLine($"KundenNummer: {k.GetKundenNr()}");
            Console.WriteLine("---------------");
        }

        private static void PrintMitarbeiter(Mitarbeiter m)
        {
            Console.WriteLine("Mitarbeiter:");
            Console.WriteLine("---------------");
            Console.WriteLine($"Name: {m.GetName()}");
            Console.WriteLine($"Abteilung: {m.GetAbteilung()}");
            Console.WriteLine("---------------");
        }
    }
}
