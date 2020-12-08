using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateMethod
{
    internal class Cottage : Building
    {
        protected override void BuildWallsFirstFloor()
        {
            Console.WriteLine("CottageClass says: I am build a walls on first floor");
        }

        protected override void InsertWindowsOnFirstFloor()
        {
            Console.WriteLine("CottageClass says: I am insert a windows on first floor");
        }

        protected override void BuildWallsSecondFloor()
        {
            Console.WriteLine("CottageClass says: I am build a walls on second floor");
        }

        protected override void InsertWindowsOnSecondFloor()
        {
            Console.WriteLine("CottageClass says: I am insert a windows on second floor");
        }
    }
}
