using System;
using System.Collections.Generic;
using System.Text;

namespace epamXT
{
    class Raspberry : Bonus
    {
        public Raspberry(int x, int y)
        {
            X = x;
            Y = y;
        }

        public override void Place(int _x, int _y)
        {
            // размещаем малину на уровне
        }

        public override void PickUp()
        {
            // логика подбирания игроком бонуса
        }
    }
}
