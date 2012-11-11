// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ConsoleView.cs" company="MarSim">
//   Copyright © 2012
// </copyright>
// <summary>
//   Defines the ConsoleView type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace UltimateSnake.Architecture
{
    using System;
    using System.Collections.Generic;
    using System.Drawing;

    using UltimateSnake.GameObjects;

    // BUG: The bottom right corner (This has to do with how the console works)

    /// <summary>
    /// The console-view
    /// </summary>
    public sealed class ConsoleView : View
    {
        /// <summary>
        /// The instance.
        /// </summary>
        private static readonly ConsoleView Instance = new ConsoleView();

        /// <summary>
        /// The position  of the last element this, and the last frame
        /// </summary>
        private Utilities.Point lastPosition, lastPositionLastFrame = new Utilities.Point();

        /// <summary>
        /// Prevents a default instance of the <see cref="ConsoleView"/> class from being created.
        /// </summary>
        private ConsoleView()
        {
            this.ColorMap = new Dictionary<Color, object>
            { 
                { Color.Black,          ConsoleColor.Black }, 
                { Color.Blue,           ConsoleColor.Blue },
                { Color.Cyan,           ConsoleColor.Cyan },
                { Color.DarkBlue,       ConsoleColor.DarkBlue },
                { Color.DarkCyan,       ConsoleColor.DarkCyan },
                { Color.DarkGray,       ConsoleColor.DarkGray },
                { Color.DarkGreen,      ConsoleColor.DarkGreen },
                { Color.DarkMagenta,    ConsoleColor.DarkMagenta },
                { Color.DarkRed,        ConsoleColor.DarkRed },
                //// { Color.DarkYellow,     ConsoleColor.DarkYellow },
                { Color.Gray,           ConsoleColor.Gray },
                { Color.Green,          ConsoleColor.Green },
                { Color.Magenta,        ConsoleColor.Magenta },
                { Color.Red,            ConsoleColor.Red },
                { Color.White,          ConsoleColor.White },
                { Color.Yellow,         ConsoleColor.Yellow }
            };
        }

        /// <summary>
        /// Gets or sets the color mapping.
        /// </summary>
        protected override Dictionary<Color, object> ColorMap { get; set; }

        /// <summary>
        /// Draw all draw-able objects
        /// </summary>
        public static void Draw()
        {
            Instance.Draw(Loot.Instance.GetGameObject());
            Instance.Draw(Snake.Instance.GetGameObject());
        }

        /// <summary>
        /// Draw a char
        /// </summary>
        /// <param name="obj">
        /// The object to draw
        /// </param>
        protected override void Draw(DrawableGameObject obj)
        {
            Console.SetCursorPosition(obj.Position.X, obj.Position.Y);

            Console.ForegroundColor = (ConsoleColor)this.ColorMap[Color.FromName(obj.Color)];

            Console.Write(obj.ConsoleTexture);
        }

        /// <summary>
        /// Draw a char
        /// </summary>
        /// <param name="objList">
        /// The list of objects to draw
        /// </param>
        protected override void Draw(List<DrawableGameObject> objList)
        {
            foreach (DrawableGameObject gameObject in objList)
            {
                this.Draw(gameObject);
                
                this.lastPosition = new Utilities.Point(gameObject.Position);
            }
            
            this.Draw(new ConsoleBlank(this.lastPositionLastFrame));

            this.lastPositionLastFrame = this.lastPosition;
        }
    }
}