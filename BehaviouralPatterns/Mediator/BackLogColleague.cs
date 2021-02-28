using System;

namespace Mediator
{
    public class BackLogColleague : Colleague
    {
        public BackLogColleague(IMediator mediator) : base(mediator) { }

        public override void Notify(string message)
        {
            Console.WriteLine($"Message to BackLog: {message}");
        }
    }
}