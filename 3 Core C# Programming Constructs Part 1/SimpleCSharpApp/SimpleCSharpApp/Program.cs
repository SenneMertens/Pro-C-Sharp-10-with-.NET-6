Console.WriteLine("** My First C# App **");
Console.WriteLine();
Console.WriteLine("Hello World!");

// Process any incoming args.
for (int i = 0; i < args.Length; i++)
{
    Console.WriteLine($"Arg: {args[i]}.");
}

// Notice you have no need to check the size of an array when using a foreach loop.
// Process any incoming args using a foreach loop.
foreach (string arg in args)
{
    Console.WriteLine($"Arg: {arg}.");
}

// Get arguments using the System.Environment.GetCommandLineArgs() method.
string[] arguments = Environment.GetCommandLineArgs();

foreach (string arg in arguments)
{
    Console.WriteLine($"Arg: {arg}.");
}

ShowEnvironmentDetails();

static void ShowEnvironmentDetails()
{
    foreach (string drive in Environment.GetLogicalDrives())
    {
        Console.WriteLine($"Drive: {drive}.");
    }

    Console.WriteLine($"Operating system: {Environment.OSVersion}.");
    Console.WriteLine($"Number of processors: {Environment.ProcessorCount}.");
    Console.WriteLine($".NET Core version: {Environment.Version}.");
}
