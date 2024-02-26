using SimpleException;
using System.Collections;

Console.WriteLine("** Simple Exception **");

Console.WriteLine();

Car myCar = new Car("Zippy", 20);

myCar.CrankTunes(true);

try
{
    for (int i = 0; i < 10; i++)
    {
        myCar.Accelerate(10);
    }
}
catch (Exception e)
{
    Console.WriteLine("Error:");
    // The System.Exception.TargetSite read-only property returns a MethodBase object, which describes numerous details about the method that threw the exception. Invoking the ToString() method will identify the method by name.
    Console.WriteLine($"Method: {e.TargetSite}.");
    // The MethodBase.DeclaringType property determines the fully qualified name of the class that threw the error.
    Console.WriteLine($"Class defining member: {e.TargetSite.DeclaringType}.");
    // The MethodBase.MemberType property identifies which type of member (such as a property versus a method) where this exception originated.
    Console.WriteLine($"Member type: {e.TargetSite.MemberType}.");
    // The System.Exception.Message read-only property returns a textual description of the given error.
    Console.WriteLine($"Message: {e.Message}.");
    // The System.Exception.Source property gets or sets the name of the assembly or object that threw the current exception.
    Console.WriteLine($"Source: {e.Source}.");
    // The System.Exception.StackTrace property allows you to identify the series of calls that resulted in the exception.
    Console.WriteLine($"Stack: {e.StackTrace}.");
    // The System.Exception.HelpLink property can be set to point the user to a specific URL or standard help file that contains more information.
    Console.WriteLine($"Help link: {e.HelpLink}.");
    // The System.Exception.Data property allows you to fill an Exception object with relevant auxiliary information.
    Console.WriteLine("Custom data: ");
    foreach(DictionaryEntry entry in e.Data)
    {
        Console.WriteLine($"{entry.Key}: {entry.Value}.");
    }
}

// The error has been handled, processing continues with the next statement.
Console.WriteLine("Outside of exception logic.");