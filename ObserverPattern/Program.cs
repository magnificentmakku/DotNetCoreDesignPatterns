namespace ObserverPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var subject = new Subject();
            var subscriber1 = new Subscriber(subject);

            subject.NewMessage("Hello, world.");

            var subscriber2 = new Subscriber(subject);

            subject.NewMessage("foobar.");

            subscriber1.Unsubscribe();

            subject.NewMessage("Goodbye!");
        }

    }
}
