using System;

namespace BuilderPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            MessageBuilder messageBuilder = new MessageBuilder();

            messageBuilder.SetSender("Spike");

            messageBuilder.AppendContent("Woof! Woof!");
            messageBuilder.AppendContent(" Bark! Bark!");
            messageBuilder.AppendContent(" Woof!");

            messageBuilder.AddRecipient("Tweety");
            messageBuilder.AddRecipient("Missy");

            Message message = messageBuilder.ToMessage();
            PrintMessage(message);
        }

        private static void PrintMessage(Message message)
        {
            Console.WriteLine("From: " + message.Sender);
            Console.WriteLine("To: " + string.Join(", ", message.Recipients));
            Console.WriteLine("\"" + message.Content + "\"");
        }

    }
}
