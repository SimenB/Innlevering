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
            this.KeyPressed = true;
        }

        /// <summary>
        /// Gets the instance.
        /// </summary>
        public static InputHandler Instance
        {
            get { return instance ?? (instance = new InputHandler()); }
        }

        // TODO: Actually check if the player has pressed a button

        /// <summary>
        /// Gets a value indicating whether a key is pressed.
        /// </summary>
        public bool KeyPressed { get; private set; }

        /// <summary>
        /// The move up.
        /// </summary>
        /// <returns>
        /// The <see cref="bool"/>.
        /// </returns>
        public bool MoveUp()
        {
            return false;
        }

        /// <summary>
        /// The move right.
        /// </summary>
        /// <returns>
        /// The <see cref="bool"/>.
        /// </returns>
        public bool MoveRight()
        {
            return false;
        }

        /// <summary>
        /// The move down.
        /// </summary>
        /// <returns>
        /// The <see cref="bool"/>.
        /// </returns>
        public bool MoveDown()
        {
            return false;
        }

        /// <summary>
        /// The move left.
        /// </summary>
        /// <returns>
        /// The <see cref="bool"/>.
        /// </returns>
        public bool MoveLeft()
        {
            return false;
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
