using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AW1.Funktionen
{
    public class Fakultät
    {
        public static long Iterative(int n)
        {
            if (n <= 0) throw new ArgumentException("Invalid Parameter");
            if (n == 1 || n == 2) return n;
            long res = 2;
            for(long i = 3; i <= n; ++i)
                res *= i;

            return res;
        }

        public static long Recursive(int n)
        {
            if (n <= 0) throw new ArgumentException("Invalid Parameter");
            if (n == 1 || n == 2) return n;
            return n * Recursive(n - 1);
        }
    }
}
