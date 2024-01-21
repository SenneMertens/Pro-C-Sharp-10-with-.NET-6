using System;

Console.WriteLine("** Arrays **");

Console.WriteLine();

SimpleArrays();

Console.WriteLine();

ArrayInitialization();

Console.WriteLine();

ImplicitArrayInitialization();

Console.WriteLine();

ArrayOfObjects();

Console.WriteLine();

RectangularMultidimensionalArray();

Console.WriteLine();

JaggedMultidimensionalArray();

Console.WriteLine();

PassAndReceiveArrays();

Console.WriteLine();

SystemArrayFunctionality();

Console.WriteLine();

IndexesAndRanges();

static void SimpleArrays()
{
    Console.WriteLine("Simple array creation:");

    // Create and fill an array of 3 integers.
    int[] myInts = new int[3];

    myInts[0] = 100;
    myInts[1] = 200;
    myInts[2] = 300;

    foreach (int myInt in myInts)
    {
        Console.WriteLine($"{myInt}");
    }

    // Create a 100 item string array, indexed 0-99.
    string[] myStrings = new string[100];
}

static void ArrayInitialization()
{
    Console.WriteLine("Array initialization:");

    // Array initialization syntax using the new keyword.
    string[] stringArray = new string[] { "One", "Two", "Three" };

    Console.WriteLine($"stringArray has {stringArray.Length} elements.");

    // Array initialization syntax without using the new keyword.
    bool[] boolArray = { false, false, true };

    Console.WriteLine($"boolArray has {boolArray.Length} elements.");

    // Array initialization syntax with the new keyword and size.
    int[] intArray = new int[4] { 20, 22, 23, 0 };

    Console.WriteLine($"intArray has {intArray.Length} elements.");
}

static void ImplicitArrayInitialization()
{
    Console.WriteLine("Implicit array initialization:");
    // You must use the new keyword when initializing implicitly typed local arrays.

    // a is really an int[].
    var a = new[] { 1, 10, 100, 1000 };
    Console.WriteLine($"a is a {a.ToString()}.");

    // b is really a double[].
    var b = new[] { 1, 1.5, 2, 2.5 };
    Console.WriteLine($"b is a {b.ToString()}.");

    // c is really a string[].
    var c = new[] { "Hello", null, "World" };
    Console.WriteLine($"c is a {c.ToString()}.");
}

static void ArrayOfObjects()
{
    Console.WriteLine("Array of objects:");

    // An array of objects can be anything at all.
    object[] myObjects = new object[4];

    myObjects[0] = 10;
    myObjects[1] = false;
    myObjects[2] = new DateTime(1969, 3, 24);
    myObjects[3] = "Form & Void";

    foreach (object myObject in myObjects)
    {
        Console.WriteLine($"Type: {myObject.GetType()}, Value: {myObject}.");
    }
}

static void RectangularMultidimensionalArray()
{
    Console.WriteLine("Rectangular multidimensional array:");

    // A rectangular multidimensional array.
    int[,] myMatrix;

    myMatrix = new int[3, 4];

    // Populate a (3 * 4) array.
    for (int i = 0; i < 3; i++)
    {
        for (int j = 0; j < 4; j++)
        {
            myMatrix[i, j] = i * j;
        }
    }

    // Print a (3 * 4) array.
    for (int i = 0; i < 3; i++)
    {
        for (int j = 0; j < 4; j++)
        {
            Console.Write($"{myMatrix[i, j]}\t");
        }

        Console.WriteLine();
    }
}

static void JaggedMultidimensionalArray()
{
    Console.WriteLine("Jagged multidimensional array:");

    // A jagged multidimensional array is an array of arrays.
    // Here we have an array of 5 different arrays.
    int[][] myJaggedArray = new int[5][];

    // Create the jagged array.
    for (int i = 0; i < myJaggedArray.Length; i++)
    {
        myJaggedArray[i] = new int[i + 7];
    }

    // Print each row, remembering that each element is defaulted to 0.
    for (int i = 0; i < 5;  i++)
    {
        for (int j = 0; j < myJaggedArray[i].Length; j++)
        {
            Console.Write($"{myJaggedArray[i][j]} ");
        }

        Console.WriteLine();
    }
}

