using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Dropbox.Util
{
    class AnimationManager
    {
        private long updateRate = 50;


        public void play(String name, System.Windows.Forms.Control c)
        {

        }

        public class Animation
        {
            public int startingX, startingY, neededX, neededY, ticks;
            public System.Windows.Forms.Control c;

            public Animation(System.Windows.Forms.Control c, int x, int y, int ticks) {
                this.c = c;
                this.neededX = x;
                this.neededY = y;
                this.ticks = ticks;
                this.startingX = c.Location.X;
                this.startingY = c.Location.Y;
            }

            public void reset()
            {
                c.Location = new Point(startingX, startingY);
                c.Update();
            }
        }

    }
}
