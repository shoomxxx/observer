namespace observer
{

    abstract class Client
    {
        static void Main(string[] args)
        {
            var subject = new ConcreteSubject();
            var observer1 = new ConcreteObserver("Наблюдатель 1", subject);
            var observer2 = new ConcreteObserver("Наблюдатель 2", subject);
            var observer3 = new ConcreteObserver("Наблюдатель 3", subject);

            subject.SetState(10.0f);
            subject.SetState(12.5f);
            subject.SetState(15.0f);
        }
    }
}