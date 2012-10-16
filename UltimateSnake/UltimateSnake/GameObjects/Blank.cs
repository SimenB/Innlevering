using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UltimateSnake.GameObjects
{
    using UltimateSnake.Utilities;

    class Blank : DrawableGameObject
    {
        public Blank()
        {
            this.Position = new Point();
            this.Color = "Black";
            this.Texture = ' ';
        }
    }
}
