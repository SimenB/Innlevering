﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Point.cs" company="MarSimJør">
//   Copyright © 2012
// </copyright>
// <summary>
//   The point
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace UltimateSnake.Utilities
{
    /// <summary>
    /// The point
    /// </summary>
    public class Point
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Point"/> class.
        /// </summary>
        /// <param name="x">
        /// The x.
        /// </param>
        /// <param name="y">
        /// The y.
        /// </param>
        public Point(int x = 0, int y = 0)
        {
            this.X = x;
            this.Y = y;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Point"/> class. 
        /// Clones the point
        /// </summary>
        /// <param name="p">
        /// The point you want to clone
        /// </param>
        public Point(Point p)
        {
            this.X = p.X;
            this.Y = p.Y;
        }

        /// <summary>
        /// Gets a Point with everything set to zero
        /// </summary>
        public static Point Zero
        {
            get { return new Point(); }
        }

        /// <summary>
        /// Gets or sets the x.
        /// </summary>
        public int X { get; set; }

        /// <summary>
        /// Gets or sets the y.
        /// </summary>
        public int Y { get; set; }
    }
}