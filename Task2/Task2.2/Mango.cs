using System;
using System.Collections.Generic;
using System.Text;

namespace epamXT
{
    class Mango : Bonus
    {
        public Mango(int x, int y)
        {
            X = x;
            Y = y;
        }

        public override void Place(int _x, int _y)
        {
            // размещаем манго на уровне
        }

        public override void PickUp()
        {
            
        }
    }
}
