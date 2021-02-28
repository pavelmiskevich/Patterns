using System;

namespace Mediator
{
    public abstract class Colleague
    {
        //protected IMediator mediator;
        private readonly IMediator mediator;

        public Colleague(IMediator mediator)
        {
            this.mediator = mediator;
        }

        public virtual void Send(string message)
        {
            mediator.Send(this, message);
        }
        public abstract void Notify(string message);
    }
}