using System.Collections.Generic;

namespace AW1.DesignPatterns.Model
{
    public class ConcreteSubject : ISubject
    {
        private List<IObserver> Observer { get; set; }
        public State SubjectState { get; set; } = State.Default;
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
    }
}
