using ObjectClassOverrides;

Console.WriteLine("** Object Class Overrides **");

Console.WriteLine();

Person person1 = new Person();

// Using the inherited members of System.Object.
Console.WriteLine($"ToString: {person1.ToString()}.");
Console.WriteLine($"Hash code: {person1.GetHashCode()}.");
Console.WriteLine($"Type: {person1.GetType()}.");

// Make some other references to person1.
Person person2 = person1;
object myObject = person2;

// The references are point to the same object in memory.
if (myObject.Equals(person1) && person2.Equals(myObject))
{
    Console.WriteLine("Same instance.");
}

Console.WriteLine();

// We wany these to be identical to test the Equals() and GetHashCode() methods.
Person person3 = new Person("Homer", "Simpson", 50, "111-11-1111");
Person person4 = new Person("Homer", "Simpson", 50, "111-11-1111");

// Get the stringified version of objects.
Console.WriteLine($"{person3.ToString()}.");
Console.WriteLine($"{person4.ToString()}.");

// Test the overridden Equals method.
Console.WriteLine($"Does person3 equal person4? {person3.Equals(person4)}.");

// Test the hash codes using the hash of the SocialSecurityNumber field.
Console.WriteLine($"Do person3 and person4 have the same hash codes? {person3.GetHashCode() == person4.GetHashCode()}.");

// Change the Age field of person4 and test again.
person4.Age = 45;

Console.WriteLine($"{person3.ToString()}.");
Console.WriteLine($"{person4.ToString()}.");
Console.WriteLine($"Does person3 equal person4? {person3.Equals(person4)}.");
Console.WriteLine($"Do person3 and person4 have the same hash codes? {person3.GetHashCode() == person4.GetHashCode()}.");

Console.WriteLine();

StaticMembersOfObject();

static void StaticMembersOfObject()
{
    Person person5 = new Person("Sally", "Jones", 4, "");
    Person person6 = new Person("Sally", "Jones", 4, "");

    Console.WriteLine($"Do person5 and person6 have the same state? {object.Equals(person5, person6)}.");
    Console.WriteLine($"Are person5 and person6 pointing to the same object? {object.ReferenceEquals(person5, person6)}.");
}
