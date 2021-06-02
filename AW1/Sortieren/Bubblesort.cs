using AW1.Models;
using AW1.Suchen;
using System;

namespace AW1.Sortieren
{
    public static class Bubblesort
    {
        public static void TaskA()
        {
            int[] values = { 10, 8, 14, 1, -4, 12, -9, 12, 0, 1 };

            BubbleSort(values, true);

            Console.WriteLine("BubbleSort wurde erfolgreich ausgeführt");
            for (int i = 0; i < values.Length; i++)
                Console.WriteLine(i + ": " + values[i]);
        }

        private static void BubbleSort(int[] arr, bool printSwaps = false)
        {
            int swaps = 0;
            for (int _ = 0; _ < arr.Length; _++)
            {
                for (int i = 0; i < arr.Length - 1; i++)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        int temp = arr[i + 1];
                        arr[i + 1] = arr[i];
                        arr[i] = temp;
                        swaps++;
                    }
                }
            }
            if (printSwaps)
            {
                Console.WriteLine($"Swaps durchgeführt: {swaps}");
            }
        }

        //Zusatzaufgabe 1
        public static void TaskB()
        {
            _Rechnung[] re = LinearSearch.ErzeugeZufallsRechnung2();
            BubbleSortRechnungen(re, true);

            Console.WriteLine("BubbleSort wurde erfolgreich ausgeführt");
        }

        //Sortiert nach Nettopreis
        //generische Implementierung möglich, dauert aber zu lange
        private static void BubbleSortRechnungen(_Rechnung[] arr, bool printSwaps = false)
        {
            int swaps = 0;
            for (int _ = 0; _ < arr.Length; _++)
            {
                for (int i = 0; i < arr.Length - 1; i++)
                {
                    if (arr[i].Nettopreis > arr[i + 1].Nettopreis)
                    {
                        _Rechnung temp = arr[i + 1];
                        arr[i + 1] = arr[i];
                        arr[i] = temp;
                        swaps++;
                    }
                }
            }
            if (printSwaps)
            {
                Console.WriteLine($"Swaps durchgeführt: {swaps}");
            }
        }

        //Zusatzaufgabe 2 - nicht abgeschlossen
        public static void TaskC()
        {
            _Rechnung[] re = LinearSearch.ErzeugeZufallsRechnung2(),
                re2 = new _Rechnung[re.Length];

            //Array kopieren
            for (int i = 0; i < re.Length; ++i)
                re2[i] = re[1];

            BubbleSortRechnungen(re, true);

            Console.WriteLine("BubbleSort wurde erfolgreich ausgeführt");
        }
    }
}
