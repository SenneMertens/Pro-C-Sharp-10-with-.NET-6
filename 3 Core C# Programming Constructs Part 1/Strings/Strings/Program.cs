using System;
using System.Runtime.CompilerServices;
using System.Text;

Console.WriteLine("** Strings **");

Console.WriteLine();

BasicStringFunctionality();

Console.WriteLine();

StringConcatenation();

Console.WriteLine();

EscapeCharacters();

Console.WriteLine();

StringInterpolation();

Console.WriteLine();

StringInterpolationWithDefaultInterpolatedStringHandler();

Console.WriteLine();

VerbatimStrings();

Console.WriteLine();

StringEquality();

Console.WriteLine();

StringEqualitySpecifyingCompareRules();

Console.WriteLine();

StringsAreImmutable();

Console.WriteLine();

StringsAreImmutable2();

Console.WriteLine();

UseStringBuilder();

static void BasicStringFunctionality()
{
    Console.WriteLine("Basic string Functionality:");

    string firstName = "Freddy";

    Console.WriteLine($"Value of firstName: {firstName}.");
    Console.WriteLine($"firstName has {firstName.Length} characters.");
    Console.WriteLine($"firstName in uppercase: {firstName.ToUpper()}.");
    Console.WriteLine($"firstName in lowercase: {firstName.ToLower()}.");
    Console.WriteLine($"Does firstName contain the letter y: {firstName.Contains("y")}.");
    Console.WriteLine($"New first name: {firstName.Replace("dy", "")}.");
}

static void StringConcatenation()
{
    Console.WriteLine("String concatenation:");

    string myString1 = "Programming the ";
    string myString2 = "PsychoDrill (PTP)";
    string myString3 = myString1 + myString2;

    Console.WriteLine($"{myString3}.");

    string myString4 = string.Concat(myString1, myString2);

    Console.WriteLine($"{myString4}.");
}

static void EscapeCharacters()
{
    Console.WriteLine("Escape characters:");

    string stringWithTabs = "Model\tColor\tSpeed\tPet Name";

    Console.WriteLine($"{stringWithTabs}.");
    Console.WriteLine($"Everyone loves \"Hello World\"");
    Console.WriteLine("C:\\MyApp\\bin\\Debug");
    Console.WriteLine("All finished.\n\n\n");
    Console.WriteLine($"All finished for real this time. {Environment.NewLine}{Environment.NewLine}{Environment.NewLine}");
}

static void StringInterpolation()
{
    Console.WriteLine("String interpolation:");

    // Some local variables.
    int age = 4;
    string name = "Soren";

    // Using curly-bracket syntax.
    string greeting1 = string.Format("Hello {0}, you are {1} years old.", name, age);
    Console.WriteLine($"{greeting1}");

    // Using string interpolation.
    string greeting2 = $"Hello {name}, you are {age} years old.";
    Console.WriteLine($"{greeting2}");
}

static void StringInterpolationWithDefaultInterpolatedStringHandler()
{
    Console.WriteLine("String interpolation under the covers:");

    int age = 4;
    string name = "Soren";

    var builder = new DefaultInterpolatedStringHandler(3, 2);

    builder.AppendLiteral("\tHello ");
    builder.AppendFormatted(name);
    builder.AppendLiteral(" you are ");
    builder.AppendFormatted(age);
    builder.AppendLiteral(" years old.");

    var greeting = builder.ToStringAndClear();

    Console.WriteLine($"{greeting}");
}

