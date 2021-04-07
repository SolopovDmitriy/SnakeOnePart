using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsForms
{    

     // my code
    class SegmentTail : Segment, ISegmentBehavior
    {
        int padding = 1;
        public SegmentTail() : base()
        {

        }
        public SegmentTail(int x, int y, int radius, Color color) : base(x, y, radius, color)
        {

        }
        public void Draw(Graphics graphics)
        {
            Radius -= padding;
            Point[] points = {
                new Point(X - Radius, Y),
                new Point(X + Radius, Y - Radius),
                new Point(X + Radius, Y + Radius)
            };
            graphics.FillPolygon(new SolidBrush(Color), points);
        }
    }
}
