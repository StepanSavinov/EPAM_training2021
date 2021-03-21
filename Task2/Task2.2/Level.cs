using System;
using System.Collections.Generic;
using System.Text;

namespace epamXT
{
    class Level
    {
        private int _height;
        private int _width;

        protected int Height { get => _height; set => _height = value; }
        protected int Width { get => _width; set => _width = value; }

        public Level(int height, int width)
        {
            Height = height;
            Width = width;
        }


    }

    
}
