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
    using System.Diagnostics;
    using System.Threading;

    using GameObjects;
    using MVC;
    using Utilities;

    /// <summary>
    /// The console snake game.
    /// </summary>
    public sealed class ConsoleSnakeGame : SnakeGame
    {
        private static System.Media.SoundPlayer player;

        private ConsoleSnakeGame()
        {
            // Preload();
            // player.PlayLooping();
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
            ConsoleSnakeGame.player = new System.Media.SoundPlayer(Resources.Philter___Spellbound_In_8_Bit);
            ConsoleSnakeGame.player.Load();

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

        public static void GameLoop()
        {
            WindowSize = new Point(Console.WindowWidth, Console.WindowHeight);
            MidScreen = new Point(WindowSize.X / 2, WindowSize.Y / 2);
            FPS = 10;

            var stopwatch = new Stopwatch();
            stopwatch.Start();

            do
            {
                // Check for pause
                Controller.Instance.Update();

                if (stopwatch.ElapsedMilliseconds < 1000 / FPS)
                {
                    continue;
                }

                stopwatch.Restart();

                ConsoleView.Instance.Draw();

                Model.Update();
            }
            while (Snake.Instance.Alive);
        }
    }
}
