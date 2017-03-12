namespace ObserverPattern
{
    using System;

    public sealed class SubjectData
    {
        public SubjectData(string message)
        {
            Message = message;
            Timestamp = DateTime.UtcNow;
        }

        public string Message
        {
            get;
            set;
        }

        public DateTime Timestamp
        {
            get;
            set;
        }

    }
}
