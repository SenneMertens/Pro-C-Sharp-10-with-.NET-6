using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClass
{
    public class Motorcycle
    {
        public int driverIntensity;
        public string driverName;

        // Put back the default constructor, which will set all data members to default values.
        // public Motorcycle() { }

        // Our custom constructor.
        // public Motorcycle(int intensity)
        // {
        //     if (intensity > 10)
        //     {
        //         intensity = 10;
        //     }
        //     driverIntensity = intensity;
        //     }

        // Constructor chaining.
        // public Motorcycle()
        // {
        //     Console.WriteLine("In default constructor.");
        // }

        // public Motorcycle(int intensity) : this(intensity, "")
        // {
        //     Console.WriteLine("In constructor taking an int.");
        // }

        // public Motorcycle(string name) : this(0, name)
        // {
        //     Console.WriteLine("In constructor taking a string.");
        // }

        // This is the 'master' constructor that does all the real work.
        // public Motorcycle(int intensity, string name)
        // {
        //     Console.WriteLine("In the 'master' constructor.");
        //     if (intensity > 10)
        //     {
        //         intensity = 10;
        //     }
        //     driverIntensity = intensity;
        //     driverName = name;
        // }

        public Motorcycle(int intensity = 0, string name = "")
        {
            if (intensity > 10)
            {
                intensity = 10;
            }

            driverIntensity = intensity;
            driverName = name;
        }

        public void PopAWheely()
        {
            for (int i = 0; i <= driverIntensity; i++)
            {
                Console.WriteLine("Yee-haw!");
            }
        }

        public void SetDriverName(string name) => this.driverName = name;
    }
}
