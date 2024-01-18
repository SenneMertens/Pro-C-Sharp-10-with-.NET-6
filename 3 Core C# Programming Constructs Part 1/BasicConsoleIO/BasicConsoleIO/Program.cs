Console.WriteLine("** Basic Console IO **");

Console.WriteLine();

GetUserData();

Console.WriteLine();

FormatNumericalData();

static void GetUserData()
{
    Console.Write("Enter your name: ");
    string userName = Console.ReadLine();

    Console.Write("Enter your age: ");
    string userAge = Console.ReadLine();

    ConsoleColor previousColor = Console.ForegroundColor;
    Console.ForegroundColor = ConsoleColor.Yellow;

    Console.WriteLine($"Hello {userName}. You are {userAge} years old.");

    Console.ForegroundColor = previousColor;
}

static void FormatNumericalData()
{
    Console.WriteLine("The value 99999 in various formats:");
    Console.WriteLine("c format: {0:c}.", 99999);
    Console.WriteLine("d9 format: {0:d9}.", 99999);
    Console.WriteLine("f3 format: {0:f3}.", 99999);
    Console.WriteLine("n format: {0:n}.", 99999);
    // Notice that uppercasing or lowercasing for hexadecimal determines if letter or uppercase or lowercase.
    Console.WriteLine("E format: {0:E}.", 99999);
    Console.WriteLine("e format: {0:e}.", 99999);
    Console.WriteLine("X format: {0:X}.", 99999);
    Console.WriteLine("x format: {0:x}.", 99999);
}
