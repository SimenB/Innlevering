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
        /// The position of the head of the snake
        /// </summary>
        private Point position;

        /// <summary>
        /// The previous position
        /// </summary>
        private Point previousPosition;

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

            this.position = new Point(Program.WindowSize.X / 2, Program.WindowSize.Y / 2);
            this.previousPosition = new Point(this.position);

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
            get { return instance ?? (instance = new Snake()); }
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
            // TODO: Check for "self-cannibalism"
            this.position = Point.Clamp(this.position, Point.Zero, Program.WindowSize);
        }

        /// <summary>
        /// The draw.
        /// </summary>
        public void Draw()
        {
            for (var i = 0; i <= this.BodyParts; i++)
            {
                // TODO: Draw the snake
                this.previousPosition.X = this.position.X;
                this.previousPosition.Y = this.position.Y;
            }
        }
    }
}
