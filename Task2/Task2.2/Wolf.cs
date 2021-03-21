using System;
using System.Collections.Generic;
using System.Text;

namespace epamXT
{
    class Wolf : Enemy
    {
        public Wolf()
        {
            X = _x;
            Y = _y;
        }

        public override void AttackPlayer(Player player)
        {
            player.Die();
        }

        public override void Move(int _x, int _y)
        {
            // перемещение на заданные координаты вслед за игроком
        }
    }
}
