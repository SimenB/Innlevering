// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Snake.cs" company="MarSimJør">
//   Copyright © 2012
// </copyright>
// <summary>
//   The snake
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace UltimateSnake
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The snake
    /// </summary>
    public class Snake
    {
        /// <summary>
        /// The instance of the snake (singleton)
        /// </summary>
        private static Snake instance;

        /// <summary>
        /// The number of body-parts
        /// </summary>
        private int bodyParts;

        private int posX;
        private int posY;
        private int prevPosX;
        private int prevPosY;

        /// <summary>
        /// Prevents a default instance of the <see cref="Snake"/> class from being created.
        /// </summary>
        private Snake()
        {
            this.bodyParts = 3;

            // TODO: set initial position to middle of screen
            this.posX = 5;
            this.posY = 5;

            this.Alive = true;
        }

        /// <summary>
        /// The direction the snake is moving in
        /// </summary>
        private enum Direction
        {
            Up,
            Right,
            Down,
            Left
        }

        /// <summary>
        /// Gets a value indicating whether the snake is alive or not
        /// </summary>
        public bool Alive { get; private set; }

        /// <summary>
        /// Gets the instance. If it's not initialized, do so
        /// </summary>
        public static Snake Instance
        {
            get
            {
                return instance == null ? instance : instance = new Snake();
            }
        }

        /// <summary>
        /// The update.
        /// </summary>
        public void Update()
        {
            // TODO: Insert width and height of game-window
            if ((this.posX < 0 && this.posX > 1000) || (this.posY < 0 && this.posY > 1000))
            {
                this.Alive = false;
            }
        }

        /// <summary>
        /// The draw.
        /// </summary>
        public void Draw()
        {
            for (int i = 0; i <= this.bodyParts; i++)
            {
                // TODO: Draw the snake
                this.prevPosX = this.posX;
                this.prevPosY = this.posY;
            }
        }
    }
}
