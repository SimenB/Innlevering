using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UltimateSnake
{
    public class Point
    {
        public Point(int x = 0, int y = 0)
        {
            this.X = x;
            this.Y = y;
        }

        public Point(Point p)
        {
            this.X = p.X;
            this.Y = p.Y;
        }

        public int X { get; set; }
        public int Y { get; set; }

        /// <summary>
        /// Gets a Point with everything set to zero
        /// </summary>
        public static Point Zero
        {
            get { return new Point(); }
        }

        // TODO: This doesn't make sense here, and if it did, we would have to implement support for directional changes and stuffs idek man
        public static Point Clamp(Point value, Point minPosition, Point maxPosition)
        {
            //return value.X >= minPosition.X && value.X <= maxPosition.X && value.Y >= minPosition.Y &&
            //       value.Y <= maxPosition.Y;

            // Keeps the snake in place
            if (value.X < minPosition.X)
                value.X = minPosition.X;
            else if (value.X > maxPosition.X)
                value.X = maxPosition.X;
            
            if (value.Y < minPosition.Y)
                value.Y = minPosition.Y;
            else if (value.Y > maxPosition.Y)
                value.Y = maxPosition.Y;

            return value;
        }
    }
}
