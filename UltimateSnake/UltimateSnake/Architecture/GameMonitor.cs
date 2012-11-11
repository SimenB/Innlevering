// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Model.cs" company="MarSim">
//   Copyright © 2012
// </copyright>
// <summary>
//   The model for the game. Contains all data
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace UltimateSnake.MVC
{
    using GameObjects;

    /// <summary>
    /// The model for the game. Contains all data
    /// </summary>
    public static class Model
    {
        /// <summary>
        /// Gets or sets a value indicating whether the game is paused.
        /// </summary>
        public static bool Paused { get; set; }

        /// <summary>
        /// The update.
        /// </summary>
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
            if (Snake.Instance.TheSnake[0].Position != Loot.Instance.Position)
            {
                return;
            }

            Snake.Instance.TheSnake.Add(new SnakeBody());

            Loot.MoveLoot();
        }
    }
}