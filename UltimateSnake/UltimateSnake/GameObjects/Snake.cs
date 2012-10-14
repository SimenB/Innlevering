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
    using System.Diagnostics.CodeAnalysis;

    /// <summary>
    /// The snake
    /// </summary>
    public class Snake
    {
        /// <summary>
        /// The movement speed of the snake
        /// </summary>
        private const int MovementSpeed = 3;

        /// <summary>
        /// The instance of the snake (singleton)
        /// </summary>
        private static Snake instance;

        /// <summary>
        /// The position of the head of the snake
        /// </summary>
        private Point position;

        /// <summary>
        /// A list of the position of each body-part
        /// </summary>
        private List<Point> bodyParts;

        /// <summary>
        /// The direction the snake is traveling in
        /// </summary>
        private Direction direction;

        /// <summary>
        /// The input-handler instance
        /// </summary>
        private InputHandler input = InputHandler.Instance;

        /// <summary>
        /// Prevents a default instance of the <see cref="Snake"/> class from being created.
        /// </summary>
        private Snake()
        {
            this.bodyParts = new List<Point> { new Point(), new Point(), new Point() };

            this.position = new Point(Program.WindowSize.X / 2, Program.WindowSize.Y / 2);
            
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
