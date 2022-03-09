using AW1.DesignPatterns.Observer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AW1.DesignPatterns
{
    public static class DesignPattern
    {
        public static void ObserverSubject()
        {
            ConcreteSubject cs = new ConcreteSubject();
            ConcreteObserver co = new ConcreteObserver();
            cs.Attach(co);
            cs.DoStuff();
        }
    }
}
