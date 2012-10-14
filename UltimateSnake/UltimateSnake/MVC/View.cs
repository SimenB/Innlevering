namespace UltimateSnake.MVC
{
    using GameObjects.Snake;
    using GameObjects.Loot;

    class View
    {
        private static View instance;

        private View()
        {
        }

        public static View Instance
        {
            get { return instance ?? (instance = new View()); }
        }

        public void Draw()
        {
            GameObjects.Snake.Instance.Draw();
            GameObjects.Loot.Instance.Draw();
        }
    }
}