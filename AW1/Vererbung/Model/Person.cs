using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AW1.Vererbung.Model
{
    public class Person
    {
        private string name;
        public Person(string name)
        {
            SetName(name);
        }

        public string GetName() => name;

        public void SetName(string name)
        {
            this.name = name;
        }
    }
}
