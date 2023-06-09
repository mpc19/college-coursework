using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;

namespace dropbox
{
    public class Item
    {

        private Boolean gravity, dragged, collisions;
        private Panel parent;
        private PictureBox pictureBox;
        private Gravity velocity;

        public Item(Panel parent, PictureBox owner, bool gravity)
        {
            this.parent = parent;
            this.pictureBox = owner;
            this.gravity = gravity;
            velocity = new Gravity();
        }

        public Panel getParent()
        {
            return parent;
        }

        public Boolean hasCollisions()
        {
            return collisions;
        }

        public PictureBox getOwner()
        {
            return pictureBox;
        }

        public void setDragged(bool state)
        {
            this.dragged = state;
        }

        public void setGravity(bool state)
        {
            this.gravity = state;
        }

        public void setVelocity(double x, double y)
        {
            velocity.x = x;
            velocity.y = y;
        }

        public void update()
        {
            if(Main.ActiveForm == null)
            {
                return;
            }

            if(pictureBox.Top + pictureBox.Height > Main.ActiveForm.Height || pictureBox.Top < 0)
            {
                velocity.y += velocity.groundFriction;
                velocity.onGround = false;
            } else
            {
                velocity.onGround = true;
            }

            pictureBox.Left = Convert.ToInt32(pictureBox.Left + (velocity.velocX * velocity.x));
            
            velocity.x *= (velocity.onGround ? velocity.groundFriction : velocity.airFriction);

            if(pictureBox.Left < 0)
            {
                velocity.x = -velocity.x;
            }

            if((pictureBox.Top + pictureBox.Height) > Main.ActiveForm.Height)
            {
                velocity.y = -velocity.y * velocity.groundFriction;
            }

            if(pictureBox.Left + pictureBox.Width > Main.ActiveForm.Width)
            {
                velocity.x = -velocity.x;
            }

            if(!velocity.onGround)
            {
                velocity.offGroundTicks++;
                velocity.y = Math.Abs((velocity.airFriction * velocity.offGroundTicks) - 1);
            } else
            {
                velocity.offGroundTicks = 0;
                if (velocity.y != 0)
                {
                    velocity.y *= velocity.groundFriction;
                }
            }

            if (hasCollisions())
            {
                
            }

            pictureBox.Top = Convert.ToInt32(pictureBox.Top + (velocity.velocY * velocity.y));

            if (Math.Abs(velocity.x) < 1e-3)
            {
                velocity.x = 0;
            }

            if (Math.Abs(velocity.y) < 1e-3)
            {
                velocity.y = 0;
            }

        }

        private void exit()
        {
            if(Main.ActiveForm == null)
            {
                Application.Exit();
            }
        }

        public bool isDragged()
        {
            return dragged;
        }

        public bool hasGravity()
        {
            return gravity;
        }

        public void destroy()
        {
            parent.Controls.Remove(pictureBox);
            pictureBox.Dispose();
        }

        public void explode(List<Item> list, int radius)
        {
            if(list.Count < 0)
            {
                return;
            }

            if (radius < 1)
            {
                radius = 1;
            }

            PictureBox explosion = new PictureBox
            {
                Image = Dropbox.Properties.Resources.explosion,
                Name = "explode_" + pictureBox.Name,
                Size = new System.Drawing.Size(pictureBox.Height * 2, pictureBox.Height * 2),
                Location = new System.Drawing.Point(pictureBox.Left + (pictureBox.Width / 2), pictureBox.Top + (pictureBox.Height / 2))
            };

            Main.ActiveForm.Controls.Add(explosion);

            Main.ActiveForm.Update();

            radius = radius + (pictureBox.Width + pictureBox.Height / 2);
            List<Item> collected = new List<Item>();
            collected.Add(this);
            int midX = pictureBox.Left + (pictureBox.Width / 2), midY = pictureBox.Top + (pictureBox.Height / 2), minX = midX - (radius / 2), minY = midY - (radius / 2), maxX = midX + (radius / 2), maxY = midY + (radius / 2);
            for (int x = minX; x < maxX; x++)
            {
                for (int y = minY; y < maxY; y++)
                {
                    foreach (Item i in list)
                    {
                        if (i.pictureBox.Left == x && i.pictureBox.Top == y)
                        {
                            collected.Add(i);
                        }
                    }

                }
            }

            foreach(Item i in collected)
            {

                Main.ActiveForm.Controls.Add(new PictureBox
                {
                    Image = Dropbox.Properties.Resources.explosion,
                    Name = "explode_" + pictureBox.Name,
                    Size = new System.Drawing.Size(i.pictureBox.Height * 2, i.pictureBox.Height * 2),
                    Location = new System.Drawing.Point(i.pictureBox.Left + (i.pictureBox.Width / 2), i.pictureBox.Top + (i.pictureBox.Height / 2))
                });


                i.destroy();
            }
        }

        internal Gravity GetVelocity()
        {
            return velocity;
        }

        public void onClick() { }

        public void mouseDown(int x, int y)
        {
        }

        internal void checkBounds()
        {
            throw new NotImplementedException();
        }
    }
}
