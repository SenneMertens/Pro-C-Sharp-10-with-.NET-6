using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    class Manager : Employee
    {
        public int StockOptions { get; set; }

        public Manager() { }

        public Manager(string name, int age, int ID, float pay, string SSN, int numberOfOptions) : base(name, age, ID, pay, SSN, EmployeePayTypeEnum.Salaried)
        {
            // This property is defined in the Manager class.
            StockOptions = numberOfOptions;
        }

        public override void GiveBonus(float amount)
        {
            base.GiveBonus(amount);

            Random random = new Random();

            StockOptions += random.Next(500);
        }

        public override void DisplayStats()
        {
            base.DisplayStats();

            Console.WriteLine($"Number of stock options: {StockOptions}.");
        }
    }
}
