using AW1.Referenzen.Models;
using System;

namespace AW1.Suchen
{
    public static class LinearSearch
    {
        public static void TaskA()
        {
            _Rechnung[] re = ErzeugeZufallsRechnung2();
            foreach (_Rechnung r in re)
            {
                DruckeRechnung(r);
            }
        }

        /*
         * Loopen und bei jedem Objekt ein == Vergleich nach Wert 
         * Return type: Nullable<_Rechnung> oder Index bzw -1
         * Parameter: Nettobetrag, Array
         * Andere option: void mit out Parameter
         */
        public static void TaskC()
        {
            _Rechnung[] re = ErzeugeZufallsRechnung2();
            Console.WriteLine("Gesuchter Nettobetrag?");
            int nettobetrag = Convert.ToInt32(Console.ReadLine()),
                index = FindeErsteRechnungMitBetrag(nettobetrag, re);
            Console.WriteLine($"Index: {index}");
        }

        //Index des ersten Elements, sonst -1
        private static int FindeErsteRechnungMitBetrag(decimal nettobetrag, _Rechnung[] re)
        {
            for (int i = 0; i < re.Length; ++i)
            {
                if (re[i].Nettopreis == nettobetrag)
                    return i;
            }
            return -1;
        }

        private static _Rechnung[] ErzeugeZufallsRechnung2()
        {
            _Rechnung[] re = new _Rechnung[1000];
            Random rand = new Random();
            for (int i = 0; i < re.Length; ++i)
            {
                _Rechnung r;
                r.Bestelldatum = "15.02.2021";
                r.Kundennummer = rand.Next();
                r.Nettopreis = rand.Next();
                r.Rechnungsnummer = rand.Next(20000);
                re[i] = r;
            }
            return re;
        }

        private static void DruckeRechnung(_Rechnung r)
        {
            Console.WriteLine("--------------------");
            Console.WriteLine($"Bestelldatum:       {r.Bestelldatum}");
            Console.WriteLine($"Rechnungsnummer:    {r.Rechnungsnummer}");
            Console.WriteLine($"Kundennummer:       {r.Kundennummer}");
            Console.WriteLine($"Nettopreis:         {r.Nettopreis}");
            Console.WriteLine("--------------------\n");
        }
    }
}
