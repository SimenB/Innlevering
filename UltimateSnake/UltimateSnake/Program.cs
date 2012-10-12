// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Program.cs" company="MarSimJør">
//   Copyright © 2012
// </copyright>
// <summary>
//   Defines the Program type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using UltimateSnake.GameObjects;
using UltimateSnake.MVC;

namespace UltimateSnake
{
    using System.Diagnostics;

    /// <summary>
    /// The program.
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// The main.
        /// </summary>
        /// <param name="args">
        /// The arguments
        /// </param>
        public static void Main(string[] args)
        {
            GameLoop();
        }

        private static void GameLoop()
        {
            var stopwatch = new Stopwatch();

            stopwatch.Start();

            var snake = Snake.Instance;

            while (snake.Alive)
            {
                if (stopwatch.ElapsedMilliseconds < 100)
                {
                    continue;
                }

                stopwatch.Restart();

                // TODO: Game Logic here
            }
        }
    }
}
