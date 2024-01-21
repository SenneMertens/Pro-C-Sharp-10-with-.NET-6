Console.WriteLine("** Value and Reference Types **");

Console.WriteLine();

ValueTypeAssignment();

Console.WriteLine();

ReferenceTypeAssignment();

Console.WriteLine();

ValueTypeContainingReferenceType();

// Assigning 2 intrinsic value types results in 2 independent variables on the stack.
static void ValueTypeAssignment()
{
    Console.WriteLine("Assigning value types:");

    Point point1 = new Point(10, 10);
    Point point2 = point1;

    point1.Display();
    point2.Display();

    // Change point1.X, point2.X is not changed.
    point1.X = 100;

    Console.WriteLine("Changed point1.X:");

    point1.Display();
    point2.Display();
}

static void ReferenceTypeAssignment()
{
    Console.WriteLine("Assigning reference types:");

    PointRef point1 = new PointRef(10, 10);
    PointRef point2 = point1;

    point1.Display();
    point2.Display();

    // Change point1.X, point2.X is also changed.
    point1.X = 100;

    Console.WriteLine("Changed point1.X:");

    point1.Display();
    point2.Display();
}

static void ValueTypeContainingReferenceType()
{
    Console.WriteLine("Value types containing reference type:");

    Rectangle rectangle1 = new Rectangle("First rectangle", 10, 10, 50, 50);
    Rectangle rectangle2 = rectangle1;

    rectangle2.RectInfo.InfoString = "This is new info";
    rectangle2.RectBottom = 4444;

    rectangle1.Display();
    rectangle2.Display();
}

struct Point
{
    // Fields of the structure.
    public int X;
    public int Y;

    // A custom constructor.
    public Point (int xPos, int yPos)
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

// Classes are always reference types.
class PointRef
{
    // Fields of the class.
    public int X;
    public int Y;

    // A custom constructor.
    public PointRef(int xPos, int yPos)
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

class ShapeInfo
{
    public string InfoString;

    public ShapeInfo(string info)
    {
        InfoString = info;
    }
}

struct Rectangle
{
    // The Rectangle structure contains a reference type member.
    public ShapeInfo RectInfo;
    public int RectTop;
    public int RectLeft;
    public int RectBottom;
    public int RectRight;

    public Rectangle(string info, int top, int left, int bottom, int right)
    {
        RectInfo = new ShapeInfo(info);
        RectTop = top;
        RectLeft = left;
        RectBottom = bottom;
        RectRight = right;
    }

    public void Display()
    {
        Console.WriteLine($"String = {RectInfo.InfoString}, Top = {RectTop}, Bottom = {RectBottom}, Left = {RectLeft}, Right = {RectRight}.");
    }
}
