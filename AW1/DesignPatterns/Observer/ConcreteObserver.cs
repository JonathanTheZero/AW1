namespace AW1.DesignPatterns.Observer
{
    public class ConcreteObserver : IObserver
    {
        private State ObserverState { get; set; }
        public void Update(ISubject subject)
        {
            if (subject is ConcreteSubject conc)
            {
                ObserverState = conc.SubjectState;
            }
        }
    }
}
