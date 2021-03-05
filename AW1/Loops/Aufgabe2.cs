using System;
using System.Collections.Generic;
using System.Linq;

namespace AW1.Loops
{
    class Aufgabe2
    {
        public void Task1()
        {
            decimal sum = 0;
            while (sum < 20000)
                sum += Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine($"Gesamtsumme: {sum}");
        }

        public void Task2()
        {
            Console.WriteLine("Zahlenraten (1 bis 20).");
            int rand = new Random().Next(20);

            while (rand != Convert.ToInt32(Console.ReadLine()))
                Console.WriteLine("Leider falsch, bitte versuch es nocheinmal!");

            Console.WriteLine($"Richtig, die Zahl war {rand}");
        }

        public void Task3()
        {
            int[] vals = new int[7];
            Console.WriteLine("Bitte 7 Werte eingeben.");

            for (int i = 0; i < 7; ++i)
                vals[i] = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Max: {vals.Max()}\n Min:{vals.Min()}");
        }

        public void Task4()
        {
            List<double> vals = new List<double>();

            for (double i = -1; i != 0; i = Convert.ToDouble(Console.ReadLine()))
                vals.Add(i);

            Console.WriteLine($"Durchschnitt: {vals.Average()}");

            //double sum = 0;
            //for (int i = 0; i < vals.Count; ++i) 
            //    sum += vals[i];
            //double avg = sum / vals.Count;
        }
    }
}
