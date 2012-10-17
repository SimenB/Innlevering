namespace UltimateSnake.GameObjects
{
    using UltimateSnake.Utilities;

    public class Blank : DrawableGameObject
    {
        public Blank()
        {
            this.Position = new Point();
            this.Color = "Black";
            this.Texture = ' ';
        }
    }
}
