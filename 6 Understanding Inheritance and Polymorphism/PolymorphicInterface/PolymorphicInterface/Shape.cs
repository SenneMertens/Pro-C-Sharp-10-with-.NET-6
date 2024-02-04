using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphicInterface
{
    abstract class Shape
    {
        public string PetName;

        // A protected constructor.
        protected Shape(string name = "No name")
        {
            PetName = name;
        }

        // An abstract method provides no default implementation and forces all child classes to define how this method will be rendered.
        public abstract void Draw();
    }
}
