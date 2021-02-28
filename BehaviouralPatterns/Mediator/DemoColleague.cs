using System;

namespace Mediator
{
    public class DemoColleague : Colleague
    {
        public DemoColleague(IMediator mediator) : base(mediator) { }

        public override void Notify(string message)
        {
            Console.WriteLine($"Message to Demo: {message}");
        }
    }
}