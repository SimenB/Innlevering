// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ConsoleView.cs" company="MarSimJør">
//   Copyright © 2012
// </copyright>
// <summary>
//   Defines the ConsoleView type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace UltimateSnake.MVC
{
    using System;
    using System.Collections.Generic;
    using System.Drawing;

    using GameObjects;

    public class ConsoleView : View
    {
        private ConsoleView()
        {
            this.ColorMap = new Dictionary<Color, object>()
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
                // { Color.DarkYellow,     ConsoleColor.DarkYellow },
                { Color.Gray,           ConsoleColor.Gray },
                { Color.Green,          ConsoleColor.Green },
                { Color.Magenta,        ConsoleColor.Magenta },
                { Color.Red,            ConsoleColor.Red },
                { Color.White,          ConsoleColor.White },
                { Color.Yellow,         ConsoleColor.Yellow }
            };
        }

        /// <summary>
        /// Gets the instance.
        /// </summary>
        public static View Instance
        {
            get { return instance ?? (instance = new ConsoleView()); }
        }

        /// <summary>
        /// Gets or sets the color mapping.
        /// </summary>
        protected override Dictionary<Color, object> ColorMap { get; set; }

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

            Console.Write((char)obj.Texture);
        }

        /// <summary>
        /// Draw a char
        /// </summary>
        /// <param name="objList">
        /// The list of objects to draw
        /// </param>
        protected override void Draw(List<DrawableGameObject> objList)
        {
            Point lastPosition, lastPositionLastFrame;

            foreach (DrawableGameObject gameObject in objList)
            {
                this.Draw(gameObject);

               // lastPosition = new Point(gameObject.Position);
            }

           // this.Draw(Blank);
        }
    }
}