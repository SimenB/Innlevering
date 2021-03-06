﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ConsoleBlank.cs" company="MarSim">
//   Copyright © 2012
// </copyright>
// <summary>
//   A blank spot, used to overwrite the end of the snake
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace UltimateSnake.GameObjects
{
    using UltimateSnake.Utilities;

    /// <summary>
    /// A blank spot, used to overwrite the end of the snake
    /// </summary>
    public class ConsoleBlank : DrawableGameObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConsoleBlank"/> class.
        /// </summary>
        public ConsoleBlank() : this(new Point())
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConsoleBlank"/> class.
        /// </summary>
        /// <param name="pos">
        /// The position to be set
        /// </param>
        public ConsoleBlank(Point pos)
        {
            this.Color = "Black";
            this.Texture = ' ';
            this.Position = pos;
        }
    }
}
