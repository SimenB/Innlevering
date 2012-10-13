using UltimateSnake.Utilities;

namespace UltimateSnake.GameObjects
{
    class Loot
    {
        public Point Position { get; private set; }
        public char Sign { get; set; }

        public Loot(Point position, char sign = '$')
        {
            this.Position = position;
            this.Sign = sign;
        }

        public void Update()
        {
            
        }

        public void Draw()
        {
            
        }
    }
}