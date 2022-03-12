using System;

namespace OOP.AddAClass
{

    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();

            employee.FirstName = "Onur Eren";
            employee.LastName = "Taşcı";
            employee.Age = 20;

            Console.WriteLine(employee.FirstName);
            Console.WriteLine(employee.LastName);
            Console.WriteLine(employee.Age);

            Console.WriteLine("------------------");

            Employee employee2 = new Employee("Kerem", "Taşcı", 16);

            Console.WriteLine(employee2.FirstName);
            Console.WriteLine(employee2.LastName);
            Console.WriteLine(employee2.Age);


            Console.ReadLine();
        }

    }

}