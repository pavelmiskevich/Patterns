using System;

namespace Composite
{
    //https://ru.wikipedia.org/wiki/Компоновщик_(шаблон_проектирования)
    //https://refactoring.guru/ru/design-patterns/composite
    //https://bool.dev/blog/detail/strukturnye-patterny-komponovshchik-csharp
    //https://metanit.com/sharp/patterns/4.4.php

    //TODO: рекурсивное вычисление зарплат
    class Program
    {
        static void Main(string[] args)
        {
            StaffUnit root = new Department("Organization");
            StaffUnit employee1 = new Employee("Owner", 5);
            Department department = new Department("division");
            Employee employee2 = new Employee("LeadDiv", 3);
            Employee employee3 = new Employee("SubLeadDiv", 2);
            department.Add(employee2);
            department.Add(employee3);
            root.Add(employee1);
            root.Add(department);

            Department department2 = new Department("Division2");
            Employee employee4 = new Employee("LeadDiv2", 3);
            Employee employee5 = new Employee("SubLeadDiv2", 2);
            department2.Add(employee4);
            department2.Add(employee5);

            Department department3 = new Department("SubDivision");
            Employee employee6 = new Employee("LeadSubDiv", 1);
            Employee employee7 = new Employee("SubLeadSubDiv", 1);
            department3.Add(employee6);
            department3.Add(employee7);
            department2.Add(department3);

            root.Add(department2);

            Console.WriteLine("All");
            root.Display();
            Console.WriteLine("Department");
            department2.Display();
            Console.WriteLine("WithoutDepartment");
            root.Remove(department2);
            root.Display();
        }
    }
}
