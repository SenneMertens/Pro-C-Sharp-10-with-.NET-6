using System.Linq.Expressions;

Console.WriteLine("** Iterations and Decisions **");

Console.WriteLine();

ForLoop();

Console.WriteLine();

ForEachLoop();

Console.WriteLine();

WhileLoop();

Console.WriteLine();

DoWhile();

Console.WriteLine();

IfElse();

Console.WriteLine();

IfElsePatternMatching();

Console.WriteLine();

IfElsePatternMatchingUpdatedInCSharp9();

Console.WriteLine();

IfElseUsingConditionalOperator();

Console.WriteLine();

ConditionalReference();

Console.WriteLine();

LogicalOperators();

Console.WriteLine();

Switch();

Console.WriteLine();

SwitchOnString();

Console.WriteLine();

SwitchOnEnumeration();

Console.WriteLine();

PatternMatchingSwitch();

Console.WriteLine();

PatternMatchingSwitchWithWhen();

Console.WriteLine();

SwitchExpressionClassic("Red");

Console.WriteLine();

SwitchExpressionModern("Blue");

Console.WriteLine();

SwitchWithTuple("Rock", "Paper");


static void ForLoop()
{
    Console.WriteLine("For loop:");

    // Note that "i" is only visible within the scope of the for loop.
    for (int i = 0; i < 4; i++)
    {
        Console.WriteLine($"The number is: {i}.");
    }
    // "i" is not visible here.
}

static void ForEachLoop()
{
    Console.WriteLine("For each loop:");

    string[] carTypes = { "Ford", "BMW", "Yugo", "Honda" };

    foreach (string carType in carTypes)
    {
        Console.WriteLine($"{carType}");
    }

    Console.WriteLine();

    int[] myInts = { 10, 20, 30, 40 };

    foreach (int integer in myInts)
    {
        Console.WriteLine($"{integer}");
    }
}

static void WhileLoop()
{
    Console.WriteLine("While loop:");

    string userIsDone = "";

    while (userIsDone.ToLower() != "yes")
    {
        Console.WriteLine("In while loop.");
        Console.Write("Are you done? [Yes] [No]: ");
        userIsDone = Console.ReadLine();
    }
}

static void DoWhile()
{
    Console.WriteLine("Do while loop:");

    string userIsDone = "";

    do
    {
        Console.WriteLine("In while loop.");
        Console.Write("Are you done? [Yes] [No]: ");
        userIsDone = Console.ReadLine();
    } while (userIsDone.ToLower() != "yes"); // Note the semicolon.
}

static void IfElse()
{
    Console.WriteLine("If else:");

    string stringData = "My textual data.";

    // This expression must always resolve to a Boolean value.
    if (stringData.Length > 0)
    {
        Console.WriteLine("The string is greater than 0 characters.");
    }
    else
    {
        Console.WriteLine("The string is not greater than 0 characters.");
    }
}

static void IfElsePatternMatching()
{
    Console.WriteLine("If else pattern matching:");

    object testItem1 = 123;
    object testItem2 = "Hello";

    if (testItem1 is string myStringValue1)
    {
        Console.WriteLine($"{myStringValue1} is a string.");
    }
    if (testItem1 is int myIntValue1)
    {
        Console.WriteLine($"{myIntValue1} is an integer.");
    }
    if (testItem2 is string myStringValue2)
    {
        Console.WriteLine($"{myStringValue2} is a string.");
    }
    if (testItem1 is int myIntValue2)
    {
        Console.WriteLine($"{myIntValue2} is an integer.");
    }
}

