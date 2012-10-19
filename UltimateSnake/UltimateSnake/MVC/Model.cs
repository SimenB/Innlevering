namespace UltimateSnake.MVC
{
    using GameObjects;

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

            CheckCollision();

            Snake.Instance.Update();
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

            Snake.Instance.theSnake[Snake.Instance.theSnake.Count - 1] = new SnakeBody();

            Snake.Instance.theSnake.Add(new Blank());

            Loot.AddNewLoot();
        }
    }
}