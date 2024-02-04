using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicInheritance
{
    // MiniVan derives from Car.
    // The MiniVan class cannot be extended.
    sealed class MiniVan : Car
    {
        public void TestMethod()
        {
            // This works, as you can access public members of a parent within a derived type.
            Speed = 10;

            // Error. Can't access private memvers within a derived type.
            // _currentSpeed = 10;
        }       
    }
}
