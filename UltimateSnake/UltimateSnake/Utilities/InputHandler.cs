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
      
            // Empty the buffer
            while (Console.KeyAvailable)
            {
               /* Console.ReadKey(true);*/
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
                    if (Snake.Instance.CurrentDirection == Snake.Direction.Left || Snake.Instance.CurrentDirection == Snake.Direction.Right)
                    {
                        this.DirectionToMove = Snake.Direction.Down;
                    }
                    else if (Snake.Instance.CurrentDirection == Snake.Direction.Down || Snake.Instance.CurrentDirection == Snake.Direction.Up)
                    {
                        this.DirectionToMove = Snake.Direction.Left;
                    }
                    break;
                case ConsoleKey.NumPad3:
                    if (Snake.Instance.CurrentDirection == Snake.Direction.Left || Snake.Instance.CurrentDirection == Snake.Direction.Right)
                    {
                        this.DirectionToMove = Snake.Direction.Down;
                    }
                    else if (Snake.Instance.CurrentDirection == Snake.Direction.Down || Snake.Instance.CurrentDirection == Snake.Direction.Up)
                    {
                        this.DirectionToMove = Snake.Direction.Right;
                    }
                    break;
                case ConsoleKey.NumPad7:
                    if (Snake.Instance.CurrentDirection == Snake.Direction.Left || Snake.Instance.CurrentDirection == Snake.Direction.Right)
                    {
                        this.DirectionToMove = Snake.Direction.Up;
                    }
                    else if (Snake.Instance.CurrentDirection == Snake.Direction.Down || Snake.Instance.CurrentDirection == Snake.Direction.Up)
                    {
                        this.DirectionToMove = Snake.Direction.Left;
                    }
                    break;
                case ConsoleKey.NumPad9:
                    if (Snake.Instance.CurrentDirection == Snake.Direction.Left || Snake.Instance.CurrentDirection == Snake.Direction.Right)
                    {
                        this.DirectionToMove = Snake.Direction.Up;
                    }
                    else if (Snake.Instance.CurrentDirection == Snake.Direction.Down || Snake.Instance.CurrentDirection == Snake.Direction.Up)
                    {
                        this.DirectionToMove = Snake.Direction.Right;
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