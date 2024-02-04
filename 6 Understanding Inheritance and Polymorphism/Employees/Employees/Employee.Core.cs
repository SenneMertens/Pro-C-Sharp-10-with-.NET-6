using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    partial class Employee
    {
        // Derived classes can now directly access this information.
        protected string EmployeeName;
        protected int EmployeeID;
        protected float CurrentPay;
        protected int EmployeeAge;
        protected string EmployeeSSN;
        protected EmployeePayTypeEnum EmployeePayType;
        protected BenefitPackage EmployeeBenefits = new BenefitPackage();

        public string Name
        {
            get { return EmployeeName; }
            set
            {
                if (value.Length > 15)
                {
                    Console.WriteLine("The name length exceeds 15 characters.");
                }
                else
                {
                    EmployeeName = value;
                }
            }
        }

        public int ID
        {
            get { return EmployeeID; }
            set { EmployeeID = value; }
        }

        public float Pay
        {
            get { return CurrentPay; }
            set
            {
                CurrentPay = value;
            }
        }

        public int Age
        {
            get { return EmployeeAge; }
            set { EmployeeAge = value; }
        }

        public EmployeePayTypeEnum PayType
        {
            get { return EmployeePayType; }
            set { EmployeePayType = value; }
        }

        public string SocialSecurityNumber
        {
            get { return EmployeeSSN; }
            set { EmployeeSSN = value; }
        }

        // Expose the contained object trough a custom property.
        public BenefitPackage Benefits
        {
            get { return EmployeeBenefits; }
            set { EmployeeBenefits = value; }
        }

        // Expose certain contained object behaviors.
        public double GetBenefitCost()
            => EmployeeBenefits.ComputePayDeduction();
    }
}
