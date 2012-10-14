namespace UltimateSnake.MVC
{
    using GameObjects;

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
        }
    }
}
