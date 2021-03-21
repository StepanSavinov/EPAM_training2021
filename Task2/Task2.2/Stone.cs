using System;
using System.Collections.Generic;
using System.Text;

namespace epamXT
{
    class Stone : Obstacle
    {
        public Stone(int x, int y)
        {
            X = x;
            Y = y;
        }

        public override void CantPass(Obstacle obstacle)
        {
            // логика непроходимости сквозь объект
        }

        public override void Place(int _x, int _y)
        {
            // размещение камня на уровне
        }
    }
}
