namespace Mediator
{
    public class Mediator : IMediator
    {
        public Colleague BackLog { get; set; }
        public Colleague Planing { get; set; }
        public Colleague Work { get; set; }
        public Colleague Demo { get; set; }
        public Colleague Retro { get; set; }

        public void Send(Colleague sender, string message)
        {
            switch (sender)
            {
                case BackLogColleague _:
                    Planing.Notify(message);
                    break;
                case PlaningColleague _:
                    Work.Notify(message);
                    break;
                case WorkColleague _:
                    Demo.Notify(message);
                    break;
                case DemoColleague _:
                    Retro.Notify(message);
                    break;
                case RetroColleague _:
                    BackLog.Notify(message);
                    break;
                default:
                    throw new System.NotImplementedException();
                    //break;
            }
        }
    }
}