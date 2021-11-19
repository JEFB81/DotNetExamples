using Azure.Messaging.ServiceBus;
using ServiceBusConnections;
using ServiceBusConnections.Topics;
using System;
using System.Threading.Tasks;

namespace privatemessagereceiver
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // QUEUE
            Console.WriteLine("Sending a message to the Sales Messages queue...");
            MessageSender.SendSalesMessageAsync().GetAwaiter().GetResult();
            Console.WriteLine("Message was sent successfully.");
            Console.WriteLine("Getting a message from the Sales Messages queue...");
            // receiver
            MessageReceiver.ReceiveSalesMessageAsync().GetAwaiter().GetResult();

            //TOPIC
            // sender
            Console.WriteLine("Sending a message to the Sales Performance topic...");
            TopicMessageSender.SendPerformanceMessageAsync().GetAwaiter().GetResult();
            Console.WriteLine("Message was sent successfully.");
            // Receiver
            TopicMessageReceiver.MainAsync().GetAwaiter().GetResult();
        }


    }
}