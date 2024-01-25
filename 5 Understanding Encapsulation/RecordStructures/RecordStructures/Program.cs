Console.WriteLine("** Record Structures **");

Console.WriteLine();

var recordStruct1 = new PointWithPositionalSyntax(2, 4, 6);
Console.WriteLine(recordStruct1.ToString());
recordStruct1.X = 8;
Console.WriteLine(recordStruct1.ToString());

var recordStruct2 = new PointWithPropertySyntax(2, 4, 6);
Console.WriteLine(recordStruct2.ToString());
recordStruct2.X = 8;
Console.WriteLine(recordStruct1.ToString());

var readOnlyRecordStruct1 = new ReadOnlyPointWithPositionalSyntax(2, 4, 6);
// Compiler error.
// readOnlyRecordStruct1.X = 8;

var readOnlyRecordStruct2 = new ReadOnlyPointWithPropertySyntax(2, 4, 6);
// Compiler error.
// readOnlyRecordStruct2.X = 8;

Console.WriteLine();

Console.WriteLine("Record structs deconstruction:");

var (x1, y1, z1) = recordStruct1;
Console.WriteLine($"X: {x1}, Y: {y1}, Z: {z1}");

var (x2, y2, z2) = readOnlyRecordStruct1;
Console.WriteLine($"X: {x2}, Y: {y2}, Z: {z2}");

recordStruct1.Deconstruct(out double x3 , out double y3, out double z3);
Console.WriteLine($"X: {x3}, Y: {y3}, Z: {z3}");

readOnlyRecordStruct1.Deconstruct(out double x4, out double y4, out double z4);
Console.WriteLine($"X: {x4}, Y: {y4}, Z: {z4}");

// Record structure using positional syntax.
public record struct PointWithPositionalSyntax(double X, double Y, double Z);

// Immutable (read-only) Record structure using positional syntax.
public readonly record struct ReadOnlyPointWithPositionalSyntax(double X, double Y, double Z);

// Record structure using standard properties.
public record struct PointWithPropertySyntax()
{
    public double X { get; set; } = default;
    public double Y { get; set; } = default;
    public double Z { get; set; } = default;

    public PointWithPropertySyntax(double x, double y, double z) : this()
    {
        X = x;
        Y = y;
        Z = z;
    }
}

// Record structure using standard properties.
public readonly record struct ReadOnlyPointWithPropertySyntax()
{
    public double X { get; init; } = default;
    public double Y { get; init; } = default;
    public double Z { get; init; } = default;

    public ReadOnlyPointWithPropertySyntax(double x, double y, double z) : this()
    {
        X = x;
        Y = y;
        Z = z;
    }
}