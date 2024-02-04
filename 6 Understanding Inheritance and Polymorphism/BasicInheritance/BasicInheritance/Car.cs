using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicInheritance
{
    // A simple base class.
    class Car
    {
        private int _currentSpeed;
        public readonly int MaxSpeed;

        public int Speed
        {
            get { return _currentSpeed; }
            set
            {
                _currentSpeed = value;

                if (_currentSpeed > MaxSpeed)
                {
                    _currentSpeed = MaxSpeed;
                }
            }
        }

        public Car()
        {
            MaxSpeed = 55;
        }

        public Car(int max)
        {
            MaxSpeed = max;
        }
    }
}
