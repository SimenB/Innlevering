using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;

namespace InputHandler
{
    public class InputHandler
    {
        #region Fields
        KeyboardState KeyState = new KeyboardState();
        Keys[] currentkeys;
        Keys[] previouskeys;
        #endregion

        #region Update
        /// <summary>
        /// Updates the current keyboard state, and performs the appropriate actions according to the 
        /// currently pressed buttons.
        /// </summary>
        public void Update()
        {
            currentkeys = KeyState.GetPressedKeys();
            if (previouskeys == currentkeys)
            {
                goto end;
            }
            for (int i = 0; i < currentkeys.Length; i++)
            {
                switch (currentkeys[i])
                {
                    case Keys.W:
                        ActionW();
                        break;
                    case Keys.A:
                        ActionA();
                        break;
                    case Keys.S:
                        ActionS();
                        break;
                    case Keys.D:
                        ActionD();
                        break;
                    case Keys.Space:
                        ActiSpace();
                        break;
                    case Keys.Left:
                        ActionLeft();
                        break;
                    case Keys.Right:
                        ActionRight();
                        break;
                    case Keys.Up:
                        ActionUp();
                        break;
                    case Keys.Down:
                        ActionDown();
                        break;
                }
            }
            end:
            previouskeys = currentkeys;
        }
        #endregion
        
    }
}
