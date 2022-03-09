using System;
using System.Collections.Generic;

namespace AW1.DesignPatterns.Observer
{
    public class ConcreteSubject : ISubject
    {
        private List<IObserver> Observer { get; set; } = new List<IObserver>();
        private State _state = State.Default;
        public State SubjectState
        {
            get => _state;
            set
            {
                Notify();
                _state = value;
            }
        }

        public void Attach(IObserver o)
        {
            Observer.Add(o);
        }

        public void Detach(IObserver o)
        {
            Observer.Remove(o);
        }

        public void Notify()
        {
            foreach (IObserver o in Observer)
            {
                o.Update(this);
            }
        }

        public void DoStuff()
        {
            Console.WriteLine("ConcreteSubject is doing Stuff");
            SubjectState = State.Changed;
        }
    }

    public enum State : int
    {
        Default = 0,
        Changed = 1
    }
}
