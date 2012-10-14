// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Loot.cs" company="MarSimJør">
//   Copyright © 2012
// </copyright>
// <summary>
//   The loot
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using System;

namespace UltimateSnake.GameObjects
{
    using Utilities;

    /// <summary>
    /// The loot
    /// </summary>
    public class Loot
    {
        private static Loot instance;

        /// <summary>
        /// The sign
        /// </summary>
        public char Sign { get; set; }

        /// <summary>
        /// The position of the loot
        /// </summary>
        public Point Position { get; private set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Loot"/> class.
        /// </summary>
        /// <param name="position">
        /// The position.
        /// </param>
        /// <param name="sign">
        /// The sign.
        /// </param>
        private Loot(Point position, char sign = '$')
        {
            this.Position = position;
            this.Sign = sign;
        }


        public static Loot Instance
        {
            // TODO: Move to middle of screen
            get { return instance ?? (instance = new Loot(GetRandomPosition())); }
        }


        private static Point GetRandomPosition()
        {
            // TODO: Don't spawn on snake
            Random random = new Random();
            return new Point(random.Next(Program.WindowSize.X), random.Next(Program.WindowSize.Y));
        }

        /// <summary>
        /// The update.
        /// </summary>
        public void Update()
        {

        }

        /// <summary>
        /// The draw.
        /// </summary>
        public void Draw()
        {
            // TODO: SetCursorPosition should only happen on being eaten (in Update)
            Console.SetCursorPosition(this.Position.X, this.Position.Y);
            Console.Write(Sign);
        }
    }
}
