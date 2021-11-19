using Azure.Messaging.ServiceBus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceBusConnections
{
    public static class MessageReceiver
    {
        const string ServiceBusConnectionString = "Endpoint=sb://salesteamappjfb20211119.servicebus.windows.net/;SharedAccessKeyName=RootManageSharedAccessKey;SharedAccessKey=FLC2B8OGxN2tdbhPsCpmX93W7O2RH5vxGsMGIi2Qgis=";
        const string QueueName = "salesmessages";

        public static async Task ReceiveSalesMessageAsync()
        {
            Console.WriteLine("======================================================");
            Console.WriteLine("Press ENTER on the keyboard to exit after receiving all the messages.");
            Console.WriteLine("======================================================");

            var client = new ServiceBusClient(ServiceBusConnectionString);

            var processorOptions = new ServiceBusProcessorOptions
            {
                MaxConcurrentCalls = 1,
                AutoCompleteMessages = false
            };

            ServiceBusProcessor processor = client.CreateProcessor(QueueName, processorOptions);

            await processor.StartProcessingAsync();

            Console.Read();

            // Since we didn't use the "await using" syntax here, we need to explicitly dispose the processor and client
            await processor.DisposeAsync();
            await client.DisposeAsync();
        }

        static async Task MessageHandler(ProcessMessageEventArgs args)
        {
            Console.WriteLine($"Received message: SequenceNumber:{args.Message.SequenceNumber} Body:{args.Message.Body}");
            await args.CompleteMessageAsync(args.Message);
        }

        static Task ErrorHandler(ProcessErrorEventArgs args)
        {
            Console.WriteLine($"Message handler encountered an exception {args.Exception}.");
            Console.WriteLine("Exception context for troubleshooting:");
            Console.WriteLine($"- Endpoint: {args.FullyQualifiedNamespace}");
            Console.WriteLine($"- Entity Path: {args.EntityPath}");
            Console.WriteLine($"- Executing Action: {args.ErrorSource}");
            return Task.CompletedTask;
        }
    }
}
