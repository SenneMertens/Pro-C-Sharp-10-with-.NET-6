Console.WriteLine("** Type Conversions **");

Console.WriteLine();

// Add 2 shorts and print the result.
// short number1 = 9, number2 = 10;

// Console.WriteLine($"{number1} + {number2} = {Add(number1, number2)}");

short number1 = 30000, number2 = 30000;

// This raises a compiler error.
// short answer = Add(number1, number2);

// Explicitly cast the int into a short (and allow a loss of data).
short answer = (short)Add(number1, number2);

Console.WriteLine($"{number1} + {number2} = {answer}.");

Console.WriteLine();

NarrowingAttempt();

Console.WriteLine();

ProcessBytes();

Console.WriteLine();

NarrowWithConvert();

static int Add(int x, int y)
{
    return x + y;
}

static void NarrowingAttempt()
{
    byte myByte = 0;
    int myInt = 200;

    // Explicitly cast the int into a byte (no loss of data).
    myByte = (byte)myInt;

    Console.WriteLine($"Value of myByte: {myByte}.");
}

static void ProcessBytes()
{
    byte myByte1 = 100;
    byte myByte2 = 200;

    // Tell the compiler to add CIL code to throw an exception if overflow/underflow takes place.
    try
    {
        // If you want to force overflow checking to occur over a block of code statements, you can do so by defining a "checked scope".
        // checked
        // {
        //      Statements
        // }

        byte sum = checked((byte)Add(myByte1, myByte2));

        Console.WriteLine($"Sum: {sum}.");
    }
    catch (OverflowException ex)
    {
        Console.WriteLine($"{ex.Message}");
    }
}

static void NarrowWithConvert()
{
    byte myByte = 0;
    int myInt = 200;

    myByte = Convert.ToByte(myInt);

    Console.WriteLine($"Value of myByte: {myByte}.");
}
