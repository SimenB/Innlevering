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

    using MVC;

    using Utilities;

    /// <summary>
    /// The loot
    /// </summary>
    public class Loot : DrawableGameObject
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
            this.Texture = sign;
            this.Color = "Red";
        }

        public static Loot Instance
        {
            get { return instance ?? (instance = new Loot(GetRandomPosition())); }
        }

        public void NewLoot()
        {
            instance = new Loot(GetRandomPosition());
        }

        private static Point GetRandomPosition()
        {
            // TODO: Optimize
            Random random = new Random();
            var acceptable = false;

            Point temp;

            do
            {
                temp = new Point(random.Next(Program.WindowSize.X), random.Next(Program.WindowSize.Y));

                foreach (var bodyPart in Snake.Instance.theSnake)
                {
                    if (temp == bodyPart.Position)
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

        public DrawableGameObject GetGameObject()
        {
            return this;
        }
    }
}
