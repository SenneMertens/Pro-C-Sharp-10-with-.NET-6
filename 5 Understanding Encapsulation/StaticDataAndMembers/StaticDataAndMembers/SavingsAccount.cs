using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticDataAndMembers
{
    public class SavingsAccount
    {
        // Instance-level data.
        public double currentBalance;
        // A static point of data.
        public static double currentInterestRate;

        public SavingsAccount(double balance)
        {
            currentBalance = balance;
        }

        // A static constructor.
        static SavingsAccount()
        {
            Console.WriteLine("In static constructor.");

            currentInterestRate = 0.04; // This is static data.
        }

        public static void SetInterestRate(double rate)
            => currentInterestRate = rate;

        public static double GetInterestRate()
            => currentInterestRate;
    }
}
