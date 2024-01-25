using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectInitialization
{
    class Point
    {
        public int X {  get; set; }
        public int Y { get; set; }
        public PointColorEnum Color { get; set; }

        public Point() : this(PointColorEnum.BloodRed) { }

        public Point(PointColorEnum pointColor)
        {
            Color = pointColor;
        }

        public Point(int xVal, int yVal)
        {
            X = xVal;
            Y = yVal;
            Color = PointColorEnum.Gold;
        }

        public void DisplayStats()
        {
            Console.WriteLine($"[{X}, {Y}]");
            Console.WriteLine($"Point is {Color}.");
        }
    }
}
