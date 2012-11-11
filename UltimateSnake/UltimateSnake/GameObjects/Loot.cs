// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Loot.cs" company="MarSim">
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
        private Loot(Point position)
        {
            this.Position = position;
            this.ConsoleTexture = '$';
            this.Color = "Red";
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
        public static void MoveLoot()
        {
            instance = new Loot(RandomPosition());
        }

        /// <summary>
        /// Get all elements to draw
        /// </summary>
        /// <returns>
        /// The <see cref="DrawableGameObject"/>.
        /// </returns>
        public DrawableGameObject GetGameObject()
        {
            return this;
        }

        /// <summary>
        /// Generates a position on the game-screen
        /// </summary>
        /// <returns>
        /// A position not occupied by the snake
        /// </returns>
        private static Point RandomPosition()
        {
            Random random = new Random();
            Point position;
            bool acceptable = false;

            do
            {
                position = new Point(random.Next(SnakeGame.WindowSize.X), random.Next(SnakeGame.WindowSize.Y));

                // Body-part can be both SnakeHead and SnakeBody, so 'var' woks
                foreach (var bodyPart in Snake.Instance.TheSnake)
                {
                    if (position == bodyPart.Position)
                    {
                        acceptable = false;
                        break;
                    }

                    acceptable = true;
                }
            }
            while (!acceptable);

            return position;
        }
    }
}