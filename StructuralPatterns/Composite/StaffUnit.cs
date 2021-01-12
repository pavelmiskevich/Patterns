using System;

namespace Composite
{
    abstract class StaffUnit
    {
        protected string name;
        public int salary;

        protected StaffUnit(string name)
        {
            this.name = name;
        }

        protected StaffUnit(string name, int salary)
        {
            this.name = name;
            this.salary = salary;
        }

        public abstract void Display();

        public virtual void Add(StaffUnit component)
        {
            throw new NotImplementedException();
        }

        public virtual void Remove(StaffUnit component)
        {
            throw new NotImplementedException();
        }

        public virtual bool IsEmployee()
        {
            return false;
        }
    }
}
