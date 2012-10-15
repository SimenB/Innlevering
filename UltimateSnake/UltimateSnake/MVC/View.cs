namespace UltimateSnake.MVC
{
    using System;

    using GameObjects;
    using Utilities;

    public class View
    {
        private static View instance;

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

        public static void DrawAt(Point position, char sign, string color)
        {
            ConsoleColor cColor;

            if (color.Equals("Green"))
            {
                cColor = ConsoleColor.Green;
            }
            else if (color.Equals("Red"))
            {
                cColor = ConsoleColor.Red;
            }
            else
            {
                cColor = ConsoleColor.White;
            }

            Console.SetCursorPosition(position.X, position.Y);

            Console.ForegroundColor = cColor;

            Console.Write(sign);
        }
    }
}