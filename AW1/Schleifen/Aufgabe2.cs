using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AW1.Schleifen
{
    class Aufgabe2
    {
        public void Task1()
        {
            double sum = 0;
            while (sum < 20000)
                sum += Convert.ToDouble(Console.ReadLine());
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
    }
}
