namespace OOP.AddAClass
{
    class Employee
    {
        private string _firstName; // belirtmesek bile bu ifade private
        private string _lastName;
        public string FirstName
        {
            set
            {
                _firstName = value; // artık employee içerisinden new ile yeni nesne üretildiğinde bu nesnenin firstname propu dışardan gelen bir değere yazılabilir
            }
            get
            {
                return _firstName; // employee üzerinde okuma yazma yapılabilir
            }
        }

        public string LastName 
        { 
            // Lambda formatı // Expression-Bodied Property Accessors
            get => _lastName; 
            set => _lastName = value; 
        }

        // Auto-implemented property
        public int Age{ get; set; }

        //Constructor
        public Employee()
        {
            System.Console.WriteLine("Yapılandırıcı metot çalıştı");
        }

        // Overloading
        public Employee(string firstName, string lastName, int age)
        {
            this.FirstName = firstName; // this employeeyi temsil eder
            this.LastName = lastName;
            this.Age = age;
        }


        // Override - geçersiz kılma

        public override string? ToString()
        {
            return $"{FirstName} {LastName} ({Age})";
        }
    }

} 