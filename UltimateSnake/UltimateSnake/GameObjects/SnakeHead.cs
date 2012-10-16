using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UltimateSnake.GameObjects
{
    using UltimateSnake.Utilities;

    class SnakeHead : DrawableGameObject
    {
        public SnakeHead(Point p)
        {
            this.Position = p;
            this.Texture = '@';
            this.Color = "Green";
        }

        public SnakeHead() : this(new Point())
        {
        }
    }
}
