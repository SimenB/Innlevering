﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="View.cs" company="MarSim">
//   Copyright © 2012
// </copyright>
// <summary>
//   Defines the View type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace UltimateSnake.Architecture
{
    using System.Collections.Generic;
    using System.Drawing;

    using UltimateSnake.GameObjects;

    /// <summary>
    /// Parent-class that contains what's needed to expand with further views down the road
    /// </summary>
    public abstract class View
    {
        /// <summary>
        /// Gets or sets a mapping of colors
        /// </summary>
        protected abstract Dictionary<Color, object> ColorMap { get; set; }

        /// <summary>
        /// Draw for every view available
        /// </summary>
        public static void DrawAll()
        {
            // At the moment, there is only console-view
            ConsoleView.Draw();
        }

        /// <summary>
        /// Draw an object
        /// </summary>
        /// <param name="obj">
        /// The object to draw
        /// </param>
        protected abstract void Draw(DrawableGameObject obj);

        /// <summary>
        /// Draw everything in a list
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