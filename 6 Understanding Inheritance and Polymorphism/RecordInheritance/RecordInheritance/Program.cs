using RecordInheritance;

Console.WriteLine("** Record Inheritance **");

Console.WriteLine();

Car myCar = new Car("Honda", "Pilot", "Blue");
MiniVan myMiniVan = new MiniVan("Honda", "Pilot", "Blue", 10);

Console.WriteLine($"Checking if MiniVan 'is-a' Car: {myMiniVan is Car}.");

Console.WriteLine();

Console.WriteLine("Record types with positional parameters:");

PositionalCar myPositionalCar = new PositionalCar("Honda", "Pilot", "Blue");
PositionalMiniVan myPositionalMiniVan = new PositionalMiniVan("Honda", "Pilot", "Blue", 10);

Console.WriteLine($"Checking if PositionalMiniVan 'is-a' PositionalCar: {myPositionalMiniVan is PositionalCar}.");

MotorCycle myMotorCycle = new FancyScooter("Harley", "Lowrider", "Gold");
Console.WriteLine($"Checking if MotorCycle 'is-a' FancyScooter: {myMotorCycle is FancyScooter}.");

MotorCycle myMotorCycle2 = myMotorCycle with { Make = "Harley", Model = "Lowrider" };
Console.WriteLine($"Checking if MotorCycle 'is-a' FancyScooter: {myMotorCycle is FancyScooter}.");

Console.WriteLine();

Console.WriteLine("Equality testing with inherited record types:");

MotorCycle myMotorCycle3 = new MotorCycle("Harley", "Lowrider");
Scooter myScooter1 = new Scooter("Harley", "Lowrider");

Console.WriteLine($"Checking if MotorCycle and Scooter are equal: {Equals(myMotorCycle3, myScooter1)}.");

MotorCycle myScooterMotorCycle = new Scooter("Harley", "Lowrider");

// The reason for the 2 not being equal is because the equality check with record types uses the runtime type, not the declared type.
Console.WriteLine($"Checking if MotorCycle and Scooter Motorcycle are equal: {Equals(myMotorCycle3, myScooterMotorCycle)}.");

Console.WriteLine();

Console.WriteLine("Deconstructor behavior with inherited record types:");

MotorCycle myMotorCycle4 = new FancyScooter("Harley", "Lowrider", "Gold");

// Doesn't deconstruct the FancyColor property since the declared record type is MotorCycle.
var (make1, model1) = myMotorCycle4;

// Add a cast to the derived type, then all the positional properties of the derived type are deconstructed.
var (make2, model2, fancyColor2) = (FancyScooter)myMotorCycle4;
