using AW1.Wiederholung.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AW1.Wiederholung
{
    public static class Wiederholung0421
    {
        private static readonly Klinik[] kliniken = new Klinik[15];

        public static void TaskA()
        {
            bool userAdds = true;
            int added = 0;
            while(userAdds && added < kliniken.Length)
            {
                Console.WriteLine("Wie lautet der Name der Klinik?");
                kliniken[added].Name = Console.ReadLine();
                Console.WriteLine("Wie viele Betten hat die Klinik?");
                kliniken[added].Betten = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Wie viele Intensivplätze hat die Klinik?");
                kliniken[added].Intensivplaetze = Convert.ToInt32(Console.ReadLine());
                added++;
                Console.WriteLine("Wollen Sie eine weitere Klinik regstrieren? (y/n)");
                userAdds = Console.ReadLine()[0] == 'y';
            }
            Console.WriteLine($"Es wurden {added} Kliniken registriert");
        }

        public static void TaskB()
        {
            TaskA();
            int summe = SummeBetten(kliniken, 5);
            Console.WriteLine($"Die Anzahl beträgt: {summe}");
            //Für b):
            //int[] summe = SummeBetten(kliniken);
        }

        private static int SummeBetten(Klinik[] kliniken, int minBeds)
        {
            int sum = 0;
            foreach(Klinik k in kliniken)
            {
                if (k.Intensivplaetze > minBeds)
                    sum += k.Betten;
            }
            return sum;
        }

        /**
         * Eine Rekursive Funktion zur Augabe aller Daten der jeweiligen Kliniken
         * Die Funktion startet beim Index i und gibt alle Daten der i-ten und aller folgenden Kliniken an
         * string Bericht = Bericht(kliniken, 0);
         */
        private static string Bericht(Klinik[] kliniken, int i)
        {
            return kliniken[i].Name + " hat " + kliniken[i].Betten + " Betten. \n "
            + Bericht(kliniken, i + 1);
        }
    }
}
