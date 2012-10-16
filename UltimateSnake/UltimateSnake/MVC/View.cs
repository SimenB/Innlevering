namespace UltimateSnake.MVC
{
    using System;
    using System.Collections.Generic;
    using System.Drawing;

    using GameObjects;

    public class View
    {
        private static View instance;

        /// <summary>
        /// A mapping of colors
        /// </summary>
        private static readonly Dictionary<Color, ConsoleColor> ColorMapping = new Dictionary<Color, ConsoleColor>()
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

        private View()
        {
        }

        public static View Instance
        {
            get { return instance ?? (instance = new View()); }
        }

        public static void Draw()
        {
            Draw(Loot.Instance.GetGameObject());
            Draw(Snake.Instance.GetGameObject());
        }

        /// <summary>
        /// Draw a char
        /// </summary>
        /// <param name="obj">
        /// The obj.
        /// </param>
        public static void Draw(DrawableGameObject obj)
        {
            Console.SetCursorPosition(obj.Position.X, obj.Position.Y);

            Console.ForegroundColor = ColorMapping[Color.FromName(obj.Color)];

            Console.Write((char)obj.Texture);
        }

        /// <summary>
        /// Draw a char
        /// </summary>
        /// <param name="objList">
        /// The object List.
        /// </param>
        public static void Draw(IEnumerable<DrawableGameObject> objList)
        {
            foreach (DrawableGameObject gameObject in objList)
            {
                Draw(gameObject);
            }
        }
    }
}