static void IfElsePatternMatchingUpdatedInCSharp9()
{
    Console.WriteLine("C# 9 if else pattern matching improvements:");

    object testItem1 = 123;
    Type myType = typeof(string);
    char myChar = 'f';

    // Type patterns.
    if (myType is Type)
    {
        Console.WriteLine($"{myType} is a Type.");
    }

    // Relational, conjuctive, and disjunctive patterns.
    if (myChar is >= 'a' and <= 'z' or >= 'A' and <= 'Z')
    {
        Console.WriteLine($"{myChar} is a character.");
    }

    // Parenthesized patterns.
    if (myChar is (>= 'a' and <= 'z') or (>= 'A' and <= 'Z') or '.' or ',')
    {
        Console.WriteLine($"{myChar} is a character or separator.");
    }

    // Negative patterns.
    if (testItem1 is not string)
    {
        Console.WriteLine($"{testItem1} is not a string.");
    }

    if (testItem1 is not null)
    {
        Console.WriteLine($"{testItem1} is not null.");
    }
}

static void IfElseUsingConditionalOperator()
{
    string stringData = "My textual data.";

    Console.WriteLine(stringData.Length > 0 ? "The string is greater than 0 characters." : "The string data is not greater than 0 characters.");
}

static void ConditionalReference()
{
    Console.WriteLine("Conditional reference:");

    var smallArray = new int[] { 1, 2, 3, 4, 5 };
    var largeArray = new int[] { 10, 20, 30, 40, 50 };

    int index = 7;

    ref int refValue = ref ((index < 5) ? ref smallArray[index] : ref largeArray[index - 5]);

    refValue = 0;
    index = 2;

    ((index < 5) ? ref smallArray[index] : ref largeArray[index - 5]) = 100;

    Console.WriteLine($"{string.Join(" ", smallArray)}");
    Console.WriteLine($"{string.Join(" ", largeArray)}");
}

static void LogicalOperators()
{
    Console.WriteLine("Logical operators:");

    bool trueBool = true;
    bool falseBool = false;

    Console.WriteLine($"{trueBool.ToString()} && {trueBool.ToString()}: {trueBool && trueBool}."); // True
    Console.WriteLine($"{trueBool.ToString()} && {falseBool.ToString()}: {trueBool && falseBool}."); // False
    Console.WriteLine($"{trueBool.ToString()} || {trueBool.ToString()}: {trueBool || trueBool}."); // True
    Console.WriteLine($"{trueBool.ToString()} || {falseBool.ToString()}: {trueBool || falseBool}."); // True
    Console.WriteLine($"{falseBool.ToString()} || {falseBool.ToString()}: {falseBool || falseBool}."); // False
    Console.WriteLine($"!{trueBool.ToString()}: {!trueBool}."); // False
    Console.WriteLine($"!{falseBool.ToString()}: {!falseBool}."); // True
}

static void Switch()
{
    Console.WriteLine("Switch:");

    Console.WriteLine("1 [C#], 2 [VB].");
    Console.Write("Please pick your language preference: ");
    string languageChoice = Console.ReadLine();

    int number = int.Parse(languageChoice);

    switch (number)
    {
        case 1:
            Console.WriteLine("C# is a fine language.");
            break;
        case 2:
            Console.WriteLine("VB: OOP, multithreading, and more.");
            break;
        default:
            Console.WriteLine("Good luck with that.");
            break;
    }
}

static void SwitchOnString()
{
    Console.WriteLine("Switch on string:");

    Console.WriteLine("1 [C#], 2 [VB].");
    Console.Write("Please pick your language preference: ");
    string languageChoice = Console.ReadLine();

    switch (languageChoice.ToUpper())
    {
        case "C#":
            Console.WriteLine("C# is a fine language.");
            break;
        case "VB":
            Console.WriteLine("VB: OOP, multithreading, and more.");
            break;
        default:
            Console.WriteLine("Good luck with that.");
            break;
    }
}

