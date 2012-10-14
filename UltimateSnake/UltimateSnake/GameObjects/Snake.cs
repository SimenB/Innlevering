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
    using System.Linq;

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
        /// The position of the last item in the last frame.
        /// </summary>
        private Point positionLastFrame;

        /// <summary>
        /// The direction the snake is traveling in
        /// </summary>
        private Direction direction;

        /// <summary>
        /// Prevents a default instance of the <see cref="Snake"/> class from being created.
        /// </summary>
        private Snake()
        {
            this.bodyParts = new List<Point> { new Point(), new Point(), new Point(), new Point(), new Point() };

            this.position = new Point(Program.WindowSize.X / 2, Program.WindowSize.Y / 2);

            Console.SetCursorPosition(this.position.X, this.position.Y);
            
            for (var i = this.bodyParts.Count - 1; i > 0; i--)
            {
                this.bodyParts[i].X = this.bodyParts[i - 1].X;
                this.bodyParts[i].Y = this.bodyParts[i - 1].X;
            }

            this.Alive = true;

            this.direction = Direction.Right;
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
        /// Gets a value indicating whether the snake is alive or not
        /// </summary>
        public bool Alive { get; private set; }

        /// <summary>
        /// The update.
        /// </summary>
        public void Update()
        {
            this.positionLastFrame = this.bodyParts.Last();

            // If the snake is outside of the game-window, it's dead
            if (this.position.X < 1 || this.position.X > Program.WindowSize.X || this.position.Y < 1 || this.position.Y > Program.WindowSize.Y)
            {
                this.Alive = false;

                return;
            }

            // Set all the positions of all the body-parts to the one ahead of it
            for (int i = this.bodyParts.Count - 1; i > 0; i--)
            {
                this.bodyParts[i] = new Point(this.bodyParts[i - 1]);
            }

            this.bodyParts[0] = new Point(this.position);

            this.Movement();

            // If the snake runs into itself, it dies
            if (this.bodyParts.Any(bodyPart => this.position.X == bodyPart.X && this.position.Y == bodyPart.Y))
            {
                this.Alive = false;

                return;
            }

            this.Draw();
        }

        /// <summary>
        /// The draw.
        /// </summary>
        public void Draw()
        {
            Console.SetCursorPosition(this.position.X, this.position.Y);
            Console.Write("@");

            foreach (Point bodyPart in this.bodyParts)
            {
                Console.SetCursorPosition(bodyPart.X, bodyPart.Y);
                Console.Write("0");
            }

            Console.SetCursorPosition(this.positionLastFrame.X, this.positionLastFrame.Y);
            Console.Write(" ");
        }

        /// <summary>
        /// The movement method. To make the update method easier to read
        /// </summary>
        private void Movement()
        {
            if (this.input.DirectionToMove != this.direction)
            {
                if (this.direction == Direction.Up && this.input.DirectionToMove != Direction.Down)
                {
                    this.direction = this.input.DirectionToMove;
                }
                else if (this.direction == Direction.Right && this.input.DirectionToMove != Direction.Left)
                {
                    this.direction = this.input.DirectionToMove;
                }
                else if (this.direction == Direction.Down && this.input.DirectionToMove != Direction.Up)
                {
                    this.direction = this.input.DirectionToMove;
                }
                else if (this.direction == Direction.Left && this.input.DirectionToMove != Direction.Right)
                {
                    this.direction = this.input.DirectionToMove;
                }
            }

            // TODO: This is not how movement speed works in snake :P
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
        }
    }
}
