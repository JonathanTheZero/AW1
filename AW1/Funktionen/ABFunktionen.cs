using System;

namespace AW1.Funktionen
{
    static class ABFunktionen
    {
        #region Task1
        public static void Task1()
        {
            int[] arr = new int[20];
            Random rand = new Random();
            for (int i = 0; i < arr.Length; ++i)
                arr[i] = rand.Next(1000);

            //Console.WriteLine($"{arr[0]} {arr[1]} {arr[2]} {arr[3]} {arr[4]} ");
            Console.WriteLine($"Maximum: {Max(arr)}");
            Console.WriteLine($"Durchschnitt: {Avg(arr)}");
            Console.WriteLine($"Summe: {Sum(arr)}");
        }

        private static int Avg(int[] arr)
        {
            return Sum(arr) / arr.Length;
        }

        private static int Sum(int[] arr)
        {
            int sum = 0;
            foreach (int i in arr) sum += i;
            return sum;
        }

        private static int Max(int[] arr)
        {
            int max = int.MinValue;
            foreach (int i in arr)
                if (i > max) max = i;
            return max;
        }

        #endregion

        #region Task2
        public static void Task2()
        {
            string fx = "x^2 + 3x - 5";
            var res = PQ(3, -5);
            Console.WriteLine($"{res[0]}, {res[1]}");
        }

        private static double?[] PQ(double p, double q)
        {
            double? first = -(p / 2) + (Math.Sqrt(Math.Pow(p / 2, 2) - q)),
                second = -(p / 2) - (Math.Sqrt(Math.Pow(p / 2, 2) - q));

            if (double.IsNaN((double)first) || double.IsInfinity((double)first)) first = null;
            if (double.IsNaN((double)second) || double.IsInfinity((double)second)) second = null;

            return new double?[] { first, second };
        }
        #endregion

        #region Task3
        public static void Task3()
        {
            generatePrimes(200);
        }

        private static int[] generatePrimes(int maxValue)
        {
            if (maxValue < 2)
                return new int[0];
            int s = maxValue + 1; // size of array
            bool[] f = InitializeArray(s);
            FillPrimeArray(f);

            // how many primes are there?
            int[] primes = new int[PrimesAmount(f)];
            for (int i = 0, j = 0; i < s; i++)
                if (f[i]) 
                    primes[j++] = i;

            return primes;
        }

        private static int PrimesAmount(bool[] f)
        {
            int count = 0, s = f.Length;
            for (int i = 0; i < s; i++)
                if (f[i]) count++;
            return count;
        }

        private static bool[] InitializeArray(int s)
        {
            bool[] f = new bool[s];
            for (int i = 0; i < s; i++)
                f[i] = true;  // initialize array
            return f;
        }

        private static void FillPrimeArray(bool[] f)
        {
            f[0] = false; f[1] = false;
            for (int i = 2; i < Math.Sqrt(f.Length) + 1; i++)
                if (f[i]) // if i is uncrossed, cross ist multiples
                    for (int j = 2 * i; j < f.Length; j += i)
                        f[j] = false;
        }
        #endregion
    }
}
