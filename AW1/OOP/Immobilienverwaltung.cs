using AW1.OOP.Model;
using System;
using System.Collections.Generic;

namespace AW1.OOP
{
    public static class Immobilienverwaltung
    {
        public static void TaskC()
        {
            Immobilie i = MakeImmobilie();
            PrintImmobilie(i);
        }

        private static Immobilie MakeImmobilie()
        {
            Console.WriteLine("Anschrift?");
            string anschrift = Console.ReadLine();
            Console.WriteLine("Heizungsanlage?");
            string hz = Console.ReadLine();
            Console.WriteLine("Baujahr?");
            int jahr = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Grundstücksgröße?");
            int gr = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Wohnfläche?");
            int w = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Kellerfäche?");
            int k = Convert.ToInt32(Console.ReadLine());
            return new Immobilie(anschrift, hz, jahr, gr, w, k);
        }

        private static void PrintImmobilie(Immobilie i)
        {
            Console.WriteLine($"Anschrift: {i.GetAnschrift()}");
            Console.WriteLine($"Heizungsanalge: {i.GetHeizungsanlage()}");
            Console.WriteLine($"Baujahr: {i.GetBaujahr()}");
            Console.WriteLine($"Grundstücksgröße: {i.GetGrundstücksgröße()}");
            Console.WriteLine($"Wohnfläche: {i.GetWohnfläche()}");
            Console.WriteLine($"Kellerfläche: {i.GetWohnfläche()}");
            Console.WriteLine($"Gesamtgröße: {i.Gesamtgröße()}");
        }

        public static void TaskD()
        {
            List<Immobilie> list = new List<Immobilie>();
            list.Add(MakeImmobilie());
            Console.WriteLine("Zum beenden 'exit' eingeben.");
            while(Console.ReadLine() != "exit")
            {
                list.Add(MakeImmobilie());
                Console.WriteLine("Zum beenden 'exit' eingeben.");
            }

            Console.WriteLine();

            foreach(Immobilie i in list)
            {
                PrintImmobilie(i);
                Console.WriteLine();
            }
        }
    }
}
