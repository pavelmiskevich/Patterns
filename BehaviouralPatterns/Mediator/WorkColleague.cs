using System;

namespace Mediator
{
    public class WorkColleague : Colleague
    {
        public WorkColleague(IMediator mediator) : base(mediator) { }

        public override void Notify(string message)
        {
            Console.WriteLine($"Message to Work: {message}");
        }
    }
}