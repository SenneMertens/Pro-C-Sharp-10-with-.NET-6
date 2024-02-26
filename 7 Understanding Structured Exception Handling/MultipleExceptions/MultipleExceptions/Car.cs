using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleExceptions
{
    class Car
    {
        private bool _carIsDead;
        private readonly Radio _theMusicBox = new Radio();
        public const int MaxSpeed = 100;

        public int CurrentSpeed { get; set; } = 0;
        public string PetName { get; set; } = "";

        public Car() { }

        public Car (string name, int speed)
        {
            PetName = name;
            CurrentSpeed = speed;
        }

        public void CrankTunes(bool state)
        {
            // Delegate request to inner object.
            _theMusicBox.TurnOn(state);
        }

        public void Accelerate(int speed)
        {
            if (speed < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(speed), "Speed must be greater than 0.");
            }

            if (_carIsDead)
            {
                Console.WriteLine($"{PetName} is out of order.");
            }
            else
            {
                CurrentSpeed += speed;

                if (CurrentSpeed > MaxSpeed)
                {
                    CurrentSpeed = 0;
                    _carIsDead = true;

                    // Throw the custom CarIsDeadException.
                    throw new CarIsDeadException("You have a lead foot.", DateTime.Now, $"{PetName} has overheated.")
                    {
                        HelpLink = "http://www.CarsRUs.com"
                    };
                }

                Console.WriteLine($"Current speed: {CurrentSpeed}.");
            }
        }
    }
}
