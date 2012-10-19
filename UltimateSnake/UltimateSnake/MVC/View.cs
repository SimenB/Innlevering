// --------------------------------------------------------------------------------------------------------------------
// <copyright file="View.cs" company="MarSimJør">
//   Copyright © 2012
// </copyright>
// <summary>
//   Defines the View type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace UltimateSnake.MVC
{
    using System;
    using System.Collections.Generic;
    using System.Drawing;

    using GameObjects;

    public abstract class View
    {
        protected static View instance;
        
        /// <summary>
        /// A mapping of colors
        /// </summary>
        protected abstract Dictionary<Color, object> ColorMapping { get; set; }

        /// <summary>
        /// Gets the instance. If it's not initialized, do so
        /// </summary>
        public static View Instance { get; protected set; }

        public void Draw()
        {
            this.Draw(Loot.Instance.GetGameObject());
            this.Draw(Snake.Instance.GetGameObject());
        }

        /// <summary>
        /// Draw a char
        /// </summary>
        /// <param name="obj">
        /// The object to draw
        /// </param>
        protected abstract void Draw(DrawableGameObject obj);

        /// <summary>
        /// Draw a char
        /// </summary>
        /// <param name="objList">
        /// The object List.
        /// </param>
        protected void Draw(IEnumerable<DrawableGameObject> objList)
        {
            foreach (DrawableGameObject gameObject in objList)
            {
                this.Draw(gameObject);
            }
        }
    }
}