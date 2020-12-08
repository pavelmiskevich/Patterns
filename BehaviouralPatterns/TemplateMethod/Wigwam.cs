using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateMethod
{
    internal class Wigwam : Building
    {
        protected override void BuildWallsFirstFloor()
        {
            Console.WriteLine("WigwamClass says: I am build a walls on first floor");
        }

        protected override void InsertWindowsOnFirstFloor()
        {
            Console.WriteLine("WigwamClass says: I am insert a windows on first floor");
        }
    }
}
