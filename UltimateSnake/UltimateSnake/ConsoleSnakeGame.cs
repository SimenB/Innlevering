// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ConsoleSnakeGame.cs" company="MarSim">
//   Copyright © 2012
// </copyright>
// <summary>
//   Defines the ConsoleSnakeGame type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace UltimateSnake
{
    using System;

    using Utilities;

    /// <summary>
    /// The console snake game.
    /// </summary>
    public sealed class ConsoleSnakeGame : SnakeGame
    {
        /// <summary>
        /// Prevents a default instance of the <see cref="ConsoleSnakeGame"/> class from being created.
        /// </summary>
        private ConsoleSnakeGame()
        {
        }

        /// <summary>
        /// Start a game of Snake a la Console
        /// </summary>
        public static void StartGame()
        {
            Console.CursorVisible = false;

            WindowSize = new Point(Console.WindowWidth, Console.WindowHeight);
            MidScreen = new Point(WindowSize.X / 2, WindowSize.Y / 2);
            FramesPerSecond = 10;
            
            // "Square" window
            Console.SetWindowSize(WindowSize.X, WindowSize.Y);

            // Get rid of the scrollbar
            Console.SetBufferSize(WindowSize.X, WindowSize.Y);
        }
    }
}