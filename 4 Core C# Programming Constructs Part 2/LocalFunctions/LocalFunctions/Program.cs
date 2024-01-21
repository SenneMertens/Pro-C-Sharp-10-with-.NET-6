Console.WriteLine("** Local Functions **");

Console.WriteLine();

// Calls the original version of Add().
Console.WriteLine(Add(10, 10));

Console.WriteLine();

// Calls the updated version of Add().
Console.WriteLine(AddWrapper(10, 10));

Console.WriteLine();

// Local function causes an expected side effect/
Console.WriteLine(AddWrapperWithSideEffect(10, 10));

Console.WriteLine();

// Adding the static access modifier resolves the problem.
Console.WriteLine(AddWrapperWithStatic(10, 10));

static int Add(int x, int y)
{
    // Do some validation here.
    return x + y;
}

static int AddWrapper(int x, int y)
{
    // Do some validation here.
    return Add();

    int Add()
    {
        return x + y;
    }
}

static int AddWrapperWithSideEffect(int x, int y)
{
    // Do some validation here.
    return Add();

    int Add()
    {
        x += 1;

        return x + y;
    }
}

static int AddWrapperWithStatic (int x, int y)
{
    // Do some validation here.
    return Add(x, y);

    static int Add(int x, int y)
    {
        return x + y;
    }
}
