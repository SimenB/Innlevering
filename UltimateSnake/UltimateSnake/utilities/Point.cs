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
    }
}
