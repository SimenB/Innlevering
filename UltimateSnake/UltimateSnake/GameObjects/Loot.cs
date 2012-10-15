// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Loot.cs" company="MarSimJør">
//   Copyright © 2012
// </copyright>
// <summary>
//   The loot
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace UltimateSnake.GameObjects
{
    using System;

    using UltimateSnake.MVC;

    using Utilities;

    /// <summary>
    /// The loot
    /// </summary>
    public class Loot
    {
        private static Loot instance;

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

        /// <summary>
        /// The sign
        /// </summary>
        public char Sign { get; set; }

        /// <summary>
        /// The position of the loot
        /// </summary>
        public Point Position { get; private set; }

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
            Model.Instance.DrawAt(this.Position, this.Sign, "Red");
        }

        public void NewLoot()
        {
            instance = new Loot(GetRandomPosition());
        }

        private static Point GetRandomPosition()
        {
            // TODO: Don't spawn on snake
            Random random = new Random();
            var acceptable = false;

            Point temp;

            do
            {
                temp = new Point(random.Next(Program.WindowSize.X), random.Next(Program.WindowSize.Y));

                foreach (var bodyPart in Snake.Instance.BodyParts)
                {
                    if (Point.Intersects(temp, bodyPart))
                    {
                        acceptable = false;
                        break;
                    }

                    acceptable = true;
                }
            }
            while (!acceptable);

            return temp;
        }
    }
}
