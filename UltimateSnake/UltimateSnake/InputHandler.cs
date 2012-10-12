// --------------------------------------------------------------------------------------------------------------------
// <copyright file="InputHandler.cs" company="MarSimJør">
//   Copyright © 2012
// </copyright>
// <summary>
//   Defines the InputHandler type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

// TODO: The whole shebang. This is very much a placeholder

namespace UltimateSnake
{
    public class InputHandler
    {
        private static InputHandler instance;

        private InputHandler()
        {
        }

        public static InputHandler Instance
        {
            get { return instance ?? (instance = new InputHandler()); }
        }

        public bool MoveUp()
        {
            return true;
        }

        public bool MoveRight()
        {
            return false;
        }

        public bool MoveDown()
        {
            return false;
        }

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
        //         
    }
}
