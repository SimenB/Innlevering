// --------------------------------------------------------------------------------------------------------------------
// <copyright file="InputHandler.cs" company="MarSimJør">
//   Copyright © 2012
// </copyright>
// <summary>
//   The input handler
// </summary>
// --------------------------------------------------------------------------------------------------------------------

// TODO: The whole shebang. This is very much a placeholder

namespace UltimateSnake.Utilities
{
    using System;

    using GameObjects;

    /// <summary>
    /// The input handler
    /// </summary>
    public class InputHandler
    {
        /// <summary>
        /// The input-handler instance
        /// </summary>
        private static InputHandler instance;

        /// <summary>
        /// Prevents a default instance of the <see cref="InputHandler"/> class from being created.
        /// </summary>
        private InputHandler()
        {
        }

        /// <summary>
        /// Gets the instance.
        /// </summary>
        public static InputHandler Instance
        {
            get { return instance ?? (instance = new InputHandler()); }
        }

        /// <summary>
        /// Gets the direction to move.
        /// </summary>
        public Snake.Direction DirectionToMove { get; private set; }

        /// <summary>
        /// The update.
        /// </summary>
        public void Update()
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
                    this.DirectionToMove = Snake.Direction.Up;
                    break;
                case ConsoleKey.RightArrow:
                case ConsoleKey.D:
                case ConsoleKey.NumPad6:
                    this.DirectionToMove = Snake.Direction.Right;
                    break;
                case ConsoleKey.DownArrow:
                case ConsoleKey.S:
                case ConsoleKey.NumPad2:
                    this.DirectionToMove = Snake.Direction.Down;
                    break;
                case ConsoleKey.LeftArrow:
                case ConsoleKey.A:
                case ConsoleKey.NumPad4:
                    this.DirectionToMove = Snake.Direction.Left;
                    break;
                case ConsoleKey.NumPad1:
                    switch (Snake.Instance.CurrentDirection)
                    {
                        case Snake.Direction.Right:
                        case Snake.Direction.Left:
                            this.DirectionToMove = Snake.Direction.Down;
                            break;
                        case Snake.Direction.Up:
                        case Snake.Direction.Down:
                            this.DirectionToMove = Snake.Direction.Left;
                            break;
                    }

                    break;
                case ConsoleKey.NumPad3:
                    switch (Snake.Instance.CurrentDirection)
                    {
                        case Snake.Direction.Right:
                        case Snake.Direction.Left:
                            this.DirectionToMove = Snake.Direction.Down;
                            break;
                        case Snake.Direction.Up:
                        case Snake.Direction.Down:
                            this.DirectionToMove = Snake.Direction.Right;
                            break;
                    }

                    break;
                case ConsoleKey.NumPad7:
                    switch (Snake.Instance.CurrentDirection)
                    {
                        case Snake.Direction.Right:
                        case Snake.Direction.Left:
                            this.DirectionToMove = Snake.Direction.Up;
                            break;
                        case Snake.Direction.Up:
                        case Snake.Direction.Down:
                            this.DirectionToMove = Snake.Direction.Left;
                            break;
                    }

                    break;
                case ConsoleKey.NumPad9:
                    switch (Snake.Instance.CurrentDirection)
                    {
                        case Snake.Direction.Right:
                        case Snake.Direction.Left:
                            this.DirectionToMove = Snake.Direction.Up;
                            break;
                        case Snake.Direction.Up:
                        case Snake.Direction.Down:
                            this.DirectionToMove = Snake.Direction.Right;
                            break;
                    }

                    break;
                case ConsoleKey.Escape:
                case ConsoleKey.End:
                    Environment.Exit(0);
                    break;
                case ConsoleKey.Spacebar:
                case ConsoleKey.NumPad5:
                    Program.Paused = !Program.Paused;
                    this.DirectionToMove = Snake.Instance.CurrentDirection;
                    break;
                default:
                    this.DirectionToMove = Snake.Instance.CurrentDirection;
                    break;
            }
        }
    }
}