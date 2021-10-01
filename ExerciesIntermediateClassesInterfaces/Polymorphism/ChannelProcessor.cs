using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciesIntermediateClassesInterfaces.Polymorphism
{
    public class ChannelProcessor
    {
        private readonly IList<INotificationChannel> _channels;

        public ChannelProcessor()
        {
            _channels = new List<INotificationChannel>();
        }

        public void ProcessMessage() 
        {
            foreach (var channel in _channels)
            {
                channel.Send("Text");
            }
        }

        public void RegisterNotificationChannel(INotificationChannel channel) 
        {
            _channels.Add(channel);
        } 
    }
}
