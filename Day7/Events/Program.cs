using EventConcept;

internal class Program
{
    private static void Main(string[] args)
    {
        Publisher publish  = new Publisher();
        publish.SampEvent += LogSubscriber.LogEventHandler;//Registering with ur publisher class
        publish.SampEvent += EmailSubscriber.EmailEventHandler;

        publish.Initiate();
    }
}