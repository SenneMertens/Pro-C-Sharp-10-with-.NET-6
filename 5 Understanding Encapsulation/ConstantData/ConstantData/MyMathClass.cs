using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstantData
{
    class MyMathClass
    {
        public const double PI = 3.14;
        public static readonly double PIReadOnly;

        static MyMathClass() 
        {
            // Read-only fields can only be assigned inside of constructors and nowhere else.
            PIReadOnly = 3.1444;
        }
    }
}
