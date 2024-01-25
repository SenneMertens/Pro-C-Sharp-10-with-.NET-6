using ObjectOrientedProgramming;

Console.WriteLine("** Object-Oriented Programming **");

Console.WriteLine();

Car viper = new Car();

// The call is forwarded to Radio internally.
viper.TurnOnRadio(false);

Console.WriteLine();

Shape[] myShapes = new Shape[3];

myShapes[0] = new Hexagon();
myShapes[1] = new Circle();
myShapes[2] = new Hexagon();

foreach (Shape shape in myShapes)
{
    // Using the polymorphic interface.
    shape.Draw();
}

Console.WriteLine();

Book miniNovel = new Book();

// That is one hell of a book.
miniNovel.numberOfPages = 30_000_000;
