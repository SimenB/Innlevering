namespace UltimateSnake.MVC
{
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
    }
}