static void SwitchOnEnumeration()
{
    Console.Write("Enter your favorite day of the week: ");

    DayOfWeek favoriteDay;

    try
    {
        favoriteDay = (DayOfWeek) Enum.Parse(typeof(DayOfWeek), Console.ReadLine());
    }
    catch (Exception)
    {
        Console.WriteLine("Bad input.");

        return;
    }

    switch (favoriteDay)
    {
        case DayOfWeek.Sunday:
            Console.WriteLine("Football.");
            break;
        case DayOfWeek.Monday:
            Console.WriteLine("Another day, another dollar.");
            break;
        case DayOfWeek.Tuesday:
            Console.WriteLine("At least it's not Monday.");
            break;
        case DayOfWeek.Wednesday:
            Console.WriteLine("A fine day.");
            break;
        case DayOfWeek.Thursday:
            Console.WriteLine("Almost friday.");
            break;
        case DayOfWeek.Friday:
            Console.WriteLine("Friday rules.");
            break;
        case DayOfWeek.Saturday:
            Console.WriteLine("A great day indeed.");
            break;
    }
}

static void SwitchWithGoTo()
{
    var foo = 5;

    switch (foo)
    {
        case 1:
            // Do something.
            goto case 2;
        case 2:
            // Do something else.
            break;
        case 3:
            // Yet another action.
            goto default;
        default:
            // Default action.
            break;
    }
}

static void PatternMatchingSwitch()
{
    Console.WriteLine("1 [Integer (5)], 2 [String (\"Hi\")], 3 [Decimal (2.5)]");
    Console.Write("Choose an option: ");
    string userChoice = Console.ReadLine();

    object choice;

    // This is a standard constant pattern switch statement.
    switch (userChoice)
    {
        case "1":
            choice = 5;
            break;
        case "2":
            choice = "Hi";
            break;
        case "3":
            choice = 2.5M;
            break;
        default:
            choice = 5;
            break;
    }

    // This is the new pattern matching switch statement.
    switch (choice)
    {
        case int myInt:
            Console.WriteLine($"Your choice is an integer: {myInt}.");
            break;
        case string myString:
            Console.WriteLine($"Your choice is a string: {myString}.");
            break;
        case decimal myDecimal:
            Console.WriteLine($"Your choice is a decimal: {myDecimal}.");
            break;
        default:
            Console.WriteLine("Your choice is something else.");
            break;
    }
}

static void PatternMatchingSwitchWithWhen()
{
    Console.WriteLine("1 [C#], 2 [VB]");
    Console.Write("Please pick your language preference: ");
    object languageChoice = Console.ReadLine();

    var choice = int.TryParse(languageChoice.ToString(), out int myChoice) ? myChoice : languageChoice;

    switch (choice)
    {
        case int i when i == 1:
        case string s when s.Equals("C#", StringComparison.OrdinalIgnoreCase):
            Console.WriteLine("C# is a fine language.");
            break;
        case int i when i == 2:
        case string s when s.Equals("VB", StringComparison.OrdinalIgnoreCase):
            Console.WriteLine("VB: OOP, multithreading, and more.");
            break;
        default:
            Console.WriteLine("Good luck with that.");
            break;
    }
}

static string SwitchExpressionClassic(string colorBand)
{
    switch (colorBand)
    {
        case "Red":
            return "#FF0000";
        case "Orange":
            return "#FF7F00";
        case "Yellow":
            return "#FFFF00";
        case "Green":
            return "#00FF00";
        case "Blue":
            return "#0000FF";
        case "Indigo":
            return "#4B0082";
        case "Violet":
            return "#9400D3";
        default:
            return "#FFFFFF";
    }
}

static string SwitchExpressionModern (string colorBand)
{
    return colorBand switch
    {
        "Red" => "#FF0000",
        "Orange" => "#FF7F00",
        "Yellow" => "#FFFF00",
        "Green" => "#00FF00",
        "Blue" => "#0000FF",
        "Indigo" => "#4B0082",
        "Violet" => "#9400D3",
        _ => "#FFFFFF",
    };
}

static string SwitchWithTuple(string first, string second)
{
    return (first, second) switch
    {
        ("Rock", "Paper") => "Paper wins.",
        ("Rock", "Scissors") => "Rock wins.",
        ("Paper", "Rock") => "Paper wins.",
        ("Paper", "Scissors") => "Scissors wins.",
        ("Scissors", "Rock") => "Rock wins.",
        ("Scissors", "Paper") => "Scissors wins.",
        _ => "Tie.",
    };
}
