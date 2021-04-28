using AW1.Models;
using System;

namespace AW1.Suchen
{
    public static class BinarySearch
    {
        public static void TaskB()
        {
            _Rechnung[] re = ErzeugeZufallsRechnung3();
            Console.WriteLine("Welche Zahl suchen Sie?");
            Console.WriteLine(FindeErsteRechnungBinaer(Convert.ToDecimal(Console.ReadLine()), re, true));
        }

        public static void TaskC()
        {
            _Rechnung[] re = ErzeugeZufallsRechnung3();
            Console.WriteLine("Welche Zahl suchen Sie?");
            Console.WriteLine(RecursiveBinary(Convert.ToDecimal(Console.ReadLine()), re));
        }

        private static int FindeErsteRechnungBinaer(decimal nettopreis, _Rechnung[] re, bool debugMode = false)
        {
            int firstIndex = 0,
                lastIndex = re.Length - 1,
                steps = 1;
            while (firstIndex <= lastIndex)
            {
                int middleIndex = (lastIndex + firstIndex) / 2;
                _Rechnung r = re[middleIndex];
                if (r.Nettopreis == nettopreis)
                {
                    if (debugMode)
                        Console.WriteLine($"Element nach {steps} Schritten gefunden");
                    return middleIndex;
                }
                if (r.Nettopreis < nettopreis)
                    firstIndex = middleIndex + 1;
                else if (r.Nettopreis > nettopreis)
                    lastIndex = middleIndex - 1;
                steps++;
            }
            Console.WriteLine($"Nettopreis von {nettopreis} wurde nicht gefunden.");
            return -1;
        }

        private static int RecursiveBinary(decimal nettopreis, _Rechnung[] re)
        {
            return RecursiveBinary(nettopreis, re, 0, re.Length - 1, 1);
        }

        private static int RecursiveBinary(decimal nettopreis, _Rechnung[] re, int firstIndex, int lastIndex, int steps)
        {
            int middleIndex = (lastIndex + firstIndex) / 2;
            _Rechnung r = re[middleIndex];
            if (r.Nettopreis == nettopreis)
            {
                Console.WriteLine($"Element nach {steps} Schritten gefunden");
                return middleIndex;
            }
            else if (r.Nettopreis < nettopreis)
                return RecursiveBinary(nettopreis, re, middleIndex + 1, lastIndex, steps + 1);
            else // if (r.Nettopreis > nettopreis)
                return RecursiveBinary(nettopreis, re, firstIndex, middleIndex - 1, steps + 1);
        }

        public static _Rechnung[] ErzeugeZufallsRechnung3()
        {
            _Rechnung[] re = new _Rechnung[1000];
            Random rand = new Random();
            for (int i = 0; i < re.Length; ++i)
            {
                _Rechnung r;
                r.Bestelldatum = "15.02.2021";
                r.Kundennummer = rand.Next();
                r.Nettopreis = i;
                r.Rechnungsnummer = rand.Next(20000);
                re[i] = r;
            }
            return re;
        }
    }
}
