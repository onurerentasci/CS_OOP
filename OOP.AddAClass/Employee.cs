namespace OOP.AddAClass
{
    class Employee
    {
        private string _firstName; // belirtmesek bile bu ifade private
        private string _lastName;
        private List<Employee> _list;
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

        public List<Employee> Employees => _list;

        //Constructor
        public Employee()
        {
            _list = new List<Employee>();
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
            return $"{FirstName,-20} {LastName,-15} {Age,5}"; // ifadelerin yanındaki sayılar o ifade için kaç karakterlik alan oluşturduğumuzu belirtir
        }                                                     // sayı negatifse ifade kendine tanınan alan içinde sola, pozitifse sağa yaslanır  
        
        public void Add(Employee employee)
        {
            _list.Add(employee);
        }

        public void AddRange(params Employee[] employees)  // birden fazla kaydın parametre olarak verilmesini sağlar
        {
            _list.AddRange(employees);
        }

        public List<Employee> GetEmployees() => _list;
       
    }

} 