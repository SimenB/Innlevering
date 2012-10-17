// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Blank.cs" company="MarSimJør">
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
    public class Blank : DrawableGameObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Blank"/> class.
        /// </summary>
        public Blank()
        {
            this.Position = new Point();
            this.Color = "Black";
            this.Texture = ' ';
        }
    }
}
