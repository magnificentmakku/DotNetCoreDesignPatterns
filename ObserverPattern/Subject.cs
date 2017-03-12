namespace ObserverPattern
{
    using System.Collections.Generic;

    public class Subject : ISubject
    {
        public Subject()
        {
            _subscribers = new List<ISubscriber>();
        }

        public void NewMessage(string message)
        {
            var data = new SubjectData(message);

            foreach (var subscriber in _subscribers)
                subscriber.Update(data);
        }

        #region ISubject members

        public void Subscribe(ISubscriber subscriber)
        {
            if (!_subscribers.Contains(subscriber))
                _subscribers.Add(subscriber);
        }

        public void Unsubscribe(ISubscriber subscriber)
        {
            if (_subscribers.Contains(subscriber))
                _subscribers.Remove(subscriber);
        }

        #endregion

        private readonly List<ISubscriber> _subscribers;

    }
}
