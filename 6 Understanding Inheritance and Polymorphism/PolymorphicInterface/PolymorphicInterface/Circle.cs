using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphicInterface
{
    class Circle : Shape
    {
        public Circle() { }

        public Circle(string name) : base(name) { }

        // If we did not implement the abstract Draw() method, Circle would also be considered to be abstract. And as such, would have to be marked as abstract.
        public override void Draw()
        {
            Console.WriteLine($"Drawing {PetName} the Circle.");
        }
    }
}
