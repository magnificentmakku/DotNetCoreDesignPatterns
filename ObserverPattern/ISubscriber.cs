namespace ObserverPattern
{
    public interface ISubscriber
    {
        void Unsubscribe();

        void Update(SubjectData data);

    }
}
