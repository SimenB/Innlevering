using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UltimateSnake
{
    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Point(int x = 0, int y = 0)
        {
            X = x;
            Y = y;
        }

        // TODO: What?
        public static bool Clamped(Point value, Point minPosition, Point maxPosition)
        {
            return value.X >= minPosition.X && value.X <= maxPosition.X && value.Y >= minPosition.Y &&
                   value.Y <= maxPosition.Y;
        }
    }
}
