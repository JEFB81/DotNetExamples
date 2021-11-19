using Azure.Messaging.ServiceBus;
using ServiceBusConnections;
using System;
using System.Threading.Tasks;

namespace privatemessagereceiver
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Sending a message to the Sales Messages queue...");
            MessageSender.SendSalesMessageAsync().GetAwaiter().GetResult();
            Console.WriteLine("Message was sent successfully.");

            //MessageReceiver.ReceiveSalesMessageAsync().GetAwaiter().GetResult();
        }


    }
}