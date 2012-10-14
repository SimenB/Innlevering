// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Program.cs" company="MarSimJør">
//   Copyright © 2012
// </copyright>
// <summary>
//   Defines the Program type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace UltimateSnake
{
    using System;
    using System.Diagnostics;

    using UltimateSnake.GameObjects;
    using UltimateSnake.MVC;

    /// <summary>
    /// The program.
    /// </summary>
    public static class Program
    {
        public static Point WindowSize
        {
            get { return new Point(Console.BufferWidth, Console.BufferHeight); }
        }

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
            Stopwatch stopwatch = new Stopwatch();

            stopwatch.Start();

            Snake snake = Snake.Instance;

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
