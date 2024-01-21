Console.WriteLine("** Tuples **");

Console.WriteLine();

Console.WriteLine("First tuple example:");

(string, int, string) values = ("A", 5, "C");

Console.WriteLine($"1st item: {values.Item1}.");
Console.WriteLine($"2nd item: {values.Item2}.");
Console.WriteLine($"3rd item: {values.Item3}.");

Console.WriteLine();

Console.WriteLine("Using named tuple properties:");

(string FirstLetter, int TheNumber, string SecondLetter) valuesWithNames = ("A", 5, "C");

Console.WriteLine($"1st item: {valuesWithNames.FirstLetter}.");
Console.WriteLine($"2nd item: {valuesWithNames.TheNumber}.");
Console.WriteLine($"3rd item: {valuesWithNames.SecondLetter}.");

// Naming on the right.
var valuesWithNames2 = (FirstLetter: "A", TheNumber: 5, SecondLetter: "C");

// Using the item notation still works.
Console.WriteLine($"1st item: {valuesWithNames2.Item1}.");
Console.WriteLine($"2nd item: {valuesWithNames2.Item2}.");
Console.WriteLine($"3rd item: {valuesWithNames2.Item3}.");

// Naming on both sides doesn't work.
(int Field1, int Field2) example = (Custom1: 5, Custom2: 7);

// This next line won't even compile.
// Console.WriteLine($"Naming on both sides doesn't work: {example.Custom1}.");

Console.WriteLine();

Console.WriteLine("Nested Tuples:");

var nestedTuples = (5, 4, ("A", "B"));

Console.WriteLine();

Console.WriteLine("Inferred tuple names:");

var inferredTuple1 = new { Prop1 = "First", Prop2 = "Second" };
var inferredTuple2 = (inferredTuple1.Prop1, inferredTuple1.Prop2);

Console.WriteLine($"{inferredTuple2.Prop1};{inferredTuple2.Prop2}");

Console.WriteLine();

Console.WriteLine("Tuples equality/inequality:");

// Lifted converions.
var left = (A: 5, B: 10);
(int? A, int? B) nullableMembers = (5, 10);

Console.WriteLine(left == nullableMembers); // True

// Converted type of left is (long, long);
(long A, long B) longTuple = (5, 10);

Console.WriteLine(left == longTuple); // True

// Comparisons performed on (long, int) tupes.
(long A, int B) longFirst = (5, 10);
(int A, long B) longSecond  = (5, 10);

Console.WriteLine(longFirst == longSecond); // True

Console.WriteLine();

Console.WriteLine("Tuples as return values:");

var samples = TuplesAsMethodReturnValues();

Console.WriteLine($"1st item: {samples.Item1}.");
Console.WriteLine($"2nd item: {samples.Item2}.");
Console.WriteLine($"3rd item: {samples.Item3}.");

Console.WriteLine();

Console.WriteLine("Using discards with tuples:");

var (firstName, _, lastName) = UsingDiscardsWithTuples("Philip F. Japikse");

Console.WriteLine($"{firstName} {lastName}");

Console.WriteLine();

Console.WriteLine("Deconstructing tuples:");

(int X, int Y) myTuple = (4, 5);

int x = 0;
int y = 0;

(x, y) = myTuple;

Console.WriteLine($"x is: {x}.");
Console.WriteLine($"y is: {y}.");

(int x1, int y1) = myTuple;

Console.WriteLine($"x1 is: {x1}.");
Console.WriteLine($"y1 is: {y1}.");

int x2 = 0;

(x2, int y2) = myTuple;

Console.WriteLine($"x1 is: {x2}.");
Console.WriteLine($"y1 is: {y2}.");

Point point = new Point(7, 5);

var pointValues = point.Deconstruct();

Console.WriteLine($"X is: {pointValues.Item1}.");
Console.WriteLine($"Y is: {pointValues.Item2}.");

Point point2 = new Point(8, 3);

int xp2 = 0;
int yp2 = 0;

(xp2, yp2) = point2;

Console.WriteLine($"X is: {pointValues.Item1}.");
Console.WriteLine($"Y is: {pointValues.Item2}.");

static (int a, string b, bool c) TuplesAsMethodReturnValues()
{
    return (9, "Enjoy your string", true);
}

static (string first, string middle, string last) UsingDiscardsWithTuples(string fullName)
{
    return ("Philip", "F.", "Japiske");
}

static string SwitchExpressionUsingTuples1(string first, string second)
{
    return (first, second) switch
    {
        ("Rock", "Paper") => "Paper wins.",
        ("Rock", "Scissors") => "Rock wins.",
        ("Paper", "Rock") => "Paper wins.",
        ("Paper", "Scissors") => "Scissors wins.",
        ("Scissors", "Rock") => "Rock wins.",
        ("Scissors", "Paper") => "Scissors wins.",
        (_, _) => "Tie.",
    };
}

// The same method rewritten to take in a tuple as an argument.
static string SwitchExpressUsingTuples2((string first, string second) value)
{
    return value switch
    {
        ("Rock", "Paper") => "Paper wins.",
        ("Rock", "Scissors") => "Rock wins.",
        ("Paper", "Rock") => "Paper wins.",
        ("Paper", "Scissors") => "Scissors wins.",
        ("Scissors", "Rock") => "Rock wins.",
        ("Scissors", "Paper") => "Scissors wins.",
        (_, _) => "Tie.",
    };
}

static string UsingDeconstructTupleMethodInSwitch1(Point point)
{
    return point.Deconstruct() switch
    {
        (0, 0) => "Origin",
        var (x, y) when x > 0 && y > 0 => "One",
        var (x, y) when x < 0 && y > 0 => "Two",
        var (x, y) when x < 0 && y < 0 => "Three",
        var (x, y) when x > 0 && y < 0 => "Four",
        var (_, _) => "Border",
    };
}

static string UsingDeconstructTupleMethodInSwitch2(Point point)
{
    return point switch
    {
        (0, 0) => "Origin",
        var (x, y) when x > 0 && y > 0 => "One",
        var (x, y) when x < 0 && y > 0 => "Two",
        var (x, y) when x < 0 && y < 0 => "Three",
        var (x, y) when x > 0 && y < 0 => "Four",
        var (_, _) => "Border",
    };
}

struct Point
{
    public int X;
    public int Y;

    public Point(int xPos, int yPos)
    {
        X = xPos;
        Y = yPos;
    }

    public (int xPos, int yPos) Deconstruct()
    {
        return (X, Y);
    }

    public void Deconstruct(out int xPos, out int yPos)
    {
        xPos = X;
        yPos = Y;
    }
}
