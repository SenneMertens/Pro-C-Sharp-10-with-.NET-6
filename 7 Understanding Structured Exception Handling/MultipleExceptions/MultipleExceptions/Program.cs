using MultipleExceptions;

Console.WriteLine("** Multiple Exceptions **");

Console.WriteLine();

Car myCar = new Car("Rusty", 90);

try
{
    // Trip the argument out of range exception.
    myCar.Accelerate(-10);
}
// This will cause a compile error.
// catch (Exception e)
// {
//     Console.WriteLine(e.Message);
// }
catch (CarIsDeadException e) when (e.ErrorTimeStamp.DayOfWeek != DayOfWeek.Friday)
{
    // This code will only execute if the when clause evaluates to true.
    Console.WriteLine(e.Message);

    try
    {
        FileStream fileStream = File.Open(@"C:\CarErrors.txt", FileMode.Open);
    }
    catch (Exception e2)
    {
        // This causes a compile error as InnerException is read-only.
        // e.InnerException = e2;

        // Throw an exception that records the new exception, as well as the message of the first exception.
        throw new CarIsDeadException(e.CauseOfError, e.ErrorTimeStamp, e.Message, e2);
    }
}
catch (ArgumentOutOfRangeException e)
{
    Console.WriteLine(e.Message);
}
// This will catch any other exception beyond CarIsDeadException or ArgumentOutOfRangeException.
catch (Exception e)
{
    Console.WriteLine(e.Message);
}
finally
{
    // This always occurs. Exception or not.
    myCar.CrankTunes(false);
}
