using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharpConsoleApp
{
    public class SportsCar : Car
    {
        public string GetPetName()
        {
            PetName = "Red";

            return PetName;
        }
    }
}