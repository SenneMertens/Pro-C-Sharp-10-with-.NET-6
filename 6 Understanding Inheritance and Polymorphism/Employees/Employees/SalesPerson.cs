using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    class SalesPerson : Employee
    {
        public int SalesNumber { get; set; }

        public SalesPerson() { }

        // All subclasses should call an appropriate base class constructor.
        public SalesPerson(string name, int age, int ID, float pay, string SSN, int numberOfSales) : base(name, age, ID, pay, SSN, EmployeePayTypeEnum.Commission)
        {
            SalesNumber = numberOfSales;
        }

        public override sealed void GiveBonus(float amount)
        {
            int salesBonus = 0;

            if (SalesNumber >= 0 && SalesNumber <= 100)
            {
                salesBonus = 10;
            }
            else
            {
                if (SalesNumber >= 101 && SalesNumber <= 200)
                {
                    salesBonus = 15;
                }
                else
                {
                    salesBonus = 20;
                }
            }

            base.GiveBonus(amount);
        }

        public override void DisplayStats()
        {
            base.DisplayStats();

            Console.WriteLine($"Number of sales: {SalesNumber}.");
        }
    }
}
