namespace Akka.Net.Sample;

using System;
using Akka.Actor;
using HelloWorld;

class Program
{
    public static void Main()
    {
        // create a new actor system (a container for actors)
        var system = ActorSystem.Create("the-universe");

        // create actor and get a reference to it.
        // this will be an "ActorRef", which is not a 
        // reference to the actual actor instance
        // but rather a client or proxy to it
        var greeter = system.ActorOf<GreetingActor>("greeter");

        // send a message to the actor
        greeter.Tell(new Greet("World"));

        //this is for demonstration purposes
        Thread.Sleep(5000);
        system.Stop(greeter);

        // prevent the application from exiting before message is handled            
        Console.ReadLine();
    }
}