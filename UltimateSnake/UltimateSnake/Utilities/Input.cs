// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Input.cs" company="MarSimJør">
//   Copyright © 2012
// </copyright>
// <summary>
//   The input handler
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace UltimateSnake.Utilities
{
    using System;

    using GameObjects;

    using UltimateSnake.MVC;

    /// <summary>
    /// The input handler
    /// </summary>
    public static class Input
    {
        /// <summary>
        /// All the different ways the user can interact with the game
        /// </summary>
        public enum AvailableInput
        {
            Right, LowerRight, Down, LowerLeft, Left, UpperLeft, Up, UpperRight, Quit, Pause
        }

        /// <summary>
        /// Gets the direction to move.
        /// </summary>
        public static Snake.Direction DirectionToMove { get; private set; }

        /// <summary>
        /// Gets or sets the key or action wanted by the player
        /// </summary>
        public static AvailableInput ChosenAction { get; set; }

        /// <summary>
        /// The update.
        /// </summary>
        public static void UpdateInput()
        {
            if (!InputHandler.CheckAllInputs())
            {
                return;
            }

            switch (ChosenAction)
            {
                case AvailableInput.Up:
                    DirectionToMove = Snake.Direction.Up;
                    break;
                case AvailableInput.Right:
                    DirectionToMove = Snake.Direction.Right;
                    break;
                case AvailableInput.Down:
                    DirectionToMove = Snake.Direction.Down;
                    break;
                case AvailableInput.Left:
                    DirectionToMove = Snake.Direction.Left;
                    break;
                case AvailableInput.LowerLeft:
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
                case AvailableInput.LowerRight:
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
                case AvailableInput.UpperLeft:
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
                case AvailableInput.UpperRight:
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
                case AvailableInput.Quit:
                    Environment.Exit(0);
                    break;
                case AvailableInput.Pause:
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