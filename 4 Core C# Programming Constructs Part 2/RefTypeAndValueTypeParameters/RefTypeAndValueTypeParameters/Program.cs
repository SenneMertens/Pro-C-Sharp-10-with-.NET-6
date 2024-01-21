Console.WriteLine("** Reference ype and Value Type Parameters **");

Console.WriteLine();

// Passing reference types by value.
Console.WriteLine("Passing a Person object by value:");

Person fred = new Person("Fred", 12);

Console.Write($"Before the value call, Person is: ");
fred.Display();

SendAnObjectByValue(fred);

Console.Write($"Before the value call, Person is: ");
fred.Display();

Console.WriteLine();

// Passing reference types by reference.
Console.WriteLine("Passing a Person object by reference:");

Person mel = new Person("Mel", 23);

Console.Write("Before the reference call, Person is: ");
mel.Display();

SendAnObjectByReference(ref mel);

Console.Write("After the reference call, Person is: ");
mel.Display();

static void SendAnObjectByValue(Person person)
{
    person.personAge = 99;

    // Will the caller see this reassignment?
    person = new Person("Nikki", 99);
}

static void SendAnObjectByReference(ref Person person)
{
    person.personAge = 555;

    // "person" is now pointing to a new object on the heap.
    person = new Person("Nikki", 999);
}

class Person
{
    public string personName;
    public int personAge;

    public Person() { }

    public Person(string name, int age)
    {
        personName = name;
        personAge = age;
    }

    public void Display()
    {
        Console.WriteLine($"Name: {personName}, Age: {personAge}.");
    }
}
