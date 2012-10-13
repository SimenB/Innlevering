namespace UltimateSnake.MVC
{
    internal class Controller
    {
        private static Controller instance;

        private Controller()
        {
        }

        public static Controller Instance
        {
            get { return instance ?? (instance = new Controller()); }
        }
    }
}
