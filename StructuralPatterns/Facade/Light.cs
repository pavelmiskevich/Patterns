namespace Facade
{
    internal class Light : IOnOff
    {
        public string On()
        {
            return "Turn on the light";
        }

        public string Off()
        {
            return "Turn off the light";
        }
    }
}
