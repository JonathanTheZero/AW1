using System;

namespace AW1.Referenzen
{
    public static class Semantik
    {
        public static void TaskA()
        {
            double[] squares = { 10, 12, 14, 120 };
            int[,] swaps = { { 10, 12 }, { 32, 2 }, { 123, 53 }, { 12312132, -5 } };
            for (int i = 0; i < squares.Length; ++i)
            {
                double d = squares[i];
                Console.WriteLine($"double d = {d}");
                Square(ref d);
                Console.WriteLine($"Nach Square Aufruf: double d = {d}");
                Console.WriteLine("-------------");

                int a = swaps[i, 0], b = swaps[i, 1];
                Console.WriteLine($"int a = {a}, b = {b}");
                Swap(ref a, ref b);
                Console.WriteLine($"Nach Swap Aufruf: int a = {a}, b = {b}");
                Console.WriteLine("-------------\n");
            }
        }

        private static void Square(ref double d)
        {
            d *= d;
        }

        private static void Swap(ref int a, ref int b)
        {
            int _a = a,
                _b = b;
            a = _b;
            b = _a;
        }
    }
}
