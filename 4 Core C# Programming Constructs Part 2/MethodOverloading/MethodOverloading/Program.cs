using static MethodOverloading.AddOperations;

Console.WriteLine("** Method Overloading **");

Console.WriteLine();

// Calls the int version of Add().
Console.WriteLine(Add(10, 10));

// Calls the long version of Add().
Console.WriteLine(Add(900_000_000_000, 900_000_000_000));

// Calls the double version of Add().
Console.WriteLine(Add(4.3, 4.4));
