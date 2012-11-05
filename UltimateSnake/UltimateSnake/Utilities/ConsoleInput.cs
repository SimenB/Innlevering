// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ConsoleInput.cs" company="MarSimJør">
//   Copyright © 2012
// </copyright>
// <summary>
//   Defines the ConsoleInput type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using System;

namespace UltimateSnake.Utilities
{
    public static class ConsoleInput
    {

        public static void CheckConsoleInput()
        {
            if (!Console.KeyAvailable)
            {
                return;
            }

            ConsoleKeyInfo buttonPressed = Console.ReadKey(true);

            // Always use the last input
            while (Console.KeyAvailable)
            {
                buttonPressed = Console.ReadKey(true);
            }

            switch (buttonPressed.Key)
            {
                case ConsoleKey.UpArrow:
                case ConsoleKey.W:
                case ConsoleKey.NumPad8:
                    InputHandler.ChosenKey = InputHandler.Input.Up;
                    break;
                case ConsoleKey.RightArrow:
                case ConsoleKey.D:
                case ConsoleKey.NumPad6:
                    InputHandler.ChosenKey = InputHandler.Input.Right;
                    break;
                case ConsoleKey.DownArrow:
                case ConsoleKey.S:
                case ConsoleKey.NumPad2:
                    InputHandler.ChosenKey = InputHandler.Input.Down;
                    break;
                case ConsoleKey.LeftArrow:
                case ConsoleKey.A:
                case ConsoleKey.NumPad4:
                    InputHandler.ChosenKey = InputHandler.Input.Left;
                    break;
                case ConsoleKey.NumPad1:
                    InputHandler.ChosenKey = InputHandler.Input.LowerLeft;
                    break;
                case ConsoleKey.NumPad3:
                    InputHandler.ChosenKey = InputHandler.Input.LowerRight;
                    break;
                case ConsoleKey.NumPad7:
                    InputHandler.ChosenKey = InputHandler.Input.UpperLeft;
                    break;
                case ConsoleKey.NumPad9:
                    InputHandler.ChosenKey = InputHandler.Input.UpperRight;
                    break;
                case ConsoleKey.Escape:
                case ConsoleKey.End:
                    Environment.Exit(0);
                    break;
                case ConsoleKey.Spacebar:
                case ConsoleKey.NumPad5:
                    InputHandler.ChosenKey = InputHandler.Input.Pause;
                    break;
            }
        }
    }
}