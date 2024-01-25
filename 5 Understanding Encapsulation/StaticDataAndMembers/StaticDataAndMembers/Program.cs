using StaticDataAndMembers;

Console.WriteLine("** Static Data and Members:");

Console.WriteLine();

SavingsAccount savingsAccount1 = new SavingsAccount(50);
SavingsAccount savingsAccount2 = new SavingsAccount(100);

// Print the current interest rate.
Console.WriteLine($"The interest rate is: {SavingsAccount.currentInterestRate}.");

// Try to change the interest rate via the property.
SavingsAccount.SetInterestRate(0.08);

// Make a new object, this does not 'reset' the interest rate.
SavingsAccount savingsAccount3 = new SavingsAccount(10000.75);

Console.WriteLine($"The interest rate is: {SavingsAccount.currentInterestRate}.");

Console.WriteLine();

TimeUtilityClass.PrintDate();
TimeUtilityClass.PrintTime();
