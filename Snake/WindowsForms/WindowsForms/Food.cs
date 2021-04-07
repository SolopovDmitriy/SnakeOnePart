using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsForms
{
    class Food : Segment, ISegmentBehavior
    {
        public Food():base()
        {

        }
        public Food(int x, int y, int radius, Color color) :base(x, y, radius, color)
        {

        }
        public void Draw(Graphics graphics)
        {            
            Radius *= 10; // my code
            Image appleImg = Resource.apple6;
            graphics.DrawImage(appleImg, new Rectangle(X - Radius, Y - Radius, Radius * 2, Radius * 2));
        }

        public void Respawn(GameFieldControl gameFieldControl)
        {
            Random random = new Random();
            X = random.Next(Radius, gameFieldControl.Width - Radius);
            Y = random.Next(Radius, gameFieldControl.Height - Radius);
        }
    }
}
