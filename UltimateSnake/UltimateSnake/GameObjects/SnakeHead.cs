namespace UltimateSnake.GameObjects
{
    using UltimateSnake.Utilities;

    class SnakeHead : DrawableGameObject
    {
        public SnakeHead(Point p)
        {
            this.Position = p;
            this.ConsoleTexture = '@';
            this.Color = "Green";
        }

        public SnakeHead() : this(new Point())
        {
        }
    }
}