using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomaticProperties
{
    class Car
    {
        // Automatic properties. No need to define backing fields.
        public string PetName { get; set; }
        public int Speed { get; set; }
        public string Color { get; set; }

        public void DisplayStats()
        {
            Console.WriteLine($"Car name: {PetName}.");
            Console.WriteLine($"Speed: {Speed}.");
            Console.WriteLine($"Color: {Color}.");
        }
    }
}
