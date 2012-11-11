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

    using Architecture;
    using GameObjects;
    using Utilities;

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

                if (stopwatch.ElapsedMilliseconds < 1000 / SnakeGame.FramesPerSecond)
                {
                    continue;
                }

                stopwatch.Restart();

                View.DrawAll();

                SnakeGame.Update();
            }
            while (Snake.Instance.Alive);
        }
    }
}