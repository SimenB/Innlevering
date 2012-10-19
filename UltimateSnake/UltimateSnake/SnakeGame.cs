﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UltimateSnake
{
    using UltimateSnake.Utilities;

    public abstract class SnakeGame
    {
        /// <summary>
        /// Gets or sets the size of the window (remember that the console uses rows and columns, NOT pixels)
        /// </summary>
        public abstract Point WindowSize { get; protected set; }

        /// <summary>
        /// Gets or sets the mid-point of the screen
        /// </summary>
        public abstract Point MidScreen { get; protected set; }

        /// <summary>
        /// Gets or sets the mid-point of the screen
        /// </summary>
        protected int FPS { get; set; }

        public void RunGame()
        {
            ConsoleSnakeGame.GameLoop();
        }
    }
}
