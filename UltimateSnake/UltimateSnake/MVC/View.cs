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
            Loot.Instance.Draw();
            Snake.Instance.Draw();
        }

        public static void DrawAt(Utilities.Point position, char sign, string color)
        {
            Console.SetCursorPosition(position.X, position.Y);

            Color c = Color.FromName(color);

            Console.ForegroundColor = ColorMapping[c];

            Console.Write(sign);
        }
    }
}