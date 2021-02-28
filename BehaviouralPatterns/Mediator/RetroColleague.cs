using System;

namespace Mediator
{
    public class RetroColleague : Colleague
    {
        public RetroColleague(IMediator mediator) : base(mediator){}

        public override void Notify(string message)
        {
            Console.WriteLine($"Message to Retro: {message}");
        }
    }
}