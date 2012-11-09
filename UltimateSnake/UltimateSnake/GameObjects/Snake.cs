// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Snake.cs" company="MarSimJør">
//   Copyright © 2012
// </copyright>
// <summary>
//   The snake
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace UltimateSnake.GameObjects
{
    using System.Collections.Generic;

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
        /// Prevents a default instance of the <see cref="Snake"/> class from being created.
        /// </summary>
        private Snake()
        {
            this.TheSnake = new List<DrawableGameObject>
                {
                    new SnakeHead(new Point(SnakeGame.MidScreen)),
                    new SnakeBody(),
                    new SnakeBody(),
                    new SnakeBody(),
                    new Blank()
                };

            for (int i = this.TheSnake.Count - 1; i > 0; i--)
            {
                this.TheSnake[i].Position.X = this.TheSnake[i - 1].Position.X;
                this.TheSnake[i].Position.Y = this.TheSnake[i - 1].Position.Y;
            }

            this.Alive = true;

            this.CurrentDirection = Direction.Left;
        }

        /// <summary>
        /// The direction the snake is moving in
        /// </summary>
        public enum Direction
        {
            Right, Down, Left, Up
        }

        /// <summary>
        /// Gets the instance. If it's not initialized, do so
        /// </summary>
        public static Snake Instance
        {
            get { return instance ?? (instance = new Snake()); }
        }

        /// <summary>
        /// Gets the list of all of the snake's components
        /// </summary>
        public List<DrawableGameObject> TheSnake { get; private set; }

        /// <summary>
        /// Gets the direction the snake is traveling in
        /// </summary>
        public Direction CurrentDirection { get; private set; }

        /// <summary>
        /// Gets a value indicating whether the snake is alive or not
        /// </summary>
        public bool Alive { get; private set; }

        /// <summary>
        /// Add a new body-part to the snake
        /// </summary>
        public static void AddBodyPart()
        {
            Instance.TheSnake[Instance.TheSnake.Count - 1] = new SnakeBody();

            Instance.TheSnake.Add(new Blank());
        }

        /// <summary>
        /// The get game object.
        /// </summary>
        /// <returns>
        /// A list of all game-objects to draw
        /// </returns>
        public List<DrawableGameObject> GetGameObject()
        {
            return this.TheSnake;
        }

        /// <summary>
        /// The update.
        /// </summary>
        public void Update()
        {
            // Set all the positions of all the body-parts to the one ahead of it
            for (int i = this.TheSnake.Count - 1; i > 0; i--)
            {
                this.TheSnake[i].Position.X = this.TheSnake[i - 1].Position.X;
                this.TheSnake[i].Position.Y = this.TheSnake[i - 1].Position.Y;
            }

            this.Movement();

            // If the head of the snake runs into another part of itself, it dies
            for (int i = 1; i < this.TheSnake.Count - 1; i++)
            {
                if (this.TheSnake[0].Position == this.TheSnake[i].Position)
                {
                    this.Alive = false;
                }
            }

            // BUG: The bottom right corner
            // If the snake is outside of the game-window, it dies
            if (this.TheSnake[0].Position.X < 0 || this.TheSnake[0].Position.X >= SnakeGame.WindowSize.X || this.TheSnake[0].Position.Y < 0 || this.TheSnake[0].Position.Y >= SnakeGame.WindowSize.Y)
            {
                this.Alive = false;
            }
        }

        /// <summary>
        /// The movement method. To make the update method easier to read
        /// </summary>
        private void Movement()
        {
            if (Input.DirectionToMove != this.CurrentDirection)
            {
                if (this.CurrentDirection == Direction.Up && Input.DirectionToMove != Direction.Down)
                {
                    this.CurrentDirection = Input.DirectionToMove;
                }
                else if (this.CurrentDirection == Direction.Right && Input.DirectionToMove != Direction.Left)
                {
                    this.CurrentDirection = Input.DirectionToMove;
                }
                else if (this.CurrentDirection == Direction.Down && Input.DirectionToMove != Direction.Up)
                {
                    this.CurrentDirection = Input.DirectionToMove;
                }
                else if (this.CurrentDirection == Direction.Left && Input.DirectionToMove != Direction.Right)
                {
                    this.CurrentDirection = Input.DirectionToMove;
                }
            }

            switch (this.CurrentDirection)
            {
                case Direction.Up:
                    this.TheSnake[0].Position.Y--;
                    break;
                case Direction.Right:
                    this.TheSnake[0].Position.X++;
                    break;
                case Direction.Down:
                    this.TheSnake[0].Position.Y++;
                    break;
                case Direction.Left:
                    this.TheSnake[0].Position.X--;
                    break;
            }
        }
    }
}