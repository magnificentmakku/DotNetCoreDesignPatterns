namespace BuilderPattern
{
    using System.Collections.Generic;

    public class Message
    {
        public Message(string content, string sender, IEnumerable<string> recipients)
        {
            _content = content;
            _sender = sender;
            _recipients = recipients;
        }

        public string Content
        {
            get { return _content; }
        }

        public IEnumerable<string> Recipients
        {
            get { return _recipients; }
        }

        public string Sender
        {
            get { return _sender; }
        }

        private readonly string _content;
        private readonly IEnumerable<string> _recipients;
        private readonly string _sender;

    }
}
