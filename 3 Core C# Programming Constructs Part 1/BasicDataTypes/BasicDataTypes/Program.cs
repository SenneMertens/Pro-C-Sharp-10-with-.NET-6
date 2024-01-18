using System.Numerics;

Console.WriteLine("** Basic Data Types **");

Console.WriteLine();

LocalVariableDeclarations();

Console.WriteLine();

DefaultDeclarations();

Console.WriteLine();

NewingDataTypes();

Console.WriteLine();

NewingDataTypesWith9();

Console.WriteLine();

ObjectFunctionality();

Console.WriteLine();

DataTypeFunctionality();

Console.WriteLine();

CharFunctionality();

Console.WriteLine();

ParseFromStrings();

Console.WriteLine();

ParseFromStringsWithTryParse();

Console.WriteLine();

DatesAndTimes();

Console.WriteLine();

UseBigInteger();

Console.WriteLine();

DigitSeparators();

Console.WriteLine();

BinaryLiterals();

static void LocalVariableDeclarations()
{
    Console.WriteLine("Data Declarations:");

    // Local variables are declared and initialized as follows: dataType variableName = initialValue;
    int myInt = 0;

    // You can also declare and assign on 2 lines.
    string myString;
    myString = "This is my character data.";

    // It is also permissible to declare multiple variables of the same underlying type on a single line of code.
    bool myBool1 = true, myBool2 = false, myBool3 = myBool1;

    // Using the System.Boolean data type to declare a bool.
    System.Boolean myBool4 = false;

    Console.WriteLine($"Your data: {myInt}, {myString}, {myBool1}, {myBool2}, {myBool3}, {myBool4}.");
}

static void DefaultDeclarations()
{
    Console.WriteLine("Default Declarations:");

    int myInt = default;

    Console.WriteLine($"{myInt}.");
}

static void NewingDataTypes()
{
    Console.WriteLine("Using new to create variables:");

    bool myBool = new bool();               // Set to false.
    int myInt = new int();                  // Set to 0.
    double myDouble = new double();         // set to 0.
    DateTime myDateTime = new DateTime();   // Set to 1/1/0001 12:00:00 AM/

    Console.WriteLine($"{myBool}, {myInt}, {myDouble}, {myDateTime}.");
}

static void NewingDataTypesWith9()
{
    Console.WriteLine("Using new to create variables:");

    // C# 9 added a shortcut that simply allows you to use the keyword new() without the data type.
    bool myBool = new();               // Set to false.
    int myInt = new();                  // Set to 0.
    double myDouble = new();         // set to 0.
    DateTime myDateTime = new();   // Set to 1/1/0001 12:00:00 AM/

    Console.WriteLine($"{myBool}, {myInt}, {myDouble}, {myDateTime}.");
}

static void ObjectFunctionality()
{
    Console.WriteLine("System.Object functionality:");

    // A C# int is really a shorthand for System.Int32, which inherits the following members from System.Object.
    Console.WriteLine($"12.GetHashCode() = {12.GetHashCode()}.");
    Console.WriteLine($"12.Equals(23) = {12.Equals(23)}.");
    Console.WriteLine($"12.ToString() = {12.ToString()}.");
    Console.WriteLine($"12.GetType() = {12.GetType()}.");
}

static void DataTypeFunctionality()
{
    Console.WriteLine("Data type functionality:");

    Console.WriteLine($"Max of int: {int.MaxValue}.");
    Console.WriteLine($"Min of int: {int.MinValue}.");
    Console.WriteLine($"Max of double: {double.MaxValue}.");
    Console.WriteLine($"Min of double: {double.MinValue}.");
    Console.WriteLine($"double.Epsilon: {double.Epsilon}.");
    Console.WriteLine($"double.PositiveInfinity: {double.PositiveInfinity}.");
    Console.WriteLine($"double.NegativeInfinity: {double.NegativeInfinity}.");
    Console.WriteLine($"bool.FalseString: {bool.FalseString}.");
    Console.WriteLine($"bool.TrueString: {bool.TrueString}.");
}

