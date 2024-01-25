using SimpleClass;

Console.WriteLine("** Class Types **");

Console.WriteLine();

// Allocate and configure a Car object.
Car myCar = new Car();

myCar.petName = "Henry";
myCar.currentSpeed = 10;

// Speed up the car a few times and print out the new state.
for (int i = 0; i <= 10; i++)
{
    myCar.SpeedUp(5);
    myCar.PrintState();
}

Console.WriteLine();

Console.WriteLine("Default constructor:");

// Invoking the default constructor.
Car chuck = new Car();

chuck.PrintState();

Console.WriteLine();

Console.WriteLine("Custom constructor:");

// Make a Car called Mary going 0 MPH.
Car mary = new Car("Mary");

mary.PrintState();

// Make a car called Daisy going 75 MPH.
Car daisy = new Car("Daisy", 75);

daisy.PrintState();

Console.WriteLine();

Console.WriteLine("Motorcycles:");

// Make a Motorcycle with a rider named Tiny?
Motorcycle motorcycle1 = new Motorcycle(5);

motorcycle1.SetDriverName("Tiny");
motorcycle1.PopAWheely();

// Prints an empty name value.
Console.WriteLine($"The rider name is {motorcycle1.driverName}.");

Console.WriteLine();

MakeMotorcycles();

static void MakeMotorcycles()
{
    // driverName = "", driverIntensity = 0
    Motorcycle motorcycle1 = new Motorcycle();
    Console.WriteLine($"Name: {motorcycle1.driverName}, Intensity: {motorcycle1.driverIntensity}.");

    // driverName = "", driverIntensity = 0
    Motorcycle motorcycle2 = new Motorcycle(name: "Tiny");
    Console.WriteLine($"Name: {motorcycle2.driverName}, Intensity: {motorcycle2.driverIntensity}.");

    // driverName = "", driverIntensity = 0
    Motorcycle motorcycle3 = new Motorcycle(7);
    Console.WriteLine($"Name: {motorcycle3.driverName}, Intensity: {motorcycle3.driverIntensity}.");
}
