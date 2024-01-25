using ConstantData;

Console.WriteLine("** Constant Data **");

Console.WriteLine();

Console.WriteLine($"The value of PI is: {MyMathClass.PI}");

// Error, can't change a constant.
// MyMathClass.PI = 3.1444;

Console.WriteLine();

Console.WriteLine("Constant string interpolation:");

const string foo = "Foo";
const string bar = "Bar";
const string foobar = $"{foo}{bar}";

Console.WriteLine(foobar);

Console.WriteLine();

Console.WriteLine("Static read-only field:");

Console.WriteLine($"The value of PI is: {MyMathClass.PIReadOnly}");
