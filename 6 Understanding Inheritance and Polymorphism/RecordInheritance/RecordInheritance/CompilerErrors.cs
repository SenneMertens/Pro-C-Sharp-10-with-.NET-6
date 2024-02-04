using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecordInheritance
{
    public class TestClass { }

    public record TestRecord { }

    // Classes caanot inherit from records.
    // public class Class1 : TestRecord { }

    // Records cannot inherit from classes.
    // public record Record : TestClass { }
}
