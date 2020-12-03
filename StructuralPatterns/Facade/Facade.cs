using System;

namespace Facade
{
    internal class Facade
    {
        private readonly Kitty _kitty;
        private readonly IOnOff _light;
        private readonly IOnOff _music;

        public Facade(Kitty kitty, IOnOff light, IOnOff music)
        {
            _kitty = kitty;
            _light = light;
            _music = music;
        }

        public void Enter()
        {
            Console.WriteLine(_light.On());
            Console.WriteLine(_kitty.Feed());
            Console.WriteLine(_music.On());
        }

        public void Exit()
        {
            Console.WriteLine(_kitty.Stroke());
            Console.WriteLine(_music.Off());
            Console.WriteLine(_light.Off());
        }
    }
}
