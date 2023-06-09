using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dropbox
{
    class Gravity
    {
        public double x, y, velocY = 10, velocX = 10, groundFriction = 0.8, airFriction = 0.91;
        public int offGroundTicks;
        public bool onGround;

    }
}
