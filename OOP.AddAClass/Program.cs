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
            Console.WriteLine(employee.LastName); // WriteLine yerine Write yazarsak satırlar halinde değil yan yana çıktı
            Console.WriteLine(employee.Age);

            Console.WriteLine("------------------");

            Employee employee2 = new Employee("Kerem", "Taşcı", 16);

            Console.WriteLine($"{employee2.FirstName} " +
                $"{employee2.LastName} " +
                $"{employee2.Age}");

            Employee employee3 = new Employee("Merve", "Aslan", 23);
            
            Console.WriteLine(employee3); // standart olarak bu ifadenin çıktısı OOP:AddAClass.Employee şeklindedir
            Console.WriteLine(employee2); // Ancak toString ifadesini override ettiğimiz için bizim belirttiğimiz çıktıyı verir
            Console.WriteLine(employee); 

            Console.ReadLine();
        }

    }

}