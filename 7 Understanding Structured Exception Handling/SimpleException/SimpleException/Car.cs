using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleException
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

                    // Use the 'throw' keyword to raise an exception.
                    throw new Exception($"{PetName} has overheated")
                    {
                        HelpLink = "http://CarsRUs.com/",
                        Data = { 
                            { "TimeStamp", $"The car exploded at {DateTime.Now}" },
                            { "Cause", "You have a lead foot" }
                            }
                    };
                }

                Console.WriteLine($"Current speed: {CurrentSpeed}.");
            }
        }
    }
}
