

namespace UltimateSnake.MVC
{
    using GameObjects;

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
            Loot.Instance.Draw();
            Snake.Instance.Draw();
        }
    }
}