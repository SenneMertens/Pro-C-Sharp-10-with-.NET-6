using Employees;

Console.WriteLine("** Employees **");

Console.WriteLine();

SalesPerson fred = new SalesPerson() { Age = 31, Name = "Fred"};

Manager chucky = new Manager("Chucky", 50, 92, 100000, "333-23-2322", 9000);

chucky.GiveBonus(300);
chucky.DisplayStats();

SalesPerson fran = new SalesPerson("Fran", 43, 93, 3000, "032-32-3232", 31);

fran.GiveBonus(200);
fran.DisplayStats();

Console.WriteLine();

CastingExamples();

Console.WriteLine();

GivePromotion(fran);

static void CastingExamples()
{
    // A Manager 'is-a' System.Object, so we can store a Manager reference in an object variable.
    object frank = new Manager("Frank Zappa", 9, 3000, 40000, "111-11-1111", 5);

    // The general System.Object is higher up the inheritance chain, hence th compiler will not allow for an implicit cast.
    // GivePromotion(frank);

    GivePromotion((Manager)frank);

    // A Manager 'is-an' Employee too.
    Employee moonUnit = new Manager("MoonUnit Zappa", 2, 3001, 20000, "101-11-1321", 1);

    GivePromotion(moonUnit);

    // A PartTimeSalesPerson 'is-a' SalesPerson.
    SalesPerson jill = new PartTimeSalesPerson("Jill", 834, 3002, 100000, "111-12-1119", 90);

    GivePromotion(jill);
}

static void GivePromotion(Employee employee)
{
    Console.WriteLine($"{employee.Name} was promoted.");

    // if (employee is SalesPerson)
    // {
    //     Console.WriteLine($"{employee.Name} made {((SalesPerson)employee).SalesNumber} sales.");
    // }
    // else if (employee is Manager)
    // {
    //     Console.WriteLine($"{employee.Name} has {((Manager)employee).StockOptions} stock options.");
    // }

    // Check if employee is SalesPerson. If so, assign to variable salesPerson.
    // if (employee is SalesPerson salesPerson)
    // {
    //     Console.WriteLine($"{salesPerson.Name} made {salesPerson.SalesNumber} sales.");
    // }
    // Check if employee is Manager. If so, assign to variable manager.
    // else if (employee is Manager manager)
    // {
    //     Console.WriteLine($"{manager.Name} has {manager.StockOptions} stock options.");
    // }
    // The discard 'var _' will match everything.
    // else if(employee is var _)
    // {
    //     Console.WriteLine($"Unable to promote {employee.Name}. Wrong employee type.");
    // }

    // if (employee is not SalesPerson and not Manager)
    // {
    //     Console.WriteLine($"Unable to promote {employee.Name}. Wrong employee type.");
    // }

    switch (employee)
    {
        case SalesPerson salesPerson when salesPerson.SalesNumber > 5:
            Console.WriteLine($"{salesPerson.Name} made {salesPerson.SalesNumber} sales.");
            break;
        case Manager manager:
            Console.WriteLine($"{manager.Name} has {manager.StockOptions} stock options.");
            break;
        case Employee _:
            Console.WriteLine($"Unable to promote {employee.Name}. Wrong employee type.");
            break;
    }
}
