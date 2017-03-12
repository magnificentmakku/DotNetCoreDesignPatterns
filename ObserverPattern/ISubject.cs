namespace ObserverPattern
{
    public interface ISubject
    {
        void Subscribe(ISubscriber subscriber);

        void Unsubscribe(ISubscriber subscriber);

    }
}
