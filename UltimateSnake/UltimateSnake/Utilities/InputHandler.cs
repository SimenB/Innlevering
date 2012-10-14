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
            this.DirectionToMove = Snake.Direction.Right;
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
            if (Console.KeyAvailable)
            {
                Console.ReadKey(true);
            }

            switch (buttonPressed.Key)
            {
                case ConsoleKey.UpArrow:
                case ConsoleKey.W:
                    this.DirectionToMove = Snake.Direction.Up;
                    break;
                case ConsoleKey.RightArrow:
                case ConsoleKey.D:
                    this.DirectionToMove = Snake.Direction.Right;
                    break;
                case ConsoleKey.DownArrow:
                case ConsoleKey.S:
                    this.DirectionToMove = Snake.Direction.Down;
                    break;
                case ConsoleKey.LeftArrow:
                case ConsoleKey.A:
                    this.DirectionToMove = Snake.Direction.Left;
                    break;
                case ConsoleKey.Escape:
                    Environment.Exit(0);
                    break;
                case ConsoleKey.Spacebar:
                    Program.Paused = !Program.Paused;
                    this.DirectionToMove = Snake.Instance.CurrentDirection;
                    break;
            }
        }

        //         #region Fields
        //         KeyboardState KeyState = new KeyboardState();
        //         Keys[] currentkeys;
        //         Keys[] previouskeys;
        //         #endregion
        // 
        //         #region Update
        //         /// <summary>
        //         /// Updates the current keyboard state, and performs the appropriate actions according to the 
        //         /// currently pressed buttons.
        //         /// </summary>
        //         public void Update()
        //         {
        //             this.currentkeys = this.KeyState.GetPressedKeys();
        //             if (this.previouskeys == this.currentkeys)
        //             {
        //                 goto end;
        //             }
        //             for (int i = 0; i < this.currentkeys.Length; i++)
        //             {
        //                 switch (this.currentkeys[i])
        //                 {
        //                     case Keys.W:
        //                         ActionW();
        //                         break;
        //                     case Keys.A:
        //                         ActionA();
        //                         break;
        //                     case Keys.S:
        //                         ActionS();
        //                         break;
        //                     case Keys.D:
        //                         ActionD();
        //                         break;
        //                     case Keys.Space:
        //                         ActiSpace();
        //                         break;
        //                     case Keys.Left:
        //                         ActionLeft();
        //                         break;
        //                     case Keys.Right:
        //                         ActionRight();
        //                         break;
        //                     case Keys.Up:
        //                         ActionUp();
        //                         break;
        //                     case Keys.Down:
        //                         ActionDown();
        //                         break;
        //                 }
        //             }
        //             end:
        //             this.previouskeys = this.currentkeys;
        //         }
        //         #endregion
    }
}
