using System.Xml.Linq;

Console.WriteLine("** Structures **");

Console.WriteLine();

// Create an initial Point.
Point myPoint;

myPoint.X = 349;
myPoint.Y = 76;

myPoint.Display();

myPoint.Increment();
myPoint.Display();

Console.WriteLine();

// Set all fields to defaut values using the default constructor.
Point point1 = new Point();

point1.Display();

Console.WriteLine();

// Call the custom constructor.
Point point2 = new Point(50, 60);

point2.Display();

Console.WriteLine();

PointWithReadOnly point3 = new PointWithReadOnly(50, 60, "Point with readonly");

point3.Display();

Console.WriteLine();

var disposableRefStruct = new DisposableRefStruct(50, 60);

disposableRefStruct.Display();
disposableRefStruct.Dispose();

struct Point
{
    // Fields of the structure.
    public int X = 5;
    public int Y = 7;

    // A parameterless constructor.
    public Point() { }

    // A custom constructor.
    public Point(int xPos, int yPos)
    {
        X = xPos;
        Y = yPos;
    }

    public void Increment()
    {
        X++;
        Y++;
    }

    public void Decrement()
    {
        X--;
        Y--;
    }

    public void Display()
    {
        Console.WriteLine($"X = {X}, Y = {Y}.");
    }
}

readonly struct ReadOnlyPoint
{
    // Fields of the structure.
    public int X { get; }
    public int Y { get; }

    public ReadOnlyPoint(int xPos, int yPos)
    {
        X = xPos;
        Y = yPos;
    }

    public void Display()
    {
        Console.WriteLine($"X = {X}, Y = {Y}.");
    }
}

struct PointWithReadOnly
{
    // Fields of the structure.
    public int X;
    public readonly int Y;
    public readonly string Name;

    // A custom constructor.
    public PointWithReadOnly(int xPos, int yPos, string name)
    {
        X = xPos;
        Y = yPos;
        Name = name;
    }

    public readonly void Display()
    {
        Console.WriteLine($"X = {X}, Y = {Y}, Name = {Name}.");
    }
}

ref struct PointWithRef
{
    // Fields of the structure.
    public int X;
    public readonly int Y;
    public readonly string Name;

    // A custom constructor.
    public PointWithRef(int xPos, int yPos, string name)
    {
        X = xPos;
        Y = yPos;
        Name = name;
    }

    public readonly void Display()
    {
        Console.WriteLine($"X = {X}, Y = {Y}, Name = {Name}.");
    }
}

ref struct DisposableRefStruct
{
    // Fields of the structure.
    public int X;
    public readonly int Y;

    // A custom constructor.
    public DisposableRefStruct(int xPos, int yPos)
    {
        X = xPos;
        Y = yPos;

        Console.WriteLine("Created.");
    }

    public readonly void Display()
    {
        Console.WriteLine($"X = {X}, Y = {Y}.");
    }

    public void Dispose()
    {
        // Clean up any resources here.

        Console.WriteLine("Disposed.");
    }
}
