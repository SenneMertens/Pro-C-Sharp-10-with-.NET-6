using AutomaticProperties;

Console.WriteLine("** Automatic Properties **");

Console.WriteLine();

Car car = new Car();

car.PetName = "Frank";
car.Speed = 55;
car.Color = "Red";

Console.WriteLine($"Your Car is named: {car.PetName}.");

car.DisplayStats();

Console.WriteLine();

Garage garage = new Garage();

// OK. Prints the default value of 0.
Console.WriteLine($"Number of Cars: {garage.NumberOfCars}.");

// Runtime error. Backing field is currently null.
// Console.WriteLine($"Car petname: {garage.MyAuto.PetName}.");

Console.WriteLine();

// Put a Car in the Garage.
garage.MyAuto = car;

Console.WriteLine($"Number of Cars in the Garage: {garage.NumberOfCars}.");
Console.WriteLine($"Your Car is named: {garage.MyAuto.PetName}.");
