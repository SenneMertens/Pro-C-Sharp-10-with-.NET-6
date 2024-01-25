using EmployeeApp;

Console.WriteLine("** EmployeeApp **");

Console.WriteLine();

Employee employee1 = new Employee("Marvin", 456, 30_000);

employee1.GiveBonus(1000);
employee1.DisplayStats();

// Use the Get/Set methods to interact with the object's name.
employee1.SetName("Marv");

Console.WriteLine($"Employee is named {employee1.GetName()}.");

Console.WriteLine();

Employee employee2 = new Employee();

// Longer than 15 characters. An error will print to the console.
employee2.SetName("Xena The Warrior Princess.");

Console.WriteLine();

Employee employee3 = new Employee("Marvin", 123, 1000, 45, "111-11-1111", EmployeePayTypeEnum.Salaried);

Console.WriteLine(employee3.Pay);

employee3.GiveBonus(100);

Console.WriteLine(employee3.Pay);
