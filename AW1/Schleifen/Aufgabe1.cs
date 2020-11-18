using System;

namespace AW1.Schleifen
{
    class Aufgabe1
    {
        public void Task1()
        {
            float monatseinnahmen = 0.0f;
            for (int i = 0; i < 31; ++i)
                monatseinnahmen += Convert.ToSingle(Console.ReadKey());
        }

        public void Task2()
        {
            int i = -1;
            while (++i < 52)
            {
                float lottogewinn = Convert.ToSingle(Console.ReadLine());
                if (lottogewinn > 10000.0f) break;
            }
        }

        public void Task3()
        {
            int zahl = Convert.ToInt16(Console.ReadLine());
            bool primzahl = true;
            int i = zahl - 1;
            while (i > 1)
            {
                if (zahl % i == 0)
                {
                    primzahl = false;
                    break;
                }
                i--;
            }
            Console.WriteLine(primzahl);
        }
    }
}
