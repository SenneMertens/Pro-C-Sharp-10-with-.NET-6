using Records;

Console.WriteLine("** Records **");

Console.WriteLine();

// Using object initialization.
Car myCar1 = new Car { Make = "Honda", Model = "Pilot", Color = "Blue" };

Console.WriteLine("My Car:");
DisplayCarStats(myCar1);

// Using the custom constructor.
Car myCar2 = new Car("Honda", "Pilot", "Blue");

Console.WriteLine("Another variable for my Car:");
DisplayCarStats(myCar2);

Console.WriteLine();

Console.WriteLine("Records:");

// Using object initialization.
// CarRecord myCarRecord1 = new CarRecord() { Make = "Honda", Model = "Pilot", Color = "Blue" };
//
// Console.WriteLine("My Car Record:");
// Console.WriteLine(myCarRecord1.ToString());

// Using the custom constructor.
CarRecord myCarRecord2 = new CarRecord("Honda", "Pilot", "Blue");

Console.WriteLine("Another variable for my Car Record:");
Console.WriteLine(myCarRecord2.ToString());

// Compiler error if the property is changed.
// myCarRecord2.Color = "Red";

Console.WriteLine();

Console.WriteLine("Deconstruction:");

CarRecord myCarRecord3 = new CarRecord("Honda", "Pilot", "Blue");

myCarRecord3.Deconstruct(out string make, out string model, out string color);

Console.WriteLine($"Make: {make}, Model: {model}, Color: {color}.");

myCarRecord3.Deconstruct(out string a, out string b, out string c);

Console.WriteLine($"Make: {a}, Model: {b}, Color: {c}.");

// The tuple syntax can also be used when deconstructing records.
var (tupleMake, tupleModel, tupleColor) = myCarRecord3;

Console.WriteLine($"Make: {tupleMake}, Model: {tupleModel}, Color: {tupleColor}.");

Console.WriteLine();

Console.WriteLine("Record type equality:");

Console.WriteLine($"Are myCarRecord2 and myCarRecord3 the same? {myCarRecord2.Equals(myCarRecord3)}.");
Console.WriteLine($"Are myCarRecord2 and myCarRecord3 the same reference? {ReferenceEquals(myCarRecord2, myCarRecord3)}.");
Console.WriteLine($"Are myCarRecord2 and myCarRecord3 the same? {myCarRecord2 == myCarRecord3}.");
Console.WriteLine($"Are myCarRecord2 and myCarRecord3 not the same? {myCarRecord2 != myCarRecord3}.");

Console.WriteLine();

Console.WriteLine("Car Record copy results:");

CarRecord carRecordCopy = myCarRecord2;

Console.WriteLine($"Are myCarRecord2 and carRecordCopy the same? {myCarRecord2.Equals(myCarRecord2)}");
Console.WriteLine($"Are myCarRecord2 and carRecordCopy the same reference? {ReferenceEquals(myCarRecord2, carRecordCopy)}");

Console.WriteLine();

Console.WriteLine("Car record copy using the 'with' expression results:");

CarRecord ourOtherCar = myCarRecord2 with { Model = "Odyssey" };

Console.WriteLine($"My copied Car: {ourOtherCar.ToString()}");
Console.WriteLine($"Are myCarRecord2 and ourOtherCar the same? {myCarRecord2.Equals(ourOtherCar)}.");
Console.WriteLine($"Are myCarRecord2 and ourOtherCar the same reference? {ReferenceEquals(myCarRecord2, ourOtherCar)}");


static void DisplayCarStats(Car car)
{
    Console.WriteLine($"Car make: {car.Make}.");
    Console.WriteLine($"Car model: {car.Model}.");
    Console.WriteLine($"Car color: {car.Color}.");
}
