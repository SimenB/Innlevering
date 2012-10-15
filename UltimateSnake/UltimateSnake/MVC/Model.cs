namespace UltimateSnake.MVC
{
    using System.Linq;

    using GameObjects;
    using Utilities;

    public class Model
    {
        private static Model instance;

        private Model()
        {
        }

        public static Model Instance
        {
            get { return instance ?? (instance = new Model()); }
        }

        public static void Update()
        {
            if (Program.Paused)
            {
                return;
            }

            Snake.Instance.Update();
            Loot.Instance.Update();

            CheckCollision();
        }

        /// <summary>
        /// Checks if the snake eats the loot
        /// </summary>
        private static void CheckCollision()
        {
            if (Snake.Instance.Position == Loot.Instance.Position)
            {
                return;
            }
            
            Snake.Instance.BodyParts.Add(new Point(Snake.Instance.BodyParts.Last()));

            Loot.Instance.NewLoot();
        }

        public static void DrawAt(Point position, char sign, string color)
        {
            View.DrawAt(position, sign, color);
        }
    }
}
