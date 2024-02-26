using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomException
{
    class Radio
    {
        public void TurnOn(bool power)
        {
            Console.WriteLine(power ? "Radio on." : "Radio off.");
        }
    }
}
