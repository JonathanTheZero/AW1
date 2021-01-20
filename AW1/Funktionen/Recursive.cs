using System;

namespace AW1.Funktionen
{
    public static class Recursive
    {
        #region Task1
        public static void Task1(Subtask s, double a, double b)
        {
            switch (s)
            {
                case Subtask.A:
                    Console.WriteLine($"Der GGT ist: {GgT(a, b)}");
                    break;
                case Subtask.B:
                    TestGGT();
                    break;
                default:
                    throw new ArgumentException("Unknown Subtask");
            }
        }
        //Funktioniert nicht bei sehr großen Zahlunterschieden, einem pos. und einem neg. Wert
        private static double GgT(double a, double b)
        {
            if (a == b) return a;
            if (a > b) return GgT(a - b, b);
            //b > a
            return GgT(b - a, a);
        }

        private static void TestGGT()
        {
            Random random = new Random();
            for (int i = 0; i < 5; ++i)
            {
                double a = random.NextDouble() * 5000,
                    b = random.NextDouble() * 5000;
                Console.WriteLine($"a: {a}, b: {b}, GGT: {GgT(a, b)}");
            }
        }
        #endregion

        #region Task2
        public static void Task2(Subtask s)
        {
            if (s == Subtask.A)
            {
                Console.WriteLine("Welches n?");
                int n = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"n: {n} => Fib(n): {Fib(n)}");
            }
            else if (s == Subtask.B)
                TestFib();
            else throw new ArgumentException("Invalid Subtask");
        }

        private static int Fib(int n)
        {
            if (n < 0) throw new ArgumentException("N needs to bigger than 0");
            if (n == 0 || n == 1) return n;
            return Fib(n - 1) + Fib(n - 2);
        }

        private static void TestFib()
        {
            for(int i = 0; i < 50; ++i)
                Console.WriteLine($"Durchlauf: {i} => Fib(i): {Fib(i)}");
        }
        #endregion
    }
}
