// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SnakeHead.cs" company="MarSim">
//   Copyright © 2012
// </copyright>
// <summary>
//   Defines the SnakeHead type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace UltimateSnake.GameObjects
{
    using UltimateSnake.Utilities;

    /// <summary>
    /// The head of the snake
    /// </summary>
    public class SnakeHead : DrawableGameObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SnakeHead"/> class.
        /// </summary>
        /// <param name="p">
        /// The position
        /// </param>
        public SnakeHead(Point p)
        {
            this.Position = p;
            this.ConsoleTexture = '@';
            this.Color = "Green";
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SnakeHead"/> class.
        /// </summary>
        public SnakeHead() : this(new Point())
        {
        }
    }
}