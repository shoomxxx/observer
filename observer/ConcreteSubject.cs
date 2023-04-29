using System.Collections.Generic;

namespace observer
{
    internal class ConcreteSubject : ISubject
    {
        private readonly List<IObserver> _observers = new List<IObserver>();
        private float _price;

        public void RegisterObserver(IObserver o)
        {
            _observers.Add(o);
        }

        public void RemoveObserver(IObserver o)
        {
            _observers.Remove(o);
        }

        public void NotifyObservers()
        {
            foreach (var o in _observers)
            {
                o.Update(_price);
            }
        }

        public void SetState(float price)
        {
            this._price = price;
            NotifyObservers();
        }
    }
}