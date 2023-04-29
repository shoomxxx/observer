using System;

namespace observer
{
    internal class ConcreteObserver : IObserver
    {
        private float _price;
        private readonly string _name;
        private ISubject _subject;

        public ConcreteObserver(string name, ISubject subject)
        {
            this._name = name;
            this._subject = subject;
            subject.RegisterObserver(this);
        }

        public void Update(float price)
        {
            this._price = price;
            Console.WriteLine("Цена на {0} изменилась на {1:f2}", _name, price);
        }
    }
}