Console.WriteLine("** Nullable Reference Types **");

Console.WriteLine();

string? nullableString = null;
TestClass? myNullableClass = null;

// Warning CS8600 Converting null literal or possible null value to non-nullable type.
TestClass myNonNullableClass = myNullableClass;

// Compiler directives can be used to locally enable or disable the context used in the project settings.
#nullable disable
TestClass anotherNullableClas = null;

// Warning CS8632 The annotation for nullable reference types should only be used in code within a '#nullable' annotations.
TestClass? badDefinition = null;
string? anotherNullabeString = null;

// Compiler directives can be used to locally enable or disable the context used in the project settings.
#nullable restore

// Warning CS8625 Cannot convert null literal to non-nullable reference type.
// EnterLogData(null);

// string? message = null;
//
// Warning CS8604 Possible null reference argument for parameter 'message' in 'void EnterLogData(string message, string owner = "Programmer")'.
// EnterLogData(message);

// static void EnterLogData(string message, string owner = "Programmer")
// {
//      ArgumentNullException.ThrowIfNull(message);
// 
//      Console.WriteLine($"Error: {message}.");
//      Console.WriteLine($"Owner of Error: {owner}.");
// }

public class TestClass
{
    public string Name { get; set; }
    public int Age { get; set; }
}
