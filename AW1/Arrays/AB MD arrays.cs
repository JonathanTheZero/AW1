using System;

namespace AW1.Arrays
{
    class ABMDArrays
    {
        public ABMDArrays() { }

        public void Task2(bool a)
        {
            string word = Console.ReadLine();
            string[] words = word.Split();

            if (a)
            {
                int finalAmount = 0;
                foreach (string w in words)
                {
                    int amount = 0;
                    foreach (char c in w)
                        if (c == 'e') ++amount;

                    if (amount == 1) ++finalAmount;
                }
                Console.WriteLine(finalAmount);
            }
            else
            {
                int finalAmount = 0;
                foreach (string w in words)
                {
                    if (w.Contains("e") && w.IndexOf("e") == w.LastIndexOf("e")) finalAmount++;
                }
                Console.WriteLine(finalAmount);
            }
        }
    }
}