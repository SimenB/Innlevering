using UltimateSnake.Utilities;
// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SnakeGame.cs" company="MarSimJør">
//   Copyright © 2012
// </copyright>
// <summary>
//   The snake
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace UltimateSnake.GameObjects
{
    using System.Collections.Generic;
    using System.Linq;

    using UltimateSnake.MVC;

    using Utilities;

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
        /// The input-handler instance
        /// </summary>
        private readonly InputHandler input = InputHandler.Instance;

        /// <summary>
        /// The position of the last item in the last frame.
        /// </summary>
        private Point positionLastFrame;

        /// <summary>
        /// A list of all of the snake's components
        /// </summary>
        public List<DrawableGameObject> theSnake { get; private set; }

        /// <summary>
        /// Prevents a default instance of the <see cref="Snake"/> class from being created.
        /// </summary>
        private Snake()
        {
            this.theSnake = new List<DrawableGameObject>
                {
                    new SnakeHead(new Point(Program.MidScreen)),
                    new SnakeBody(),
                    new SnakeBody(),
                    new SnakeBody(),
                    new Blank()
                };

            for (int i = this.theSnake.Count - 1; i > 0; i--)
            {
                this.theSnake[i].Position.X = this.theSnake[i - 1].Position.X;
                this.theSnake[i].Position.Y = this.theSnake[i - 1].Position.Y;
            }

            this.Alive = true;

            this.CurrentDirection = Direction.Right;
        }

        /// <summary>
        /// The direction the snake is moving in
        /// </summary>
        public enum Direction
        {
            Up, Right, Down, Left
        }

        /// <summary>
        /// Gets the instance. If it's not initialized, do so
        /// </summary>
        public static Snake Instance
        {
            get { return instance ?? (instance = new Snake()); }
        }

        /// <summary>
        /// Gets the direction the snake is traveling in
        /// </summary>
        public Direction CurrentDirection { get; private set; }

        public List<DrawableGameObject> GetGameObject()
        {
            return this.theSnake;
        }

        /// <summary>
        /// Gets a value indicating whether the snake is alive or not
        /// </summary>
        public bool Alive { get; private set; }

        /// <summary>
        /// The update.
        /// </summary>
        public void Update()
        {
            // Set all the positions of all the body-parts to the one ahead of it
            for (int i = this.theSnake.Count - 1; i > 0; i--)
            {
                this.theSnake[i].Position.X = this.theSnake[i - 1].Position.X;
                this.theSnake[i].Position.Y = this.theSnake[i - 1].Position.Y;
            }

            this.Movement();

            // If the head of the snake runs into another part of itself, it dies
            for (int i = 1; i < this.theSnake.Count - 1; i++)
            {
                if (this.theSnake[0].Position == this.theSnake[i].Position)
                {
                    this.Alive = false;
                }
            }

            // BUG: The bottom right corner
            // If the snake is outside of the game-window, it dies
            if (this.theSnake[0].Position.X < 0 || this.theSnake[0].Position.X >= Program.WindowSize.X || this.theSnake[0].Position.Y < 0 || this.theSnake[0].Position.Y >= Program.WindowSize.Y)
            {
                this.Alive = false;
            }
        }

        /// <summary>
        /// The movement method. To make the update method easier to read
        /// </summary>
        private void Movement()
        {
            if (this.input.DirectionToMove != this.CurrentDirection)
            {
                if (this.CurrentDirection == Direction.Up && this.input.DirectionToMove != Direction.Down)
                {
                    this.CurrentDirection = this.input.DirectionToMove;
                }
                else if (this.CurrentDirection == Direction.Right && this.input.DirectionToMove != Direction.Left)
                {
                    this.CurrentDirection = this.input.DirectionToMove;
                }
                else if (this.CurrentDirection == Direction.Down && this.input.DirectionToMove != Direction.Up)
                {
                    this.CurrentDirection = this.input.DirectionToMove;
                }
                else if (this.CurrentDirection == Direction.Left && this.input.DirectionToMove != Direction.Right)
                {
                    this.CurrentDirection = this.input.DirectionToMove;
                }
            }

            switch (this.CurrentDirection)
            {
                case Direction.Up:
                    this.theSnake[0].Position.Y--;
                    break;
                case Direction.Right:
                    this.theSnake[0].Position.X++;
                    break;
                case Direction.Down:
                    this.theSnake[0].Position.Y++;
                    break;
                case Direction.Left:
                    this.theSnake[0].Position.X--;
                    break;
            }
        }
    }
}