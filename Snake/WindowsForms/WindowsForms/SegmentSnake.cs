using System;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsForms
{
    class SegmentSnake : Segment, ISegmentBehavior
    {
        int padding = 1;
        public SegmentSnake() : base()
        {

        }
        public SegmentSnake(int x, int y, int radius, Color color) : base(x, y, radius, color)
        {

        }
        public void Draw(Graphics graphics)
        {
            Radius -= padding;
            graphics.FillRectangle(new SolidBrush(Color), new Rectangle(X - Radius, Y - Radius, Radius * 2, Radius * 2));
        }
    }
}
