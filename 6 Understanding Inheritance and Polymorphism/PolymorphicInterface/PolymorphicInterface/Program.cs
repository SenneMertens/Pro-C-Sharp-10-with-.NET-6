using PolymorphicInterface;

Console.WriteLine("** Polymorphic Interface **");

Console.WriteLine();

// Hexagon myHexagon = new Hexagon("Beth");
// myHexagon.Draw();
//
// Circle myCircle = new Circle("Cindy");
// Calls the base class implementation.
// myCircle.Draw();

// Make an array of Shape-compatible objects.
Shape[] myShapes = { new Circle(), new Hexagon(), new Hexagon("Mick"), new Circle("Beth"), new Hexagon("Linda") };

foreach (Shape shape in myShapes)
{
    shape.Draw();
}

Console.WriteLine();

ThreeDCircle myThreeDCircle = new ThreeDCircle();

// This calls the Draw() method of the ThreeDCircle class.
myThreeDCircle.Draw();

// This calls the Draw() method of the Circle parent class.
((Circle)myThreeDCircle).Draw();
