// --------------------------------------------------------------------------------------------------------------------
// <copyright file="InputHandler.cs" company="MarSim">
//   Copyright © 2012
// </copyright>
// <summary>
//   Defines the InputHandler type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace UltimateSnake.Utilities
{
    using System;

    /// <summary>
    /// A class containing handling of all types of input
    /// </summary>
    public static class InputHandler
    {
        /// <summary>
        /// Gets or sets a value indicating whether new input is available.
        /// </summary>
        public static bool NewInputAvailable { get; set; }

        /// <summary>
        /// Check all input-types supported
        /// </summary>
        public static void CheckAllInputs()
        {
            // Only one type of input available now
            CheckConsoleInput();
        }

        /// <summary>
        /// Check input from the console
        /// </summary>
        private static void CheckConsoleInput()
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
                    Input.ChosenAction = Input.AvailableInput.Up;
                    break;
                case ConsoleKey.RightArrow:
                case ConsoleKey.D:
                case ConsoleKey.NumPad6:
                    Input.ChosenAction = Input.AvailableInput.Right;
                    break;
                case ConsoleKey.DownArrow:
                case ConsoleKey.S:
                case ConsoleKey.NumPad2:
                    Input.ChosenAction = Input.AvailableInput.Down;
                    break;
                case ConsoleKey.LeftArrow:
                case ConsoleKey.A:
                case ConsoleKey.NumPad4:
                    Input.ChosenAction = Input.AvailableInput.Left;
                    break;
                case ConsoleKey.NumPad1:
                    Input.ChosenAction = Input.AvailableInput.LowerLeft;
                    break;
                case ConsoleKey.NumPad3:
                    Input.ChosenAction = Input.AvailableInput.LowerRight;
                    break;
                case ConsoleKey.NumPad7:
                    Input.ChosenAction = Input.AvailableInput.UpperLeft;
                    break;
                case ConsoleKey.NumPad9:
                    Input.ChosenAction = Input.AvailableInput.UpperRight;
                    break;
                case ConsoleKey.Escape:
                case ConsoleKey.End:
                    Input.ChosenAction = Input.AvailableInput.Quit;
                    break;
                case ConsoleKey.Spacebar:
                case ConsoleKey.NumPad5:
                    Input.ChosenAction = Input.AvailableInput.Pause;
                    break;
            }

            NewInputAvailable = true;
        }
    }
}