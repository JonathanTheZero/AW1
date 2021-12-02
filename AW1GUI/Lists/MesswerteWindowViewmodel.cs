using System.Collections.Generic;
using System.Linq;

namespace AW1GUI.Lists
{
    public class MesswerteWindowViewmodel
    {
        public List<double> Data { get; set; } = new List<double>();
        public double ArithemtischesMittel => Data.Sum() / Data.Count;
        public double Minimum => Data.Min();
        public double Maximum => Data.Max();
        public double Median => CalcMedian();
        public double Summe => Data.Sum();
        public double Produkt => Data.Aggregate((a, x) => a * x);
        public double Modalwert => Data.GroupBy(d => d).OrderByDescending(g => g.Count()).First().Key;

        public MesswerteWindowViewmodel() { }

        private double CalcMedian()
        {
            List<double> sortedData = Data.OrderBy(d => d).ToList();

            if (sortedData.Count % 2 == 0)
            {
                int i = sortedData.Count / 2,
                    j = i - 1;
                return (sortedData[i] + sortedData[j]) / 2;
            }
            return sortedData[sortedData.Count / 2 - 1];
        }
    }
}
