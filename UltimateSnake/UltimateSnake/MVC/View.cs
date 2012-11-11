// --------------------------------------------------------------------------------------------------------------------
// <copyright file="View.cs" company="MarSim">
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

    /// <summary>
    /// Parent-class that contains what's needed to expand with further views down the road
    /// </summary>
    public abstract class View
    {
        /// <summary>
        /// Gets or sets a mapping of colors
        /// </summary>
        protected virtual Dictionary<Color, object> ColorMap { get; set; }

        /// <summary>
        /// Draw for every view available
        /// </summary>
        public static void DrawAll()
        {
            ConsoleView.Draw();
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