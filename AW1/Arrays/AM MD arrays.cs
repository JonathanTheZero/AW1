using System;

namespace AW1.Arrays
{
    static class ABMDArrays
    {
        public static void Task1()
        {
            decimal[,] days = new decimal[12, 31];
            Random r = new Random();
            for (int i = 0; i < days.GetLength(0); ++i)
                for (int j = 0; j < days.GetLength(1); ++j)
                    days[i, j] = r.Next();

            int highestMonth = -1;
            for (int i = 0; i < days.GetLength(0); ++i)
            {
                decimal sum = 0;
                for (int j = 0; j < days.GetLength(1); ++j)
                    sum += days[i, j];

                if (sum > highestMonth) highestMonth = i;
            }
            Console.WriteLine($"Der höchste Umsatz wurde im {highestMonth + 1}. Monat erzielt.");
        }

        public static void Task2(Subtask s)
        {
            Console.WriteLine("Bitte geben Sie einen Satz ein:");
            string word = Console.ReadLine();
            string[] words = word.ToLower().Split();

            if (s == Subtask.A)
            {
                int finalAmountSingle = 0,
                    finalAmountTotal = 0;
                foreach (string w in words)
                {
                    int amount = 0;
                    foreach (char c in w)
                        if (c == 'e') ++amount;

                    if (amount == 1) ++finalAmountSingle;
                    else if (amount > 1) ++finalAmountTotal;
                }
                Console.WriteLine($"Anzahl an Wörtern mit genau einem E: {finalAmountSingle}\nAnzahl an Wörtern mit mehr als einem E: {finalAmountTotal}");
            }
            else if (s == Subtask.B)
            {
                int finalAmountSingle = 0,
                    finalAmountTotal = 0;
                foreach (string w in words)
                {
                    if (w.Contains("e"))
                    {
                        ++finalAmountTotal;
                        if (w.IndexOf("e") == w.LastIndexOf("e")) ++finalAmountSingle;
                    }
                }
                Console.WriteLine($"Anzahl an Wörtern mit genau einem E: {finalAmountSingle}\nAnzahl an Wörtern mit mehr als einem E: {finalAmountTotal}");
            }
            else throw new Exception("Ungültiger Parameter");
        }

        public static void Task3(Subtask s)
        {
            if (s == Subtask.A)
            {
                char[,] H = {
                    {'H', 'H', ' ', ' ', ' ', ' ', 'H', 'H' },
                    {'H', 'H', ' ', ' ', ' ', ' ', 'H', 'H' },
                    {'H', 'H', ' ', ' ', ' ', ' ', 'H', 'H' },
                    {'H', 'H', 'H', 'H', 'H', 'H', 'H', 'H' },
                    {'H', 'H', 'H', 'H', 'H', 'H', 'H', 'H' },
                    {'H', 'H', ' ', ' ', ' ', ' ', 'H', 'H' },
                    {'H', 'H', ' ', ' ', ' ', ' ', 'H', 'H' },
                    {'H', 'H', ' ', ' ', ' ', ' ', 'H', 'H' },
                };
                for (int i = 0; i < H.GetLength(0); ++i)
                {
                    for (int j = 0; j < H.GetLength(1); ++j)
                        Console.Write(H[i, j]);
                    Console.Write("\n");
                }
            }
            else if (s == Subtask.B)
            {
                char[,,] HNBK ={
                    {
                        {'H', 'H', ' ', ' ', ' ', ' ', 'H', 'H' },
                        {'H', 'H', ' ', ' ', ' ', ' ', 'H', 'H' },
                        {'H', 'H', ' ', ' ', ' ', ' ', 'H', 'H' },
                        {'H', 'H', 'H', 'H', 'H', 'H', 'H', 'H' },
                        {'H', 'H', 'H', 'H', 'H', 'H', 'H', 'H' },
                        {'H', 'H', ' ', ' ', ' ', ' ', 'H', 'H' },
                        {'H', 'H', ' ', ' ', ' ', ' ', 'H', 'H' },
                        {'H', 'H', ' ', ' ', ' ', ' ', 'H', 'H' },
                    },
                    {
                        { 'N', 'N',' ', ' ', ' ', ' ', 'N', 'N'},
                        { 'N', 'N','N', ' ', ' ', ' ', 'N', 'N'},
                        { 'N', 'N','N', 'N', ' ', ' ', 'N', 'N'},
                        { 'N', 'N',' ', 'N', 'N', ' ', 'N', 'N'},
                        { 'N', 'N',' ', ' ', 'N', 'N', 'N', 'N'},
                        { 'N', 'N',' ', ' ', ' ', 'N', 'N', 'N'},
                        { 'N', 'N',' ', ' ', ' ', ' ', 'N', 'N'},
                        { 'N', 'N',' ', ' ', ' ', ' ', 'N', 'N'}
                    },
                    {
                        {'B', 'B', 'B', 'B','B',' ',' ',' ' },
                        {'B', 'B', ' ', ' ','B','B',' ',' ' },
                        {'B', 'B', ' ', ' ','B','B',' ',' ' },
                        {'B', 'B', 'B', 'B','B',' ',' ',' ' },
                        {'B', 'B', 'B', 'B','B',' ',' ',' ' },
                        {'B', 'B', ' ', ' ','B','B',' ',' ' },
                        {'B', 'B', ' ', ' ','B','B',' ',' ' },
                        {'B', 'B', 'B', 'B','B',' ',' ',' ' }
                    },
                    {
                        {'K', 'K', ' ', ' ', ' ', 'K','K',' ' },
                        {'K', 'K', ' ', ' ', 'K', 'K',' ',' ' },
                        {'K', 'K', ' ', 'K', 'K', ' ',' ',' ' },
                        {'K', 'K', 'K', 'K', ' ', ' ',' ',' ' },
                        {'K', 'K', 'K', 'K', ' ', ' ',' ',' ' },
                        {'K', 'K', ' ', 'K', 'K', ' ',' ',' ' },
                        {'K', 'K', ' ', ' ', 'K', 'K',' ',' ' },
                        {'K', 'K', ' ', ' ', ' ', 'K','K',' ' }
                    }
                };

                for (int i = 0; i < HNBK.GetLength(0); ++i)
                {
                    for (int j = 0; j < HNBK.GetLength(1); ++j)
                    {
                        for (int k = 0; k < HNBK.GetLength(2); ++k)
                            Console.Write(HNBK[i, j, k]);
                        Console.Write("\n");
                    }
                    Console.Write("\n");
                }
            }
        }
    }
}