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

        // TODO: This doesn't make sense here, and if it did, we would have to implement support for directional changes and stuffs idek man
        public static bool Clamped(Point value, Point minPosition, Point maxPosition)
        {
            //return value.X >= minPosition.X && value.X <= maxPosition.X && value.Y >= minPosition.Y &&
            //       value.Y <= maxPosition.Y;

            // Keeps the snake in place
            if (value.X < minPosition.X)
                value.X = minPosition.X;
            if (value.X > maxPosition.X)
                value.X = maxPosition.X;
            if (value.Y < minPosition.Y)
                value.Y = minPosition.Y;
            if (value.Y > maxPosition.Y)
                value.Y = maxPosition.Y;
        }
    }
}
