namespace UltimateSnake.MVC
{
    using GameObjects;

    public static class Model
    {
        /// <summary>
        /// Gets or sets a value indicating whether the game is paused.
        /// </summary>
        public static bool Paused { get; set; }

        public static void Update()
        {
            if (Paused)
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

            Snake.AddBodyPart();

            Loot.AddNewLoot();
        }
    }
}