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

    using GameObjects;
    using MVC;
    using Utilities;

    public sealed class ConsoleSnakeGame : SnakeGame
    {
        private ConsoleSnakeGame()
        {
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
