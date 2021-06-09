using System;

namespace AW1.Wiederholung
{
    public static class Wiederholung0621
    {
        public static void TaskA()
        {
            GenerateSeats(5, .45);
        }

        private static bool[,] GenerateSeats(int seed, double percent)
        {
            bool[,] seats = new bool[9, 30];
            Random rnd = new Random(seed);
            int count = 0;
            for (int i = 0; i < seats.GetLength(0); ++i)
            {
                for (int j = 0; j < seats.GetLength(1); ++j)
                {
                    //seats[i, j] = Convert.ToBoolean(rnd.Next(2));
                    //if (seats[i, j])
                    //    count++;

                    //if (percent <= ((double)count / seats.Length))
                    //{
                    //    Console.WriteLine(count);
                    //    return seats;
                    //}
                    seats[i, j] = rnd.NextDouble() <= percent;
                    if (seats[i, j])
                        count++;
                }
            }
            Console.WriteLine(count);
            return seats;
        }

        public static void TaskB()
        {
            bool[,] seats = GenerateSeats(5, .45);
            PrintSeats(seats);
        }

        private static void PrintSeats(bool[,] seats)
        {
            //print rows
            Console.Write("   ");
            for (int i = 0; i < seats.GetLength(1); ++i)
                Console.Write(i + " ");
            Console.WriteLine();
            Console.WriteLine();

            //print actual data
            for (int i = 0; i < seats.GetLength(0); ++i)
            {
                Console.Write(i + "  ");
                for (int j = 0; j < seats.GetLength(1); ++j)
                {
                    string str = "";
                    str += seats[i, j] ? 1 : 0;
                    str += j > 9 ? "  " : " ";
                    Console.Write(str);
                }
                Console.WriteLine();
            }
        }

        public static void TaskC()
        {
            bool[,] seats = GenerateSeats(5, .45);
            PrintSeats(seats);
            Console.WriteLine("----------------------------");
            Console.WriteLine(FindSeats(seats, 5));
            Console.WriteLine("----------------------------");
            PrintSeats(seats);
            Console.WriteLine("----------------------------");
            Console.WriteLine(FindSeats(seats, 3, 8));
            Console.WriteLine("----------------------------");
            PrintSeats(seats);
        }

        private static int FindSeats(bool[,] seats, int n)
        {
            int start = -1,
                count = 0;
            for (int i = 0; i < seats.GetLength(0); ++i)
            {
                for (int j = 0; j < seats.GetLength(1); ++j)
                {
                    if (!seats[i, j])
                    {
                        if (start == -1)
                        {
                            start = i * j + j;
                            count++;
                        }
                        else count++;
                    }
                    else
                    {
                        start = -1;
                        count = 0;
                    }
                    if (count == n)
                    {
                        for (int x = j - count; x <= j; ++x)
                        {
                            seats[i, x] = true;
                        }
                        return start;
                    }
                }
                start = -1;
                count = 0;
            }
            throw new Exception("No fitting seat found!");
        }

        private static int FindSeats(bool[,] seats, int n, int row)
        {
            int start = -1,
                count = 0;
            for (int j = 0; j < seats.GetLength(1); ++j)
            {
                if (!seats[row, j])
                {
                    if (start == -1)
                    {
                        start = row * j + j;
                        count++;
                    }
                    else count++;
                }
                else
                {
                    start = -1;
                    count = 0;
                }
                if (count == n)
                {
                    for (int x = j - count; x <= j; ++x)
                    {
                        seats[row, x] = true;
                    }
                    return start;
                }
            }
            throw new Exception("No fitting seat found!");
        }
    }
}
