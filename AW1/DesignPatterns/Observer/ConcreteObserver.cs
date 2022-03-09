using System;

namespace AW1.DesignPatterns.Observer
{
    public class ConcreteObserver : IObserver
    {
        private State ObserverState { get; set; }
        public void Update(ISubject subject)
        {
            if (subject is ConcreteSubject conc)
            {
                Console.WriteLine("ConcreteObserver: Reacted to the event.");
                ObserverState = conc.SubjectState;
            }
        }
    }
}
