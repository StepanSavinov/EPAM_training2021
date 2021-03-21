using System;
using System.Collections.Generic;
using System.Text;

namespace epamXT
{
    class Player : IMovable, IKillable
    {
        private int _x;
        private int _y;

        private int _score;
        private int _health;

        protected int X { get => _x; set => _x = value; }
        protected int Y { get => _y; set => _y = value; }

        protected int Score { get => _score; set => _score = value; }
        protected int Health { get => _health; set => _health = value; }

        public Player() : this(0, 0, 0, 100) { }
        public Player(int x, int y, int score, int health)
        {
            X = x;
            Y = y;
            Score = 0;
            Health = 100;
        }


        public void Move(int _x, int _y)
        {
            // перемещение на заданные координаты
        }

        public void TakeBonus()
        {
            // игрок подбирает бонус
        }

        public void Die()
        {
            _health -= 100;
            // игрок умирает от монстра
        }
    }
}
