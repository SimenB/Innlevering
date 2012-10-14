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

    using Utilities;

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
        /// The input-handler instance
        /// </summary>
        private readonly InputHandler input = InputHandler.Instance;

        /// <summary>
        /// The position of the last item in the last frame.
        /// </summary>
        private Point positionLastFrame;

        /// <summary>
        /// Prevents a default instance of the <see cref="Snake"/> class from being created.
        /// </summary>
        private Snake()
        {
            this.BodyParts = new List<Point> { new Point(), new Point(), new Point(), new Point(), new Point() };

            this.Position = new Point(Program.WindowSize.X / 2, Program.WindowSize.Y / 2);

            Console.SetCursorPosition(this.Position.X, this.Position.Y);
            
            for (int i = this.BodyParts.Count - 1; i > 0; i--)
            {
                this.BodyParts[i].X = this.BodyParts[i - 1].X;
                this.BodyParts[i].Y = this.BodyParts[i - 1].Y;
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

        /// <summary>
        /// Gets a list of the position of each body-part
        /// </summary>
        public List<Point> BodyParts { get; private set; }

        /// <summary>
        /// Gets the position of the head of the snake
        /// </summary>
        public Point Position { get; private set; }

        /// <summary>
        /// Gets a value indicating whether the snake is alive or not
        /// </summary>
        public bool Alive { get; private set; }

        /// <summary>
        /// The update.
        /// </summary>
        public void Update()
        {
            this.positionLastFrame = this.BodyParts.Last();

            // If the snake is outside of the game-window, it's dead
            if (this.Position.X < 1 || this.Position.X > Program.WindowSize.X || this.Position.Y < 1 || this.Position.Y > Program.WindowSize.Y)
            {
                this.Alive = false;

                return;
            }

            // Set all the positions of all the body-parts to the one ahead of it
            for (int i = this.BodyParts.Count - 1; i > 0; i--)
            {
                this.BodyParts[i] = new Point(this.BodyParts[i - 1]);
            }

            this.BodyParts[0] = new Point(this.Position);

            this.Movement();

            // If the snake runs into itself, it dies
            if (this.BodyParts.Any(bodyPart => this.Position.X == bodyPart.X && this.Position.Y == bodyPart.Y))
            {
                this.Alive = false;
            }
        }

        /// <summary>
        /// The draw.
        /// </summary>
        public void Draw()
        {
            Console.ForegroundColor = ConsoleColor.Green;

            Console.SetCursorPosition(this.Position.X, this.Position.Y);
            Console.Write("@");

            foreach (Point bodyPart in this.BodyParts)
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

            // TODO: This is not how movement speed works in snake :P fuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuu
            switch (this.CurrentDirection)
            {
                case Direction.Up:
                    this.Position.Y -= MovementSpeed;
                    break;
                case Direction.Right:
                    this.Position.X += MovementSpeed;
                    break;
                case Direction.Down:
                    this.Position.Y += MovementSpeed;
                    break;
                case Direction.Left:
                    this.Position.X -= MovementSpeed;
                    break;
            }
        }
    }
}
