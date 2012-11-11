// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SnakeBody.cs" company="MarSim">
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
        public SnakeBody()
        {
            this.Color = "Green";
            this.Position = new Point();
            this.ConsoleTexture = 'O';
        }
    }
}
