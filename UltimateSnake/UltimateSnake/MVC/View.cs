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
    using System.Collections.Generic;
    using System.Drawing;

    using GameObjects;

    public abstract class View
    {
        /// <summary>
        /// The instance.
        /// </summary>
        protected static View instance;

        /// <summary>
        /// Gets or sets a mapping of colors
        /// </summary>
        protected virtual Dictionary<Color, object> ColorMap { get; set; }

        /// <summary>
        /// Draw all draw-able objects
        /// </summary>
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
        /// The list of objects to draw
        /// </param>
        protected virtual void Draw(List<DrawableGameObject> objList)
        {
            foreach (DrawableGameObject gameObject in objList)
            {
                this.Draw(gameObject);
            }
        }
    }
}