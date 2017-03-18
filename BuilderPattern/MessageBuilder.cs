namespace BuilderPattern
{
    using System.Collections.Generic;

    public class MessageBuilder
    {
        public MessageBuilder()
        {
            _content = string.Empty;
            _recipients = new List<string>();
            _sender = string.Empty;
        }

        public MessageBuilder AddRecipient(string recipient)
        {
            if (!_recipients.Contains(recipient))
                _recipients.Add(recipient);

            return this;
        }

        public MessageBuilder AppendContent(string content)
        {
            _content += content;
            return this;
        }

        public MessageBuilder SetSender(string sender)
        {
            _sender = sender;
            return this;
        }

        public Message ToMessage()
        {
            return new Message(_content, _sender, _recipients);
        }

        private string _content;
        private List<string> _recipients;
        private string _sender;

    }
}
