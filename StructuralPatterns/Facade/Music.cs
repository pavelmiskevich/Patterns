namespace Facade
{
    internal class Music : IOnOff
    {
        public string On()
        {
            return "Turn on the music";
        }

        public string Off()
        {
            return "Turn off the music";
        }
    }
}
