using System;

namespace TemplateMethod
{
    internal abstract class Building
    {
        public void Build()
        {
            BuyLand();
            BuildWallsFirstFloor();
            InsertWindowsOnFirstFloor();
            BuildWallsSecondFloor();
            InsertWindowsOnSecondFloor();
            InstallRoof();
            InstallFence();
        }

        private void BuyLand()
        {
            Console.WriteLine("AbstractClass says: I am buy a land");
        }

        protected abstract void BuildWallsFirstFloor();
        protected abstract void InsertWindowsOnFirstFloor();

        protected virtual void BuildWallsSecondFloor() { }
        protected virtual void InsertWindowsOnSecondFloor() { }

        private void InstallRoof()
        {
            Console.WriteLine("AbstractClass says: I am install a roof");
        }

        private void InstallFence()
        {
            Console.WriteLine("AbstractClass says: I am install a fence");
        }
    }
}
