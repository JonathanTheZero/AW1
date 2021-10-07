using AW1.Beziehungen.Model;
using System;
using System.Text;

namespace AW1.Beziehungen
{
    public static class Konto
    {
        public static void TaskC()
        {
            Girokonto konto = new Girokonto("DE01 1234 5678 9000 1222 00", 7500m);
            Kunde kunde = new Kunde("Hans Meier", "Hauptstraße 1", konto);
            PrintKunde(kunde);
        }

        private static void PrintKunde(Kunde k)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine($"Name:           {k.Name}");
            Console.WriteLine($"Anschrift:      {k.Anschrift}");
            Console.WriteLine($"IBAN:           {k.Girokonto.IBAN}");
            Console.WriteLine($"Saldo:          {k.Girokonto.Saldo}€");
        }

        public static void TaskD()
        {
            Girokonto konto1 = new Girokonto("DE01 1234 5678 9000 1222 00", 7500m),
                konto2 = new Girokonto("DE02 7777 8888 1200 9944 00", 50000m),
                konto3 = new Girokonto("DE02 7777 8888 1200 9944 01", 112.45m);
            Kunde2 kunde = new Kunde2("Hans Meier", "Hauptstraße 1", konto1, konto2, konto3);
            PrintKunde2(kunde);
        }

        private static void PrintKunde2(Kunde2 k)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine($"Name:           {k.Name}");
            Console.WriteLine($"Anschrift:      {k.Anschrift}");
            for (int i = 0; i < k.Girokonten.Count; ++i)
            {
                Console.WriteLine($"IBAN_{i}:         {k.Girokonten[i].IBAN}");
                Console.WriteLine($"Saldo_{i}:        {k.Girokonten[i].Saldo}€");
            }
        }
    }
}
