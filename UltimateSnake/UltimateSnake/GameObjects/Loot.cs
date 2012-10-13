using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UltimateSnake.GameObjects
{
    class Loot
    {
        private Point position { get; set; }
        private char sign;

        public Loot(Point position, char sign = '$')
        {
            this.position = position;
            this.sign = sign;
        }

        public void Update()
        {
            
        }

        public void Draw()
        {
            
        }
    }
}
