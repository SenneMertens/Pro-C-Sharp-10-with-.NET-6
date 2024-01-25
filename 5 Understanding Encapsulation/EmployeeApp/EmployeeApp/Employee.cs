using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApp
{
    class Employee
    {
        // Field data.
        private string _employeeName;
        private int _employeeID;
        private float _currentPay;
        private int _employeeAge;
        private string _employeeSSN;
        private EmployeePayTypeEnum _payType;
        private DateTime _hireDate;

        // Properties.
        public string Name
        {
            get { return _employeeName; }
            set
            {
                // Here, 'value' is really a string.
                if (value.Length > 15)
                {
                    Console.WriteLine("The name length exceeds 15 characters.");
                }
                else
                {
                    _employeeName = value;
                }
            }
        }

        // We could add additional business rules to the sets of these properties. However, there is no need to do so for this example.
        public int ID
        {
            get { return _employeeID; }
            set { _employeeID = value; }
        }

        public float Pay
        {
            get { return _currentPay; }
            set { _currentPay = value; }
        }

        public int Age
        {
            get => _employeeAge;
            set => _employeeAge = value;
        }

        public string SocialSecurityNumber
        {
            get => _employeeSSN;
            private set => _employeeSSN = value;
        }

        public EmployeePayTypeEnum PayType
        {
            get => _payType;
            set => _payType = value;
        }

        public DateTime HireDate
        {
            get => _hireDate;
            set => _hireDate = value;
        }

        // Constructors.
        public Employee() { }

        public Employee(string name, int id, float pay) : this(name, id, pay, 0, "", EmployeePayTypeEnum.Salaried) { }

        public Employee(string name, int id, float pay, int age, string SSN, EmployeePayTypeEnum payType)
        {
            // Use properties when settings class data. This reduces the amount of duplicate errors checks.
            Name = name;
            ID = id;
            Pay = pay;
            Age = age;
            // It's not possible to use the property to assign a value if it's read-only. Use the member variable instead.
            _employeeSSN = SSN;
            PayType = payType;
        }

        // Methods.
        public void GiveBonus(float amount)
        {
            Pay = this switch
            {
                { Age: >= 18, PayType: EmployeePayTypeEnum.Commission, HireDate.Year: > 2020 } => Pay += .10F * amount,
                { Age: >= 18, PayType: EmployeePayTypeEnum.Hourly, HireDate.Year: > 2020 } => Pay += 40F * amount / 2080F,
                { Age: >= 18, PayType: EmployeePayTypeEnum.Salaried, HireDate.Year: > 2020 } => Pay += amount,
                _ => Pay += 0
            };
        }

        public void DisplayStats()
        {
            Console.WriteLine($"Name: {_employeeName}.");
            Console.WriteLine($"ID: {_employeeID}.");
            Console.WriteLine($"Pay: {_currentPay}.");
            Console.WriteLine($"Age: {_employeeAge}.");
        }

        // Accessor (get method).
        public string GetName() => _employeeName;

        // Mutator (set method).
        public void SetName(string name)
        {
            if (name.Length > 15)
            {
                Console.WriteLine("The name length exceeds 15 characters.");
            }
            else
            {
                _employeeName = name;
            }
        }
    }
}
