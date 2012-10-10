// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Program.cs" company="MarSimJør">
//   Copyright © 2012
// </copyright>
// <summary>
//   Defines the Program type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace UltimateSnake
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Diagnostics;
    using System.Threading.Tasks;

    /// <summary>
    /// The program.
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// The main.
        /// </summary>
        /// <param name="args">
        /// The arguments
        /// </param>
        public static void Main(string[] args)
        {
            GameLoop();
        }

        private static void GameLoop()
        {
            Stopwatch sW = new Stopwatch();

            sW.Start();

            Snake per = Snake.Instance;

            while (per.Alive)
            {
                if (sW.ElapsedMilliseconds < 100)
                {
                    continue;
                }

                sW.Restart();

                // TODO: Game Logic here
            }
        }
    }
}
