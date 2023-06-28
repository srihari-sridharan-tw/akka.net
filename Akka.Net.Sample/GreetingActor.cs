namespace HelloWorld;
using Akka.Actor;
using System;
public class GreetingActor : ReceiveActor
{
    public GreetingActor()
    {
        Receive<Greet>(greet =>
        {
            Console.WriteLine(Sender);
            Console.WriteLine(Self);
            Console.WriteLine($"Hello {greet.Who}");
        });

    }

    protected override void PostStop()
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Good night!");
    }

    protected override void PreStart()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Good morning, we are awake!");
    }
}
