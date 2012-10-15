namespace UltimateSnake.MVC
{
    using GameObjects;

    public class View
    {
        private static View instance;

        private View()
        {
        }

        public static View Instance
        {
            get { return instance ?? (instance = new View()); }
        }

        public static void Draw()
        {
            Loot.Instance.Draw();
            Snake.Instance.Draw();
        }
    }
}