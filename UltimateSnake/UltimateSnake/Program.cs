// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Program.cs" company="MarSim">
//   Copyright © 2012
// </copyright>
// <summary>
//   Defines the Program type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace UltimateSnake
{
    using System.Diagnostics;

    using UltimateSnake.GameObjects;
    using UltimateSnake.MVC;
    using UltimateSnake.Utilities;

    /// <summary>
    /// The program.
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// The main.
        /// </summary>
        public static void Main()
        {
            // Set up a console game
            ConsoleSnakeGame.StartGame();

            // After setting up the game, enter the game-loop
            GameLoop();
        }

        /// <summary>
        /// The game loop.
        /// </summary>
        private static void GameLoop()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            do
            {
                // Check for pause
                Input.Update();

                if (stopwatch.ElapsedMilliseconds < 1000 / SnakeGame.FPS)
                {
                    continue;
                }

                stopwatch.Restart();

                View.DrawAll();

                Model.Update();
            }
            while (Snake.Instance.Alive);
        }
    }
}