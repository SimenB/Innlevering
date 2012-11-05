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

    using Utilities;

    /// <summary>
    /// The loot
    /// </summary>
    public class Loot : DrawableGameObject
    {
        /// <summary>
        /// The instance.
        /// </summary>
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
            this.HasChanged = true;
        }

        /// <summary>
        /// Gets the instance.
        /// </summary>
        public static Loot Instance
        {
            get { return instance ?? (instance = new Loot(RandomPosition())); }
        }

        /// <summary>
        /// Add a new loot to the game-screen
        /// </summary>
        public static void AddNewLoot()
        {
            instance = new Loot(RandomPosition());
        }

        /// <summary>
        /// Returns what to draw
        /// </summary>
        /// <returns>
        /// The <see cref="DrawableGameObject"/>.
        /// </returns>
        public DrawableGameObject GetGameObject()
        {
            this.HasChanged = false;

            return this;
        }

        /// <summary>
        /// Sets a position at random on the game-screen
        /// </summary>
        /// <returns>
        /// The <see cref="Point"/>.
        /// </returns>
        private static Point RandomPosition()
        {
            Random random = new Random();
            bool acceptable = false;

            Point temp;

            // TODO: Optimize
            do
            {
                temp = new Point(random.Next(SnakeGame.WindowSize.X), random.Next(SnakeGame.WindowSize.Y));

                foreach (var bodyPart in Snake.Instance.TheSnake)
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
    }
}