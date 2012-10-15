﻿namespace UltimateSnake.MVC
{
    using System.Linq;

    using GameObjects;

    using UltimateSnake.Utilities;

    public class Model
    {
        private static Model instance;

        private Model()
        {
        }

        public static Model Instance
        {
            get { return instance ?? (instance = new Model()); }
        }

        public void Update()
        {
            if (Program.Paused)
            {
                return;
            }

            Snake.Instance.Update();
            Loot.Instance.Update();

            this.CheckCollision();
        }

        /// <summary>
        /// Checks if the snake eats the loot
        /// </summary>
        private void CheckCollision()
        {
            if (!Point.Intersects(Snake.Instance.Position, Loot.Instance.Position))
            {
                return;
            }
            
            Snake.Instance.BodyParts.Add(new Point(Snake.Instance.BodyParts.Last()));

            Loot.Instance.NewLoot();
        }
    }
}
