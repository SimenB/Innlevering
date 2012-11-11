// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SnakeGame.cs" company="MarSim">
//   Copyright © 2012
// </copyright>
// <summary>
//   Defines the SnakeGame type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace UltimateSnake
{
    using UltimateSnake.GameObjects;
    using UltimateSnake.Utilities;

    /// <summary>
    /// A class which defines the size of the game-board and FPS
    /// </summary>
    public abstract class SnakeGame
    {
        /// <summary>
        /// Gets or sets the size of the window (remember that the console uses rows and columns, NOT pixels)
        /// </summary>
        public static Point WindowSize { get; protected set; }

        /// <summary>
        /// Gets or sets the mid-point of the screen
        /// </summary>
        public static Point MidScreen { get; protected set; }

        /// <summary>
        /// Gets or sets the mid-point of the screen
        /// </summary>
        public static int FPS { get; protected set; }

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