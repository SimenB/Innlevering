﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Program.cs" company="MarSimJør">
//   Copyright © 2012
// </copyright>
// <summary>
//   Defines the Program type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using System.Reflection;

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

        private static System.Media.SoundPlayer player;

        /// <summary>
        /// The main.
        /// </summary>
        /// <param name="args">
        /// The arguments
        /// </param>
        public static void Main(string[] args)
        {
            Preload();

            player.PlayLooping();

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

            Console.SetCursorPosition(Console.WindowWidth / 2 - text.Length / 2, Console.WindowHeight / 2 - 1);
            Console.WriteLine(text);

            // Load the background music
            player = new System.Media.SoundPlayer(Resources.Philter___Spellbound_In_8_Bit);
            player.Load();

            // Pretend to be actually doing something
            Thread.Sleep(2250);

            // Remove the text and print new
            Console.Clear();
            text = "Lol jk";
            Console.SetCursorPosition(Console.WindowWidth / 2 - text.Length / 2, Console.WindowHeight / 2 - 1);
            Console.WriteLine(text);

            // Give the player time to read
            Thread.Sleep(400);

            // Make the background black again
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();
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
            var stopwatch = new Stopwatch();
            stopwatch.Start();

            var snake = Snake.Instance;

            do
            {
                if (stopwatch.ElapsedMilliseconds < 80)
                {
                    continue;
                }

                stopwatch.Restart();

                // CMV for the win

                // Check for pause
                Controller.Instance.Update();

                Model.Instance.Update();
                View.Draw();
            } while (snake.Alive);
        }
    }
}
