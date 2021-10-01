namespace ExerciesIntermediateClassesInterfaces.Polymorphism
{
    public class MailNotificationChannel : INotificationChannel
    {
        public void Send(string message)
        {
            System.Console.WriteLine($"Sending Mail: {message}");
        }
    }
}