static void CharFunctionality()
{
    Console.WriteLine("Char type functionality:");

    char myChar = 'a';

    Console.WriteLine($"char.IsDigit('a'): {char.IsDigit(myChar)}.");
    Console.WriteLine($"char.IsLetter('a'): {char.IsLetter(myChar)}.");
    Console.WriteLine($"char.IsWhiteSpace(\"Hello There\", 5): {char.IsWhiteSpace("Hello There", 5)}.");
    Console.WriteLine($"char.IsWhiteSpace(\"Hello There\", 6): {char.IsWhiteSpace("Hello There", 6)}.");
    Console.WriteLine($"char.IsPunctuation('?'): {char.IsPunctuation('?')}.");
}

static void ParseFromStrings()
{
    Console.WriteLine("Data type parsing:");

    bool myBool = bool.Parse("True");
    Console.WriteLine($"Value of myBool: {myBool}.");

    double myDouble = double.Parse("99.884");
    Console.WriteLine($"Value of myDouble: {myDouble}.");

    int myInt = int.Parse("8");
    Console.WriteLine($"Value of myInt: {myInt}.");

    char myChar = char.Parse("w");
    Console.WriteLine($"Value of myChar: {myChar}.");
}

static void ParseFromStringsWithTryParse()
{
    Console.WriteLine("Data type parsing with TryParse:");

    if (bool.TryParse("True", out bool myBool))
    {
        Console.WriteLine($"Value of myBool: {myBool}.");
    }
    else
    {
        Console.WriteLine($"Default value of myBool: {myBool}.");
    }

    string value = "Hello";

    if (double.TryParse(value, out double myDouble))
    {
        Console.WriteLine($"Value of myDouble: {myDouble}.");
    }
    else
    {
        Console.WriteLine($"Failed to convert the input ({value}) to a double and the variable was assigned the default value of {myDouble}.");
    }
}

static void DatesAndTimes()
{
    Console.WriteLine("Dates and times:");

    // The DateTime constructor takes (year, month, day).
    DateTime myDateTime = new DateTime(2015, 10, 17);

    // What day of the month is this?
    Console.WriteLine($"The day of {myDateTime.Date} is a {myDateTime.DayOfWeek}.");

    // The month is now December.
    myDateTime = myDateTime.AddMonths(2);
    Console.WriteLine($"Daylight savings: {myDateTime.IsDaylightSavingTime()}.");

    // The TimeSpan constructor takes (hours, minutes, seconds).
    TimeSpan myTimeSpan = new TimeSpan(4, 30, 0);
    Console.WriteLine($"{myTimeSpan}.");

    // Subtract 15 minutes from the current TimeSpan.
    myTimeSpan = myTimeSpan.Subtract(new TimeSpan(0, 15, 0));
    Console.WriteLine($"{myTimeSpan}.");

    // The DateOnly struct represents half of the DateTime type.
    DateOnly myDateOnly = new DateOnly(2021, 07, 21);
    Console.WriteLine($"{myDateOnly}.");

    // The TimeOnly struct represents half of the DateTime type.
    TimeOnly myTimeOnly = new TimeOnly(13, 30, 0, 0);
    Console.WriteLine($"{myTimeOnly}.");
}

static void UseBigInteger()
{
    Console.WriteLine("BigInteger:");

    BigInteger myBigInteger = BigInteger.Parse("9999999999999999999999999999999999999999999999");
    
    Console.WriteLine($"The value of myBigInteger: {myBigInteger}.");
    Console.WriteLine($"Is myBigInteger an even value: {myBigInteger.IsEven}.");
    Console.WriteLine($"Is myBigInteger a power of 2: {myBigInteger.IsPowerOfTwo}.");

    BigInteger reallyBigInteger = BigInteger.Multiply(myBigInteger, BigInteger.Parse("8888888888888888888888888888888888888888888"));

    Console.WriteLine($"The value of reallyBigInteger: {reallyBigInteger}");
}

static void DigitSeparators()
{
    Console.WriteLine("Digit separators:");

    Console.WriteLine($"Integer: {123_456}.");
    Console.WriteLine($"Long: {123_456_789L}.");
    Console.WriteLine($"Float: {123_456.1234F}.");
    Console.WriteLine($"Decimal: {123_456.12M}.");

    // Hex can begin with an _.
    Console.WriteLine($"Hex: {0x_00_00_FF}.");
}

static void BinaryLiterals()
{
    Console.WriteLine("Binary literals:");

    // Binary can begin with an _.
    Console.WriteLine($"Sixteen: {0b_0001_0000}.");
    Console.WriteLine($"Thirty two: {0b_0010_0000}.");
    Console.WriteLine($"Sixty four: {0b_0100_0000}.");
}
