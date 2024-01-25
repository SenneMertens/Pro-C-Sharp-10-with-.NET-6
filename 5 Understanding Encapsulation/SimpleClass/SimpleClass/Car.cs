using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClass
{
    public class Car
    {
        // The 'state' of the Car.
        public string petName;
        public int currentSpeed;

        // A custom default constructor.
        public Car()
        {
            petName = "Chuck";
            currentSpeed = 10;
        }

        // Here, currentSpeed will receive the default value of an int (0).
        // public Car(string name)
        // {
        //     petName = name;
        // }

        // The previous constructor rewritten as an expression-bodied member.
        public Car(string name) => petName = name;

        // Let the caller set the full state of the Car.
        public Car(string name, int speed)
        {
            petName = name;
            currentSpeed = speed;
        }

        // Custom constructor with an out parameter.
        public Car(string name, int speed, out bool inDanger)
        {
            petName += name;
            currentSpeed = speed;

            if (currentSpeed > 100)
            {
                inDanger = true;
            }
            else
            {
                inDanger = false;
            }
        }

        // The functionality of the Car.
        public void PrintState()
            => Console.WriteLine($"{petName} is going {currentSpeed} MPH.");

        public void SpeedUp(int delta)
            => currentSpeed += delta;
    }
}
