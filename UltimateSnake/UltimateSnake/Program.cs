﻿// --------------------------------------------------------------------------------------------------------------------
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

    using MVC;

    using GameObjects;
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
