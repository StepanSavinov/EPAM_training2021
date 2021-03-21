using System;
using System.Collections.Generic;
using System.Text;

namespace epamXT
{
    abstract class Enemy : IMovable
    {
        private protected int _x;
        private protected int _y;

        protected int X { get => _x; set => _x = value; }
        protected int Y { get => _y; set => _y = value; }
        public abstract void Move(int x, int y);

        public abstract void AttackPlayer(Player player);
    }
}