static void PrintArray(int[] myInts)
{
    for (int i = 0;i < myInts.Length; i++)
    {
        Console.WriteLine($"Item {i} is {myInts[i]}.");
    }
}

static string[] GetStringArray()
{
    string[] myStrings = { "Hello", "From", "GetStringArray" };

    return myStrings;
}

static void PassAndReceiveArrays()
{
    Console.WriteLine("Arrays as parameters and return values:");

    // Pass an array as a parameter.
    int[] ages = { 20, 22, 23, 0 };

    PrintArray(ages);

    // Get an array as a return value.
    string[] myStrings = GetStringArray();

    foreach (string myString in myStrings)
    {
        Console.WriteLine($"{myString}");
    }
}

static void SystemArrayFunctionality()
{
    Console.WriteLine("Working with System.Array:");

    // Initialize items at startup.
    string[] gothicBands = { "Tones on Tail", "Bauhaus", "Sisters of Mercy" };

    // Print out the names in a declared order.
    Console.WriteLine("Here is the array:");

    for (int i = 0; i < gothicBands.Length; i++)
    {
        Console.Write($"{gothicBands[i]}, ");
    }

    Console.WriteLine("\n");

    // Reverse them.
    Array.Reverse(gothicBands);

    Console.WriteLine("The reversed array:");

    for (int i = 0; i < gothicBands.Length; i++)
    {
        Console.Write($"{gothicBands[i]}, ");
    }

    Console.WriteLine("\n");

    // Clear out all but the first member.
    Array.Clear(gothicBands, 1, 2);

    for (int i = 0; i < gothicBands.Length; i++)
    {
        Console.Write($"{gothicBands[i]}, ");
    }
}

static void IndexesAndRanges()
{
    Console.WriteLine("Working with indices and ranges:");

    // Initialize items at startup.
    string[] gothicBands = { "Tones on Tail", "Bauhaus", "Sisters of Mercy" };

    for (int i = 0; i < gothicBands.Length; i++)
    {
        Index index = i;

        Console.Write($"{gothicBands[index]}, ");
    }

    Console.WriteLine();

    // The index from end operator (^) lets you specify how many positions from the end of the sequence, starting with the length.
    // Remember that the last item in a sequence is 1 less than the actual length, so ^0 would cause an error.
    for (int i = 1; i <= gothicBands.Length; i++)
    {
        Index index = ^i;

        Console.Write($"{gothicBands[index]}, ");
    }

    Console.WriteLine();

    // The range operator (..) specifies a start and end index and allows for access to a subsequence within a list.
    // The start of the range is inclusive, and the end of the range is exclusive.
    foreach (var band in gothicBands[0..2])
    {
        Console.Write($"{band}, ");
    }

    Console.WriteLine();

    // Ranges can also be passed to a sequence using the Range data type.
    Range range = 0..2;

    foreach (var band in gothicBands[range])
    {
        Console.Write($"{band}, ");
    }

    Console.WriteLine();

    // Ranges can be defined using integers or Index variables.
    Index index1 = 0;
    Index index2 = 2;

    Range rangeWithIndex = index1..index2;

    foreach (var band in gothicBands[range])
    {
        Console.Write($"{band}, ");
    }

    Console.WriteLine();

    Console.WriteLine($"Array length of [..] is {gothicBands[..].Length}.");
    Console.WriteLine($"Array length of [0..^0] is {gothicBands[0..^0].Length}.");
    Console.WriteLine($"Array length of [0..3] is {gothicBands[0..3].Length}.");

    Console.WriteLine();

    var bandName = gothicBands.ElementAt(^2);
    Console.WriteLine($"{bandName}");
}
