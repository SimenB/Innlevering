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
    using System.Text;

    using UltimateSnake.Utilities;

    /// <summary>
    /// The loot
    /// </summary>
    public class Loot
    {
        private static Loot instance;

        /// <summary>
        /// The sign
        /// </summary>
        private char sign;

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
            this.sign = sign;
        }



        public static Loot Instance
        {
            // TODO: Move to middle of screen
            get { return instance ?? (instance = new Loot(new Point())); }
        }

        /// <summary>
        /// Gets the position of the loot
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
        }
    }
}
