using System;
using System.Linq;

namespace AW1.Arrays
{
    static class AB5
    {
        public static void Task1()
        {
            int[] preis = new int[20];
            preis[0] = 20;
            preis[1] = 29;
            preis[2] = 135;
            Console.WriteLine("Preis eingeben:");

            for (int i = 3; i < preis.Length; ++i)
                preis[i] = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Gesamtsumme: {preis.Sum()}");

            int[] greater = preis.Where(el => el > 100).ToArray();

            string[] names = new string[preis.Length];
            for (int i = 0; i < preis.Length; ++i)
            {
                Console.WriteLine($"Name für Artikel {i + 1}?");
                names[i] = Console.ReadLine();
            }

            Console.WriteLine("Nach welcher Ware wollen Sie suchen?");

            Console.WriteLine(names.Contains(Console.ReadLine()) ? "Artikel existiert." : "Diesen Artikel gibt es nicht!");

            Console.WriteLine("Welche Ware wollen Sie löschen?");
            string deleteable = Console.ReadLine();
            int ind = Array.IndexOf(names, deleteable);
            if (ind > 0)
            {
                preis[ind] = preis[preis.Length - 1];
                names[ind] = names[names.Length - 1];
                names[names.Length - 1] = null;
                preis[preis.Length - 1] = 0;
            }
        }
    }
}
