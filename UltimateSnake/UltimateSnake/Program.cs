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

    using GameObjects;
    using MVC;
    using Utilities;

    /// <summary>
    /// The program.
    /// </summary>
    public static class Program
    {
        // TODO: Set custom size of the window, mebbi?

        /// <summary>
        /// Gets the size of the window (remember that the console uses rows and columns, NOT pixels)
        /// </summary>
        public static Point WindowSize
        {
            get { return new Point(Console.WindowWidth - 2, Console.WindowHeight - 2); }
        }

        /// <summary>
        /// Gets or sets a value indicating whether the game is paused.
        /// </summary>
        public static bool Paused { get; set; }

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

        /// <summary>
        /// The game loop
        /// </summary>
        private static void GameLoop()
        {
            Console.CursorVisible = false;
            Console.ForegroundColor = ConsoleColor.Green;

            // Limits the update loop to 10 updates per second
            
            // TODO: This should be used to define movement speed of the snake, which should always move the same amount of pixels per update
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

                // CMV for the win

                // Check for pause
                Controller.Instance.Update();

                Model.Instance.Update();
                View.Instance.Draw();
                
                if (!snake.Alive)
                {
                    break;
                }
            }
        }
    }
}
