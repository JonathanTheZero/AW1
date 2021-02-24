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
                    Console.WriteLine($"Der GGT von {a} und {b} ist: {GgT(a, b)}");
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
            for (int i = 0; i < 10; ++i)
            {
                double a = Math.Floor(random.NextDouble() * 50000),
                    b = Math.Floor(random.NextDouble() * 50000);
                Console.WriteLine($"a: {a}, b: {b}, GGT: {GgT(a, b)}");
            }
            Console.WriteLine();
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
            if (n < 0) throw new ArgumentException("Argument n needs to bigger than 0");
            if (n == 0 || n == 1) return n;
            return Fib(n - 1) + Fib(n - 2);
        }

        private static void TestFib()
        {
            for (int i = 0; i <= 40; ++i)
                Console.WriteLine($"Durchlauf: {i} => Fib(i): {Fib(i)}");
        }
        #endregion

        #region Task3
        public static void Task3()
        {
            Console.WriteLine("Wert für n?");
            double n = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Wert für m?");
            double m = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"n: {n}, m: {m} => Ackermann(n, m): {Ackermann(n, m)}");
        }

        private static double Ackermann(double n, double m)
        {
            if (n == 0) 
                return m + 1;
            if (m == 0) 
                return Ackermann(n - 1, 1);
            return Ackermann(n - 1, Ackermann(n, m - 1));
        }

        #endregion
    }
}
