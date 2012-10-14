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
    using System;
    using System.Collections.Generic;

    using UltimateSnake.Utilities;

    /// <summary>
    /// The snake
    /// </summary>
    public class Snake
    {
        /// <summary>
        /// The movement speed of the snake
        /// </summary>
        private const int MovementSpeed = 1;

        /// <summary>
        /// The instance of the snake (singleton)
        /// </summary>
        private static Snake instance;

        /// <summary>
        /// The position of the head of the snake
        /// </summary>
        private readonly Point position;

        /// <summary>
        /// A list of the position of each body-part
        /// </summary>
        private readonly List<Point> bodyParts;

        /// <summary>
        /// The input-handler instance
        /// </summary>
        private readonly InputHandler input = InputHandler.Instance;

        /// <summary>
        /// The direction the snake is traveling in
        /// </summary>
        private Direction direction;

        /// <summary>
        /// Prevents a default instance of the <see cref="Snake"/> class from being created.
        /// </summary>
        private Snake()
        {
            this.bodyParts = new List<Point> { new Point(), new Point(), new Point() };

            this.position = new Point(Program.WindowSize.X / 2, Program.WindowSize.Y / 2);

            Console.SetCursorPosition(this.position.X, this.position.Y);
            
            for (var i = this.bodyParts.Count - 1; i > 1; i--)
            {
                this.bodyParts[i].X = this.bodyParts[i - 1].X;
                this.bodyParts[i].Y = this.bodyParts[i - 1].X;
            }

            this.Alive = true;

            this.direction = Direction.Down;
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
            get { return instance ?? (instance = new Snake()); }
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
            // TODO: Check for "self-cannibalism"
            if (this.position.X < 0 || this.position.X > Program.WindowSize.X || this.position.Y < 0 || this.position.Y > Program.WindowSize.Y)
            {
                this.Alive = false;

                return;
            }

            for (int i = this.bodyParts.Count - 1; i > 0; i--)
            {
                this.bodyParts[i].X = this.bodyParts[i - 1].X;
                this.bodyParts[i].Y = this.bodyParts[i - 1].Y;
            }

            this.bodyParts[0] = this.position;

            if (this.input.KeyPressed)
            {
                if (this.input.MoveUp() && this.direction != Direction.Down)
                {
                    this.direction = Direction.Up;
                }
                else if (this.input.MoveRight() && this.direction != Direction.Left)
                {
                    this.direction = Direction.Right;
                }
                else if (this.input.MoveDown() && this.direction != Direction.Up)
                {
                    this.direction = Direction.Down;
                }
                else if (this.input.MoveLeft() && this.direction != Direction.Right)
                {
                    this.direction = Direction.Left;
                }
            }

            switch (this.direction)
            {
                case Direction.Up:
                    this.position.Y -= MovementSpeed;
                    break;
                case Direction.Right:
                    this.position.X += MovementSpeed;
                    break;
                case Direction.Down:
                    this.position.Y += MovementSpeed;
                    break;
                case Direction.Left:
                    this.position.X -= MovementSpeed;
                    break;
            }

            foreach (Point bodyPart in this.bodyParts)
            {
                Console.WriteLine(bodyPart.X + ", " + bodyPart.Y);
            }
        }

        /// <summary>
        /// The draw.
        /// </summary>
        public void Draw()
        {
            // TODO: Draw the snake
        }
    }
}
