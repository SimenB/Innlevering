// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SnakeBody.cs" company="MarSimJør">
//   Copyright © 2012
// </copyright>
// <summary>
//   Body-part of the snake
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace UltimateSnake.GameObjects
{
    using UltimateSnake.Utilities;

    /// <summary>
    /// Body-part of the snake
    /// </summary>
    public class SnakeBody : DrawableGameObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SnakeBody"/> class.
        /// </summary>
        /// <param name="p">
        /// The position
        /// </param>
        public SnakeBody(Point p)
        {
            this.Position = p;
            this.Texture = 'O';
            this.Color = "Green";
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SnakeBody"/> class.
        /// </summary>
        public SnakeBody() : this(new Point())
        {
        }
    }
}
