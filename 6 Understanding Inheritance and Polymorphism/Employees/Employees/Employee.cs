using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    // The Employee class has been updated as abstract to prevent direct instantiation.
    abstract partial class Employee
    {
        public Employee() { }

        public Employee(string name, int age, float pay, string SSN) { }

        public Employee(string name, int age, int id, float pay, string SSN, EmployeePayTypeEnum payType)
        {
            Name = name;
            Age = age;
            ID = id;
            Pay = pay;
            SocialSecurityNumber = SSN;
            PayType = payType;
        }

        public virtual void GiveBonus(float amount) => Pay += amount;

        // public void GiveBonus(float amount)
        // {
            // Pay = this switch
            // {
                // { PayType: EmployeePayTypeEnum.Commission } => Pay += .10F * amount,
                // { PayType: EmployeePayTypeEnum.Hourly } => Pay += 40F * amount,
                // { PayType: EmployeePayTypeEnum.Salaried } => Pay += amount,
                // _ => Pay += 0
            // };
        // }

        // Expose certain benefit behaviors of the contained object.

        public virtual void DisplayStats()
        {
            Console.WriteLine($"Name: {Name}.");
            Console.WriteLine($"ID: {ID}.");
            Console.WriteLine($"Age: {Age}.");
            Console.WriteLine($"Pay: {Pay}.");
            Console.WriteLine($"Social security number: {SocialSecurityNumber}.");
        }

        public class BenefitPackage
        {
            public enum BenefitPackageLevel
            {
                Standard,
                Gold,
                Platinum
            }

            public double ComputePayDeduction()
            {
                return 125.0;
            }
        }
    }
}
