Console.WriteLine("** Methods **");

Console.WriteLine();

int x = 9, y = 10;

// Pass 2 variables in by value.
Console.WriteLine($"Before call: x = {x}, y = {y}.");
Console.WriteLine($"Answer is {Add(x, y)}.");
Console.WriteLine($"After call: x = {x}, y = {y}.");

Console.WriteLine();

// There's no need to assign an initial value to local variables used as output parameters, provided that the first time you use them is as output arguments.
// C# allows for out parameters to be declared in the method call.
AddUsingOutParamater(90, 90, out int answer);

Console.WriteLine($"90 + 90 = {answer}");

Console.WriteLine();

// Remember that you must use the out paramater when you invoke the method.
MultipleOutputParameters(out int myInt, out string myString, out bool myBool);

Console.WriteLine($"Integer is {myInt}.");
Console.WriteLine($"String is \"{myString}\".");
Console.WriteLine($"Boolean is {myBool}.");

Console.WriteLine();

// This only get the value for a, and ignores the other 2 parameters.
MultipleOutputParameters(out int a, out _, out _);

// Reference parameters.
string string1 = "Flip", string2 = "Flop";

Console.WriteLine($"Before: string1 =  {string1}, string2 = {string2}.");

ReferenceParameters(ref string1, ref string2);

Console.WriteLine($"After: string1 =  {string1}, string2 = {string2}.");

Console.WriteLine();

// Pass 2 variables as read only using the "in" modifier.
Console.WriteLine(InModifier(x, y));

Console.WriteLine();

// Pass in a comma-delimited list of doubles.
double average;

average = ParamsModifier(4.0, 3.2, 5.7, 64.22, 87.2);

Console.WriteLine($"The average is: {average}.");

// Or pass an array of doubles.
double[] data = { 4.0, 3.2, 5.7 };

average = ParamsModifier(4.0, 3.2, 5.7);

Console.WriteLine($"The average is: {average}.");

// The average of 0 is 0.
Console.WriteLine($"The average is: {ParamsModifier()}.");

Console.WriteLine();

// Optional parameters must always be placed at the end of a method signature.
OptionalParamaters("Grid can't find data");
OptionalParamaters("Can't find the payroll data", "CFO");

Console.WriteLine();

// Named arguments.
NamedArguments(message: "Very fancy indeed", textColor: ConsoleColor.DarkRed, backgroundColor: ConsoleColor.White);
NamedArguments(backgroundColor: ConsoleColor.Green, message: "Testing", textColor: ConsoleColor.DarkBlue);

// This is allowed, as positional arguments are listed before named arguments.
NamedArguments(ConsoleColor.Blue, message: "Testing", backgroundColor: ConsoleColor.White);

// This is allowed, as all arguments are in the correct order.
NamedArguments(textColor: ConsoleColor.White, backgroundColor: ConsoleColor.Blue, "Testing");

// This is an error, as positional arguments are listed after named arguments.
// NamedArguments(message: "Testing", backgroundColor: ConsoleColor.White, ConsoleColor.Blue);


// Value type arguments are passed by default by value.
static int Add(int x, int y)
{
    int answer = x + y;

    // The caller will not see these changes as you are modifying a cope of the original data.
    x = 10000;
    y = 88888;

    return answer;
}

// Output parameters must be assigned by the called method.
static void AddUsingOutParamater(int x, int y, out int answer)
{
    answer = x + y;
}

// Returning multiple output parameters.
static void MultipleOutputParameters(out int a, out string b, out bool c)
{
    a = 9;
    b = "Enjoy your string.";
    c = true;
}

// Reference parameters.
static void ReferenceParameters(ref string string1, ref string string2)
{
    string temporaryString = string1;
    string1 = string2;
    string2 = temporaryString;
}

static int InModifier(in int x, in int y)
{
    // Error CS8331 Cannot assign to variable 'in int' because it is a readonly variable.
    // x = 10000;
    // y = 88888;

    int answer = x + y;

    return answer;
}

static double ParamsModifier(params double[] values)
{
    Console.WriteLine($"You sent me {values.Length} doubles.");

    double sum = 0;

    if (values.Length == 0)
    {
        return sum;
    }
    
    for (int i = 0; i < values.Length; i++)
    {
        sum += values[i];
    }

    return (sum / values.Length);
}

static void OptionalParamaters(string message, string owner = "Programmer")
{
    Console.WriteLine($"Error: {message}.");
    Console.WriteLine($"Owner of Error: {owner}.");
}

static void NamedArguments(ConsoleColor textColor = ConsoleColor.Blue, ConsoleColor backgroundColor = ConsoleColor.White , string message = "Test message")
{
    ConsoleColor oldTextColor = Console.ForegroundColor;
    ConsoleColor oldBackgroundColor = Console.BackgroundColor;

    Console.ForegroundColor = textColor;
    Console.BackgroundColor = backgroundColor;

    Console.WriteLine($"{message}.");

    Console.ForegroundColor = oldTextColor;
    Console.BackgroundColor = oldBackgroundColor;
}
