// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DrawableGameObject.cs" company="MarSimJør">
//   Copyright © 2012
// </copyright>
// <summary>
//   Defines the DrawableGameObject type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace UltimateSnake.GameObjects
{
    using UltimateSnake.Utilities;

    public abstract class DrawableGameObject
    {
        public Point Position { get; protected set; }

        public object Texture { get; protected set; }

        public string Color { get; protected set; }

        public bool HasChanged { get; protected set; }
    }
}