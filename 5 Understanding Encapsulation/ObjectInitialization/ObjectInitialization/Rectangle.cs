using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectInitialization
{
    class Rectangle
    {
        private Point _topLeft = new Point();
        private Point _bottomRight = new Point();

        public Point TopLeft
        {
            get { return _topLeft; }
            set { _topLeft = value; }
        }

        public Point BottomRight
        {
            get { return _bottomRight; }
            set { _bottomRight = value; }
        }

        public void DisplayStats()
        {
            Console.WriteLine($"[TopLeft: {TopLeft.X}, {TopLeft.Y}, {TopLeft.Color} BottomRight: {BottomRight.X}, {BottomRight.Y}, {BottomRight.Color}]");
        }
    }
}
