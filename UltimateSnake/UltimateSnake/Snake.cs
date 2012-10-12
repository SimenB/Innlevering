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
        /// The x-position
        /// </summary>
        private int posX;

        /// <summary>
        /// The y-position
        /// </summary>
        private int posY;

        /// <summary>
        /// The previous x-position
        /// </summary>
        private int prevPosX;

        /// <summary>
        /// The previous y-position
        /// </summary>
        private int prevPosY;

        /// <summary>
        /// The input-handler instance
        /// </summary>
        private InputHandler input = InputHandler.Instance;

        /// <summary>
        /// Prevents a default instance of the <see cref="Snake"/> class from being created.
        /// </summary>
        private Snake()
        {
            this.BodyParts = 3;

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
        /// Gets the instance. If it's not initialized, do so
        /// </summary>
        public static Snake Instance
        {
            get
            {
                return instance ?? (instance = new Snake());
            }
        }

        /// <summary>
        /// Gets the number of body-parts
        /// </summary>
        public int BodyParts { get; private set; }

        /// <summary>
        /// Gets a value indicating whether the snake is alive or not
        /// </summary>
        public bool Alive { get; private set; }

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
            for (int i = 0; i <= this.BodyParts; i++)
            {
                // TODO: Draw the snake
                this.prevPosX = this.posX;
                this.prevPosY = this.posY;
            }
        }
    }
}
