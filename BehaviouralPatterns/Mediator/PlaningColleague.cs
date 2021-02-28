using System;

namespace Mediator
{
    public class PlaningColleague : Colleague
    {
        public PlaningColleague(IMediator mediator) : base(mediator) { }
        
        public override void Notify(string message)
        {
            Console.WriteLine($"Message to Planing: {message}");
        }
    }
}