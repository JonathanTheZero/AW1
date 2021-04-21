using System;

namespace AW1.Arrays
{
    class AB6
    {
        public void Task1()
        {
            decimal[,] months = new decimal[12, 31];
            Random random = new Random();

            for (int i = 0; i < months.GetLength(0); i++)
                for (int j = 0; j < months.GetLength(1); j++)
                    months[i, j] = random.Next(1000);

            int month = -1;
            decimal currMax = 0m;
            for (int i = 0; i < months.GetLength(0); ++i)
            {
                decimal temp = 0;
                for (int j = 0; j < months.GetLength(1); ++j)
                    temp += months[i, j];
                if (temp > currMax)
                {
                    month = i;
                    currMax = temp;
                }
            }

            Console.WriteLine($"Der Höchste Monat ist {month} mit {currMax}");
        }

        public void Task2()
        {
            Console.WriteLine("Bitte geben Sie einen Satz ein.");
            string inp = Console.ReadLine();
            string[] words = inp.Split();

            int sum1 = 0;
            for (int i = 0; i < words.Length; ++i)
                for (int j = 0; j < words[i].Length; ++j)
                    if (words[i][j] == 'e')
                    {
                        sum1++;
                        break;
                    }

            int sum2 = 0;
            foreach(string w in words)
                if (w.Contains("e")) sum2++;

            Console.WriteLine($"Zur Kontrolle die zwei ermittelten Werte: {sum1} und {sum2}");
        }

        public void Task3()
        {
            char[,] c = new char[,]
            {
                { 'H', 'H', 'H', 'H', 'H', 'H', 'H', 'H' },
                { 'H', 'H', 'H', 'H', 'H', 'H', 'H', 'H' },
                { 'a', 'a', 'a' , 'H', 'H', 'a', 'a', 'a' },
                { 'a', 'a', 'a' , 'H', 'H', 'a', 'a', 'a' },
                { 'a', 'a', 'a' , 'H', 'H', 'a', 'a', 'a' },
                { 'a', 'a', 'a' , 'H', 'H', 'a', 'a', 'a' },
                { 'H', 'H', 'H', 'H', 'H', 'H', 'H', 'H' },
                { 'H', 'H', 'H', 'H', 'H', 'H', 'H', 'H' }
            };
        }
    }
}
