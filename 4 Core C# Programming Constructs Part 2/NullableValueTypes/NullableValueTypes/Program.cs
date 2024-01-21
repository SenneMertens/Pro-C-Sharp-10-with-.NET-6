Console.WriteLine("** Nullable Value Types **");

Console.WriteLine();

DatabaseReader databaseReader = new DatabaseReader();

// Get an int from the database.
int? myInt = databaseReader.GetIntFromDataBase();

if (myInt.HasValue)
{
    Console.WriteLine($"The value of myInt is: {myInt.Value}.");
}
else
{
    Console.WriteLine("The value of myInt is undefined.");
}

// Get a bool from the database.
bool? myBool = databaseReader.GetBoolFromDatabase();

if (myBool.HasValue)
{
    Console.WriteLine($"The value of myInt is: {myBool.Value}.");
}
else
{
    Console.WriteLine("The value of myBool is undefined.");
}

Console.WriteLine();

// The null-coalescing operator (??).

// If the value from the method is null, assign the local variable to 100.
int myData = databaseReader.GetIntFromDataBase() ?? 100;

Console.WriteLine($"The value of myData: {myData}.");

Console.WriteLine();

// The null-coalescing assignment operator (??=).
int? nullableInt = null;

nullableInt ??= 12;
nullableInt ??= 14;

Console.WriteLine($"{nullableInt}.");

Console.WriteLine();

TestForNull(null);

static void LocalNullableVariables()
{
    // Define some local nullable variables.
    int? nullableInt = 10;
    double? nullableDouble = 3.14;
    bool? nullableBool = null;
    char? nullableChar = 'a';
    int?[] arrayOfNullableInts = new int?[10];
}

static void LocalNullableVariablesUsingNullable()
{
    // Define some local nullable variables using Nullable<T>.
    Nullable<int> nullableInt = 10;
    Nullable<double> nullableDouble = 3.14;
    Nullable<bool> nullableBool = null;
    Nullable<char> nullableChar = 'a';
    Nullable<int>[] arrayOfNullableInts = new Nullable<int>[10];
}

static void TestForNull(string[] args)
{
    // We should check for null before accessing the array data and assign "0" of it is null.
    Console.WriteLine($"You sent me {args?.Length ?? 0} arguments.");
}

class DatabaseReader
{
    // Nullable data field.
    public int? numericValue = null;
    public bool? boolValue = true;

    // Note the nullable return type.
    public int? GetIntFromDataBase()
    {
        return numericValue;
    }

    // Note the nullable return type.
    public bool? GetBoolFromDatabase()
    {
        return boolValue;
    }
}
