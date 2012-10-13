namespace UltimateSnake.MVC
{
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
    }
}