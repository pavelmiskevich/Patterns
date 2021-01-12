using System;
using System.Collections.Generic;

namespace Composite
{
    internal class Department : StaffUnit
    {
        List<StaffUnit> employees = new List<StaffUnit>();

        public Department(string name)
            : base(name)
        { }

        public override void Add(StaffUnit staffUnit)
        {
            employees.Add(staffUnit);
        }

        public override void Remove(StaffUnit staffUnit)
        {
            employees.Remove(staffUnit);
        }

        public override void Display()
        {
            Console.WriteLine($"Department name = {name}");
            int sum = 0;
            foreach (StaffUnit staffUnit in employees)
            {
                sum += staffUnit.salary;
                staffUnit.Display();
            }
            Console.WriteLine($"Department {name} salary = {sum}");
        }
    }
}
