// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DrawableGameObject.cs" company="MarSim">
//   Copyright © 2012
// </copyright>
// <summary>
//   Defines the DrawableGameObject type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace UltimateSnake.GameObjects
{
    using UltimateSnake.Utilities;

    /// <summary>
    /// A draw-able game object
    /// </summary>
    public abstract class DrawableGameObject
    {
        /// <summary>
        /// Gets or sets the position of the object
        /// </summary>
        public Point Position { get; protected set; }

        /// <summary>
        /// Gets or sets the texture of the object
        /// </summary>
        public object Texture { get; protected set; }

        public char ConsoleTexture { get; set; }

        /// <summary>
        /// Gets or sets the color of the object
        /// </summary>
        public string Color { get; protected set; }
    }
}