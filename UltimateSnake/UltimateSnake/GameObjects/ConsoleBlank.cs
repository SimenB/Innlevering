// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ConsoleBlank.cs" company="MarSimJør">
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

        public ConsoleBlank(Point pos)
        {
            this.Color = "Black";
            this.Texture = ' ';
            this.Position = pos;
        }
    }
}
