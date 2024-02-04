using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    sealed class PartTimeSalesPerson : SalesPerson
    {
        public PartTimeSalesPerson(string name, int age, int ID, float pay, string SSN, int numberOfSales) : base(name, age, ID, pay, SSN, numberOfSales) { }
    }
}
