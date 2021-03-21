using System;
using System.Collections.Generic;
using System.Text;

namespace epamXT
{
    class Tree : Obstacle
    {
        public Tree(int x, int y)
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
            // размещение дерева на уровне
        }
    }
}
