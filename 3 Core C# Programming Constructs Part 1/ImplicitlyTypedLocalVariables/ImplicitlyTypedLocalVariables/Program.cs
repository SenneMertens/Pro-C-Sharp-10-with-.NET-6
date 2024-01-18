Console.WriteLine("** Implicit Typing **");

Console.WriteLine();

DeclareImplicitVariables();

Console.WriteLine();

DeclareImplicitNumerics();

Console.WriteLine();

LinqQueryOverIntegers();

static void DeclareImplicitVariables()
{
    // Implicitly typed local variables are declared as "var variableName = initialValue";
    var myInt = 0;
    var myBool = true;
    var myString = "Time, marches on...";

    // Print out the underlying type.
    Console.WriteLine($"myInt is a {myInt.GetType().Name}.");
    Console.WriteLine($"myBool is a {myBool.GetType().Name}.");
    Console.WriteLine($"myString is a {myString.GetType().Name}.");
}

static void DeclareImplicitNumerics()
{
    // Implicitly typed numeric variables.
    var myUInt = 0u;
    var myInt = 0;
    var myLong = 0L;
    var myDouble = 0.5;
    var myFloat = 0.5F;
    var myDecimal = 0.5M;

    // Print out the underlying type.
    Console.WriteLine($"myUInt is a {myUInt.GetType().Name}.");
    Console.WriteLine($"myInt is a {myInt.GetType().Name}.");
    Console.WriteLine($"myLong is a {myLong.GetType().Name}.");
    Console.WriteLine($"myDouble is a {myDouble.GetType().Name}.");
    Console.WriteLine($"myFloat is a {myFloat.GetType().Name}.");
    Console.WriteLine($"myDecimal is a {myDecimal.GetType().Name}.");
}

static void ImplicitTypingIsStrongTyping()
{
    // The compiler knows that myString is a System.String.
    var myString = "This variable can only hold string data.";

    myString = "This is fine.";

    // You can invoke any member of the underlying type.
    string uppercaseString = myString.ToUpper();

    // Error! You can't assign numerical data to a string.
    // myString = 44;
}

static void LinqQueryOverIntegers()
{
    int[] numbers = { 10, 20, 30, 40, 1, 2, 3, 8 };

    var subset = from i in numbers where i < 10 select i;

    Console.Write("Values in subset: ");

    foreach (var i in subset)
    {
        Console.Write($"{i} ");
    }

    Console.WriteLine();

    // Of what type is the subset?
    Console.WriteLine($"Subset is a {subset.GetType().Name}.");
    Console.WriteLine($"Subset is defined in {subset.GetType().Namespace}.");
}
