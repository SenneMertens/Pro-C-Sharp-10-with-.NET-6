using BasicInheritance;

Console.WriteLine("** Basic Inheritance **");

Console.WriteLine();

Car myCar = new Car(80) { Speed = 50 };

Console.WriteLine($"My Car is going {myCar.Speed} MPH.");

Console.WriteLine();

MiniVan myMiniVan = new MiniVan { Speed = 10 };

Console.WriteLine($"My MiniVan is going {myMiniVan.Speed} MPH.");

// Error. Can't access private members.
// myMiniVan._currentSpeed = 55;
