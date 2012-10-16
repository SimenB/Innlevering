using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UltimateSnake.GameObjects
{
    using UltimateSnake.Utilities;

    class SnakeBody : DrawableGameObject
    {
        public SnakeBody(Point p)
        {
            this.Position = p;
            this.Texture = 'O';
            this.Color = "Green";
        }

        public SnakeBody() : this(new Point())
        {
        }
    }
}
