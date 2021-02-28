using System;

namespace Mediator
{
    //https://ru.wikipedia.org/wiki/%D0%9F%D0%BE%D1%81%D1%80%D0%B5%D0%B4%D0%BD%D0%B8%D0%BA_(%D1%88%D0%B0%D0%B1%D0%BB%D0%BE%D0%BD_%D0%BF%D1%80%D0%BE%D0%B5%D0%BA%D1%82%D0%B8%D1%80%D0%BE%D0%B2%D0%B0%D0%BD%D0%B8%D1%8F)
    //https://metanit.com/sharp/patterns/3.9.php
    //https://refactoring.guru/ru/design-patterns/mediator
    //https://bool.dev/blog/detail/pattern-posrednik-mediator

    class Program
    {
        static void Main(string[] args)
        {
            Mediator mediator = new Mediator();
            Colleague backLog = new BackLogColleague(mediator);
            Colleague planing = new PlaningColleague(mediator);
            Colleague work = new WorkColleague(mediator);
            Colleague demo = new DemoColleague(mediator);
            Colleague retro = new RetroColleague(mediator);
            mediator.BackLog = backLog;
            mediator.Planing = planing;
            mediator.Work = work;
            mediator.Demo = demo;
            mediator.Retro = retro;
            backLog.Send("Backlog exist, need a planing");
            planing.Send("Plan exist, need a working");
            work.Send("Work completed, need a demo");
            demo.Send("Demo completed, need a retro");
            retro.Send("Retro completed, need a change backlog");

            Console.ReadKey();
        }
    }
}
