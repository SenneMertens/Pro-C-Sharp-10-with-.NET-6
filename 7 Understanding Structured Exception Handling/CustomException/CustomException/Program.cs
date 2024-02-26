using CustomException;

Console.WriteLine("** Custom Exceptions **");

Console.WriteLine();

Car myCar = new Car("Rusty", 90);

try
{
    myCar.Accelerate(50);
}
catch (CarIsDeadException e)
{
    Console.WriteLine(e.Message);
    Console.WriteLine(e.ErrorTimeStamp);
    Console.WriteLine(e.CauseOfError);
}
