using System;

namespace OOP.AddAClass
{

    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<Employee>();
            //  {
            //      new Employee() {FirstName = "Onur Eren", LastName ="Taşcı", Age =20}
            //      new Employee("Kerem", "Taşcı", 20),
            //      new Employee("Merve","Aslan", 23)
            //  };

            // üstteki ifade tüm dosyada bulunan en kısa ve en net tanımlama biçimidir


            Employee employee = new Employee() // 1. eleman
            {
                FirstName = "Onur Eren",
                LastName = "Taşcı",
                Age = 20
            };

            //employee.FirstName = "Onur Eren";     //üstte süslü parantezlerin içine burdaki ifadelerin alternatif ve okunaklı halini yazdık
            //employee.LastName = "Taşcı";
            //employee.Age = 20;

            //Console.WriteLine(employee.FirstName);
            //Console.WriteLine(employee.LastName); // WriteLine yerine Write yazarsak satırlar halinde değil yan yana çıktı
            //Console.WriteLine(employee.Age);


            Employee employee2 = new Employee("Kerem", "Taşcı", 16); // 2. eleman

            //Console.WriteLine($"{employee2.FirstName} " +
            //    $"{employee2.LastName} " +
            //    $"{employee2.Age}");

            Employee employee3 = new Employee("Merve", "Aslan", 23); // 3. eleman
            
            //Console.WriteLine(employee3); // standart olarak bu ifadenin çıktısı OOP:AddAClass.Employee şeklindedir
            //Console.WriteLine(employee2); // Ancak toString ifadesini override ettiğimiz için bizim belirttiğimiz çıktıyı verir
            //Console.WriteLine(employee); 


            
            list.Add(employee); // tüm elemanlar sırasıyla listenin bir üyesi haline geldi
            list.Add(employee2);
            list.Add(employee3);

            foreach (var item in list)
            {
                Console.WriteLine(item);    // döngüyle beraber 3 elemanı da en az kod yazarak
            }

            Console.ReadLine();
        }

    }

}