static void VerbatimStrings()
{
    // The following string is printed verbatim, thus all escape characters are displayed.
    Console.WriteLine(@"C:\MyApp\bin\Debug");

    // Whitespace is preserved with verbatim strings.
    string myLongString1 = @"This is a very
        very
            very
                very long string.";
    Console.WriteLine($"{myLongString1}");

    // You can also directly insert a double quote into a string literal by doubling the " token.
    Console.WriteLine(@"Cerebus said ""Darr! Pret-ty sun-sets""");

    // Verbatim strings can also be interpolated strings, by specifying both the interpolation operator ($) and the verbatim operator (@).
    string interpolation = "interpolation";

    Console.WriteLine($@"This is a very
        very
            long string with {interpolation}.");
}

static void StringEquality()
{
    Console.WriteLine("String equality:");

    string myString1 = "Hello";
    string myString2 = "Yo";

    Console.WriteLine($"myString1 = {myString1}.");
    Console.WriteLine($"myString2 = {myString2}.");

    // Test these strings for equality.
    Console.WriteLine($"myString1 == myString2: {myString1 == myString2}.");
    Console.WriteLine($"myString1 == Hello: {myString1 == "Hello"}.");
    Console.WriteLine($"myString1 == HELLO: {myString1 == "HELLO"}.");
    Console.WriteLine($"myString1 == hello: {myString1 == "hello"}.");
    Console.WriteLine($"myString1.Equals(myString2): {myString1.Equals(myString2)}.");
    Console.WriteLine($"\"Yo\".Equals(myString2): {"Yo".Equals(myString2)}.");
}

static void StringEqualitySpecifyingCompareRules()
{
    Console.WriteLine("String equality (case insensitive):");

    string myString1 = "Hello";
    string myString2 = "HELLO";

    Console.WriteLine($"myString1 = {myString1}.");
    Console.WriteLine($"myString2 = {myString2}.");

    // Check the results of changing the default compare rules.
    Console.WriteLine($"Default rules: myString1 = {myString1}, myString2 = {myString2}, myString1.Equals(myString2): {myString1.Equals(myString2)}.");
    Console.WriteLine($"Ignore case: myString1.Equals(myString2, StringComparison.OrdinalIgnoreCase): {myString1.Equals(myString2, StringComparison.OrdinalIgnoreCase)}.");
    Console.WriteLine($"Ignore case, Invariant Culture: myString1.Equals(myString2, StringComparison.InvariantCultureIgnoreCase): {myString1.Equals(myString2, StringComparison.InvariantCultureIgnoreCase)}.");

    Console.WriteLine();

    Console.WriteLine($"Default rules: myString1 = {myString1}, myString2 = {myString2}, myString1.IndexOf(\"E\"): {myString1.IndexOf("E")}.");
    Console.WriteLine($"Ignore case: myString1.IndexOf(\"E\", StringComparison.OrdinalIgnoreCase): {myString1.IndexOf("E", StringComparison.OrdinalIgnoreCase)}.");
    Console.WriteLine($"Ignore case, Invariant Culture: myString1.IndexOf(\"E\", StringComparison.InvariantCultureIgnoreCase): {myString1.IndexOf("E", StringComparison.InvariantCultureIgnoreCase)}.");
}

static void StringsAreImmutable()
{
    Console.WriteLine("Immutable strings:");

    // Set the initial string value.
    string myString = "This is my string.";
    Console.WriteLine($"myString1 = {myString}");

    // Uppercase myString.
    string uppercaseString = myString.ToUpper();
    Console.WriteLine($"uppercaseString = {uppercaseString}");

    // myString is still in the same format.
    Console.WriteLine($"myString1 = {myString}");
}

static void StringsAreImmutable2()
{
    Console.WriteLine("Immutable strings 2:");

    string myString = "My other string.";

    myString = "New string value.";

    Console.WriteLine($"{myString}");
}

static void UseStringBuilder()
{
    Console.WriteLine("Using StringBuilder:");

    // Make a StringBuilder with an initial size of 256.
    StringBuilder myStringBuilder = new StringBuilder("* Fantastic Games *", 256);
    myStringBuilder.Append("\n");
    myStringBuilder.AppendLine("Half Life");
    myStringBuilder.AppendLine("Morrowind");
    myStringBuilder.AppendLine("Deus Ex" + " 2");
    myStringBuilder.AppendLine("System Shock");

    Console.WriteLine($"{myStringBuilder.ToString()}");

    myStringBuilder.Replace("2", "Invisible War");

    Console.WriteLine($"{myStringBuilder.ToString()}");
    Console.WriteLine($"myStringBuilder has {myStringBuilder.Length} characters.");
}
