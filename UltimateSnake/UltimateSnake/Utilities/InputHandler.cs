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

    using UltimateSnake.MVC;

    /// <summary>
    /// The input handler
    /// </summary>
    public abstract class InputHandler
    {
        /// <summary>
        /// Gets the direction to move.
        /// </summary>
        public static Snake.Direction DirectionToMove { get; protected set; }

        public enum Input
        {
            Up, UpperRight, Right, LowerRight, Down, LowerLeft, Left, UpperLeft, Quit, Pause
        }

        public static Input ChosenKey { get; set; }

        public static void ChangeDirection()
        {
            
        }

        /// <summary>
        /// The update.
        /// </summary>
        public static void Update()
        {
            ConsoleInput.CheckConsoleInput();

            switch (ChosenKey)
            {
                case Input.Up:
                    DirectionToMove = Snake.Direction.Up;
                    break;
                case Input.Right:
                    DirectionToMove = Snake.Direction.Right;
                    break;
                case Input.Down:
                    DirectionToMove = Snake.Direction.Down;
                    break;
                case Input.Left:
                    DirectionToMove = Snake.Direction.Left;
                    break;
                case Input.LowerLeft:
                    switch (Snake.Instance.CurrentDirection)
                    {
                        case Snake.Direction.Right:
                        case Snake.Direction.Left:
                            DirectionToMove = Snake.Direction.Down;
                            break;
                        case Snake.Direction.Up:
                        case Snake.Direction.Down:
                            DirectionToMove = Snake.Direction.Left;
                            break;
                    }

                    break;
                case Input.LowerRight:
                    switch (Snake.Instance.CurrentDirection)
                    {
                        case Snake.Direction.Right:
                        case Snake.Direction.Left:
                            DirectionToMove = Snake.Direction.Down;
                            break;
                        case Snake.Direction.Up:
                        case Snake.Direction.Down:
                            DirectionToMove = Snake.Direction.Right;
                            break;
                    }

                    break;
                case Input.UpperLeft:
                    switch (Snake.Instance.CurrentDirection)
                    {
                        case Snake.Direction.Right:
                        case Snake.Direction.Left:
                            DirectionToMove = Snake.Direction.Up;
                            break;
                        case Snake.Direction.Up:
                        case Snake.Direction.Down:
                            DirectionToMove = Snake.Direction.Left;
                            break;
                    }

                    break;
                case Input.UpperRight:
                    switch (Snake.Instance.CurrentDirection)
                    {
                        case Snake.Direction.Right:
                        case Snake.Direction.Left:
                            DirectionToMove = Snake.Direction.Up;
                            break;
                        case Snake.Direction.Up:
                        case Snake.Direction.Down:
                            DirectionToMove = Snake.Direction.Right;
                            break;
                    }

                    break;
                case Input.Quit:
                    Environment.Exit(0);
                    break;
                case Input.Pause:
                    Model.Paused = !Model.Paused;
                    DirectionToMove = Snake.Instance.CurrentDirection;
                    break;
                default:
                    DirectionToMove = Snake.Instance.CurrentDirection;
                    break;
            }
        }
    }
}