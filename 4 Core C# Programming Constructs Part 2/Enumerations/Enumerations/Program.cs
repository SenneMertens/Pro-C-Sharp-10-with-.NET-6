Console.WriteLine("** Enumerations **");

Console.WriteLine();

// Make an EmployeeTypeEnum variable.
EmployeeTypeEnum employeeType = EmployeeTypeEnum.Contractor;

EnumerationAsParameter(employeeType);

Console.WriteLine();

// Print the storage type for an enumeration.
// Using the GetType() method.
Console.WriteLine($"EmployeeTypeEnum uses a {Enum.GetUnderlyingType(employeeType.GetType())}.");

// Using the typeof() method, which does not require a variable.
Console.WriteLine($"EmployeeTypeEnum uses a {Enum.GetUnderlyingType(typeof(EmployeeTypeEnum))}.");

// Use the ToString() to get the string name of the current enumeration's value.
// Prints out "Employee is a Contractor.".
Console.WriteLine($"Employee is a {employeeType.ToString()}.");

// To get the numerical value of a given enumeration, simply cast the enum variable against the underlying type.
// Prints out "Contractor = 100.".
Console.WriteLine($"{employeeType.ToString()} = {(byte)employeeType}");

Console.WriteLine();

EmployeeTypeEnum employeeType2 = EmployeeTypeEnum.Contractor;

// These types are enumerationss in the System namespace.
DayOfWeek day = DayOfWeek.Monday;
ConsoleColor consoleColor = ConsoleColor.Gray;

EvaluateEnumeration(employeeType2);

Console.WriteLine();

EvaluateEnumeration(day);

Console.WriteLine();

EvaluateEnumeration(consoleColor);

// Enumerations as parameters.
static void EnumerationAsParameter(EmployeeTypeEnum employeeType)
{
    switch (employeeType)
    {
        case EmployeeTypeEnum.Manager:
            Console.WriteLine("How about stock options instead?");
            break;
        case EmployeeTypeEnum.Grunt:
            Console.WriteLine("You have got to be kidding.");
            break;
        case EmployeeTypeEnum.Contractor:
            Console.WriteLine("You already have enough cash.");
            break;
        case EmployeeTypeEnum.VicePresident:
            Console.WriteLine("Very well, sir.");
            break;
    }
}

// This method will print out the detais of any enum.
static void EvaluateEnumeration(Enum e)
{
    Console.WriteLine($"Information about {e.GetType().Name}");
    Console.WriteLine($"Underlying storage type: {Enum.GetUnderlyingType(e.GetType())}.");

    // Get all name-value pairs for the incoming parameter.
    Array enumData = Enum.GetValues(e.GetType());

    Console.WriteLine($"This enumeration has {enumData.Length} members.");

    // Now show the string name and associated value.
    for (int i = 0; i < enumData.Length; i++)
    {
        Console.WriteLine($"Name: {enumData.GetValue(i)}, Value: {enumData.GetValue(i):D}.");
    }
}

// A custom enumeration.
enum EmployeeTypeEnum : byte
{
    Manager = 10,
    Grunt = 1,
    Contractor = 100,
    VicePresident = 9
}
