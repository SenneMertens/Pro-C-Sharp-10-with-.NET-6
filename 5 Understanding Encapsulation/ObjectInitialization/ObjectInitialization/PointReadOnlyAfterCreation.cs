using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectInitialization
{
    class PointReadOnlyAfterCreation
    {
        public int X { get; init; }
        public int Y { get; init; }

        public PointReadOnlyAfterCreation() { }

        public PointReadOnlyAfterCreation(int xVal, int yVal)
        {
            X = xVal;
            Y = yVal;
        }

        public void DisplayStats()
        {
            Console.WriteLine($"Init-Only setter: [{X}, {Y}]");
        }
    }
}
