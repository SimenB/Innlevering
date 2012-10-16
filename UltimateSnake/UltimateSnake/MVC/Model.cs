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

            CheckCollision();
        }

        /// <summary>
        /// Checks if the snake eats the loot
        /// </summary>
        private static void CheckCollision()
        {
            if (Snake.Instance.theSnake[0].Position != Loot.Instance.Position)
            {
                return;
            }

            int length = Snake.Instance.theSnake.Count;

            Snake.Instance.theSnake[length - 1] = new SnakeBody();

            Snake.Instance.theSnake.Add(new Blank());

            Loot.Instance.NewLoot();
        }
    }
}
