namespace UltimateSnake.MVC
{
    using System.Linq;

    using GameObjects;

    using UltimateSnake.Utilities;

    class Model
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
            Snake.Instance.Update();
            Loot.Instance.Update();

            this.CheckCollison();
        }

        private void CheckCollison()
        {
            if (Point.Intersects(Snake.Instance.Position, Loot.Instance.Position))
            {
                Snake.Instance.BodyParts.Add(new Point(Snake.Instance.BodyParts.Last()));
            }
        }
    }
}
