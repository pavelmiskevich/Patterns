namespace Mediator
{
    public interface IMediator
    {
        void Send(Colleague sender, string ev);
    }
}