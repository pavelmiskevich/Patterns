using System;

namespace Composite
{
    internal class Employee : StaffUnit
    {
        public Employee(string name, int salary)
            : base(name, salary)
        { }

        public override void Display()
        {
            Console.WriteLine($"Employee name = {name} with Salary = {salary}");
        }

        public override bool IsEmployee()
        {
            return true;
        }
    }
}
