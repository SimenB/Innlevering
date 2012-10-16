// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Program.cs" company="MarSimJør">
//   Copyright © 2012
// </copyright>
// <summary>
//   Defines the Program type.
// </summary>
// -------------------------------------------------------------------------------------------------------------------

namespace UltimateSnake
{
    using System;
    using System.Diagnostics;
    using System.Threading;

    using GameObjects;
    using MVC;
    using Utilities;

    /// <summary>
    /// The program.
    /// </summary>
    public static class Program
    {
        private static System.Media.SoundPlayer player;

        /// <summary>
        /// Gets the size of the window (remember that the console uses rows and columns, NOT pixels)
        /// </summary>
        public static Point WindowSize
        {
            get { return new Point(Console.WindowWidth, Console.WindowHeight); }
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
            // Preload();
            // player.PlayLooping();

            GameLoop();
        }

        private static void Preload()
        {
            // "Square" window
            Console.SetWindowSize(Console.WindowWidth, Console.WindowWidth / 2);

            // Get rid of the scrollbar
            Console.SetBufferSize(Console.WindowWidth, Console.WindowWidth / 2);

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
            Thread.Sleep(2250);

            // Remove the text and print new
            Console.Clear();
            text = "Lol jk";
            Console.SetCursorPosition((Console.WindowWidth / 2) - (text.Length / 2), (Console.WindowHeight / 2) - 1);
            Console.WriteLine(text);

            // Give the player time to read
            Thread.Sleep(400);

            // Make the background black and the text green.
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
        }

        /// <summary>
        /// The game loop
        /// </summary>
        private static void GameLoop()
        {
            // Limits the update loop to one update per 100 milliseconds (10 fps LOL)
            // TODO: This should be used to define movement speed of the snake, which should always move the same amount of pixels per update
            var stopwatch = new Stopwatch();
            stopwatch.Start();

            var snake = Snake.Instance;

            do
            {
                // Check for pause
                Controller.Instance.Update();

                if (stopwatch.ElapsedMilliseconds < 100)
                {
                    continue;
                }

                stopwatch.Restart();

                View.Draw();

                Model.Update();
            }
            while (snake.Alive);
        }
    }
}
