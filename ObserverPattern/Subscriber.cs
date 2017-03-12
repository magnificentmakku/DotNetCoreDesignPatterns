namespace ObserverPattern
{
    using System;

    public class Subscriber : ISubscriber
    {
        public Subscriber(ISubject subject)
        {
            _subject = subject;
            _subject.Subscribe(this);
        }

        #region ISubscriber members

        public void Unsubscribe()
        {
            _subject.Unsubscribe(this);
        }

        public void Update(SubjectData data)
        {
            Console.WriteLine(string.Format("{0}: {1}", data.Timestamp, data.Message));
        }

        #endregion

        private readonly ISubject _subject;

    }
}
