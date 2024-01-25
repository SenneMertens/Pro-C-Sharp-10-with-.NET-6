using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomaticProperties
{
    class Garage
    {
        // The hidden int backing field is set to 1.
        public int NumberOfCars { get; set; } = 1;

        // The hidden Car backing field is set to a new Car object.
        public Car MyAuto {  get; set; } = new Car();

        public Garage() 
        {
            // NumberOfCars = 1;
            // MyAuto = new Car();
        }

        public Garage(int numberOfCars, Car car)
        {
            NumberOfCars += numberOfCars;
            MyAuto = car;
        }
    }
}
