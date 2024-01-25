using ObjectInitialization;

Console.WriteLine("** Object Initialzation **");

Console.WriteLine();

Console.WriteLine("Object initialization syntax:");

// Make a Point by setting each property manually.
Point firstPoint = new Point();
firstPoint.X = 10;
firstPoint.Y = 10;

firstPoint.DisplayStats();

// Make a Pount via a custom constructor.
Point secondPoint = new Point(20, 20);

secondPoint.DisplayStats();

// Make a Point using object initialization syntax.
Point thirdPoint = new Point() { X = 30, Y = 30 };

thirdPoint.DisplayStats();

Console.WriteLine();

Console.WriteLine("Init-only setters:");

// Make a read-only point, using init-only setters, after construction. 
// Here, the default constructor is called explicity.
PointReadOnlyAfterCreation firstReadOnlyPoint = new PointReadOnlyAfterCreation(20, 20);

firstReadOnlyPoint.DisplayStats();


// Or make a read-only point, using init-only setters, using the object initialization syntax.
// Here, the default constructor is called implicity.
PointReadOnlyAfterCreation secondReadOnlyPoint = new PointReadOnlyAfterCreation { Y = 30, X = 30 };

secondReadOnlyPoint.DisplayStats();

// The next 2 lines will not compile.
// secondReadOnlyPoint.X = 10;
// secondReadOnlyPoint.Y = 10;

// Calling a more interesting custom constructor with the initialization syntax.
Point goldPoint = new Point(PointColorEnum.Gold) { X = 90, Y = 20 };

goldPoint.DisplayStats();

Console.WriteLine();

Console.WriteLine("Initializing data with initialization syntax:");

// Create and initialize a Rectangle.
Rectangle rectangle1 = new Rectangle
{
    TopLeft = new Point { X = 10, Y = 20 },
    BottomRight = new Point { X = 200, Y = 200 }
};

// Here is the traditional approach to establish a similar Rectangle.
// Rectangle rectangle2 = new Rectangle();
//
// Point point1 = new Point();
// point1.X = 10;
// point1.Y = 10;
//
// rectangle2.TopLeft = point1;
//
// Point point2 = new Point();
// point2.X = 200;
// point2.Y = 200;
//
// rectangle2.BottomRight = point2;
