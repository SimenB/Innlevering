// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ConsoleSnakeGame.cs" company="MarSimJør">
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
        private static System.Media.SoundPlayer player;

        private ConsoleSnakeGame()
        {
        }

        /// <summary>
        /// Start a game of Snake a la Console
        /// </summary>
        public static void StartGame()
        {
            WindowSize = new Point(Console.WindowWidth, Console.WindowHeight);
            MidScreen = new Point(WindowSize.X / 2, WindowSize.Y / 2);
            FPS = 10;

            // "Square" window
            Console.SetWindowSize(WindowSize.X, WindowSize.Y);

            // Get rid of the scrollbar
            Console.SetBufferSize(WindowSize.X, WindowSize.Y);

            // Dark red background-color
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.Clear();

            // Remove the cursor
            Console.CursorVisible = false;

            // Cyan font color
            Console.ForegroundColor = ConsoleColor.Cyan;

            // Print middle-aligned text
            var text = "LOADING... PREPARE YOURSELF!";

            Console.SetCursorPosition((Console.WindowWidth / 2) - (text.Length / 2), (Console.WindowHeight / 2) - 1);
            Console.WriteLine(text);

            // Load the background music
            player = new System.Media.SoundPlayer(Resources.Philter___Spellbound_In_8_Bit);
            player.Load();

            // Pretend to be actually doing something
            //Thread.Sleep(2250);

            // Remove the text and print new
            Console.Clear();
            text = "Lol jk";
            Console.SetCursorPosition((Console.WindowWidth / 2) - (text.Length / 2), (Console.WindowHeight / 2) - 1);
            Console.WriteLine(text);

            // Give the player time to read
            //Thread.Sleep(400);

            // Make the background black and the text green.
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();
        }
    }
}
