using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AW1.Interfaces.UBModel
{
    public class Mobiliar : IInventurposten
    {
        public float Preis { get; set; }

        public float GetPreis()
        {
            return Preis;
        }
    }
}
