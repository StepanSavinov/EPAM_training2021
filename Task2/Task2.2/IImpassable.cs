using System;
using System.Collections.Generic;
using System.Text;

namespace epamXT
{
    interface IImpassable
    {
        void CantPass(Obstacle obstacle);
    }
}
